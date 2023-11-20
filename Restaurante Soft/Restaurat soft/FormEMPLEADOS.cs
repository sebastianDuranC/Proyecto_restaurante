using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Restaurat_soft
{
    public partial class FormEMPLEADOS : Form
    {
        SqlConnection cnn = new SqlConnection("server=SEBASTIAN_DURAN\\SQLSERVER_SEBAS;database=SoftRESTAURANT;integrated security=true");
        SqlCommand cmd = new SqlCommand();

       
        public FormEMPLEADOS()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            FRMAGREGAR agregar = new FRMAGREGAR();
            agregar.ShowDialog();

            this.Close();






        }

        private void FormEMPLEADOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softRESTAURANTDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter2.Fill(this.softRESTAURANTDataSet.empleados);
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ACCESO acceso = new ACCESO();   
            acceso.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
              
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value .ToString();  
        }
        public void actualizar()
        {

            string consulta = " select * from empleados";
            SqlDataAdapter adapter= new SqlDataAdapter(consulta,cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {

            

              string CONSULTA = $" select * from empleados where id= " + textBox1.Text + "";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            actualizar();
            textBox1.Text = " ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            cnn.Open();

            string CONSULTA = "delete from empleados where id= "+ textBox1.Text +"";
            cmd = new SqlCommand(CONSULTA, cnn);
            cmd.ExecuteNonQuery();

            MessageBox.Show(" REGISTRO ELIMINADO ");

            actualizar();
            cnn.Close();

        }
    }
}
