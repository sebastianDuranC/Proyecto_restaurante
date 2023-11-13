using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurat_soft
{
    public partial class inventario : Form
    {
        SqlConnection cnn = new SqlConnection("server=LAPTOP-NHM1I0G4\\SQLEXPRESS;database=SoftRESTAURANT;integrated security=true");
        SqlCommand cmd = new SqlCommand();

        private string id = null;


        public inventario()
        {
            InitializeComponent();
           
        }

   
        public void actualizar()
        {

            string consulta = " select * from producto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
        }
     private void inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softRESTAURANTDataSet1.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.softRESTAURANTDataSet1.producto);
            actualizar();
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            btnBorrar.Name = "Eliminar";
            dataGridView1.Columns.Add(btnBorrar);

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ACCESO acceso = new ACCESO();
            acceso.Show();
            this.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Trim()!=""|| txtDESCRIPCION.Text != ""|| txtMARCA.Text.Trim() != ""|| txtPRECIO.Text.Trim() != ""|| txtSTOCK.Text.Trim() != "")
            {



                cnn.Open();
                string cadena = $"insert into producto (NOMBRE,DESCRIPCION,MARCA,PRECIO,STOCK) values('" + txtNombre.Text + "','" + txtDESCRIPCION.Text + "','" + txtMARCA.Text + "'," + float.Parse (txtPRECIO.Text) + "," + Convert.ToInt32(txtSTOCK.Text) + ")";
                cmd = new SqlCommand(cadena, cnn);
                cmd.ExecuteNonQuery();
               actualizar();
                cnn.Close();


                txtNombre.Text = "";
                txtDESCRIPCION.Text = "";
                txtMARCA.Text = "";
                txtPRECIO.Text = "";
                txtSTOCK.Text = "";

                MessageBox.Show("PRODUCTO REGISTRADO");

            }
            else
            {
                MessageBox.Show(" VERIFIQUE SI LOS DATOS SON CORRECTO "," FALTA DATOS ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                     cnn.Open();
                id = dataGridView1.SelectedCells[0].Value.ToString();
              

                string CONSULTA = " delete from producto where id= "+id+"";
                cmd = new SqlCommand(CONSULTA, cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" REGISTRO ELIMINADO ");

                actualizar();
                cnn.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }


        

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calcular();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celbtn = this.dataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icon = new Icon(Environment.CurrentDirectory + @"\\\delete.ico");
                e.Graphics.DrawIcon(icon, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icon.Height + 1;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icon.Width + 1;

                e.Handled = true;

            }
        }
    }
}
