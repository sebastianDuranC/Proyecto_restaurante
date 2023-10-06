using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Restaurat_soft
{
    public partial class FRMAGREGAR : Form
    {
        string contraseña = "admin";

        SqlConnection cnn = new SqlConnection("server=LAPTOP-NHM1I0G4\\SQLEXPRESS;database=SoftRESTAURANT;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        public FRMAGREGAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            

        }




        private void FRMAGREGAR_Load(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text==contraseña)
            {



                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox6.Text.Trim() != "")
                {


                    cnn.Open();

                    string cadena = $"insert into empleados(id,nombre,apellidos,telefono,salario,categoria) values(" + Convert.ToInt32(textBox1.Text) + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + Convert.ToInt32(textBox4.Text) + "," + Convert.ToInt32(textBox5.Text) + ",'" + textBox6.Text + "')";
                    cmd = new SqlCommand(cadena, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    textBox1.Text = "";
                  textBox2.Text = "";
                  textBox3.Text = "";
                  textBox4.Text = "";
                  textBox5.Text = "";
                  textBox6.Text = "";
                  textBox7.Text = "";
                   MessageBox.Show("PERSONA REGISTRADA");

                }
                else
                {
                    MessageBox.Show("INGRESE LOS DATOS");
                    textBox7.Text = "";
                }
               
            }
            else
            {
                MessageBox.Show("CONTRASEÑA INCORRECTA");
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormEMPLEADOS EMPLEADOS = new FormEMPLEADOS();
            EMPLEADOS.Show();
            this.Close();

        }

        private void pictMOSTRAR_Click(object sender, EventArgs e)
        {
            pictOCULTAR.BringToFront(); 
            textBox7.PasswordChar= '\0';



        }

        private void pictOCULTAR_Click(object sender, EventArgs e)
        {
            pictMOSTRAR.BringToFront();
            textBox7.PasswordChar = '*';

        }

        private void button1_Click_1(object sender, EventArgs e)
        {





        }
    }
}
