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

namespace Restaurat_soft
{
    public partial class gestionar_ACCESO : Form
    {
        SqlConnection cnn = new SqlConnection("server=LAPTOP-NHM1I0G4\\SQLEXPRESS;database=SoftRESTAURANT;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        public gestionar_ACCESO()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {



                string CONSULTA = $" select * from ACCESO where userid = " + textBox1.Text + "";
                SqlDataAdapter adapter = new SqlDataAdapter(CONSULTA, cnn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            else
            {


                MessageBox.Show("INTRODUZCA EL ID");
            }

        }

        public void actualizar()
        {

            string consulta = "select * from ACCESO";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            actualizar();
            textBox1.Text = " ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


            DialogResult rppt = MessageBox.Show("DESEAR ELIMINAR ACCESO? ", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rppt == DialogResult.Yes)
            {
                cnn.Open();

                string CONSULTA = "delete from ACCESO where  userid = " + textBox1.Text + "";
                cmd = new SqlCommand(CONSULTA, cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" REGISTRO ELIMINADO ");

                actualizar();
                cnn.Close();
            }




        }

        private void gestionar_ACCESO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softRESTAURANTDataSet3.acceso' Puede moverla o quitarla según sea necesario.
            this.accesoTableAdapter.Fill(this.softRESTAURANTDataSet3.acceso);

        }
    }
}
