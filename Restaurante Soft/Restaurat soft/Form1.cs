using Restaurat_soft.Resources;
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
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection("server=SEBASTIAN_DURAN\\SQLSERVER_SEBAS;database=SoftRESTAURANT;integrated security=true");
       SqlCommand cmd=new SqlCommand();
        string NombreAcceso;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text=="")
            {

                MessageBox.Show("VERIFIQUE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else { 

            if (mainclass.validar(textBox1.Text, textBox2.Text)==false)
            {
              
                  MessageBox.Show("INVALIDO USUARIO...VERIFIQUE");
               
            }
            else
            {

                    cnn.Open();
                    string username = textBox1.Text;
                    string uspass = textBox2.Text;

                    string cadena = $"SELECT nombre FROM acceso WHERE username = '{username}' AND uspass = '{uspass}'";


                    cmd = new SqlCommand(cadena, cnn);

                    new SqlCommand(cadena, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {


                        NombreAcceso = reader["nombre"].ToString();
                        ACCESO F1 = new ACCESO();
                        F1.label8.Text = NombreAcceso;
                        F1.Show();

                        label1.Text = "Nombre encontrado: " + NombreAcceso;


                    }

                    cnn.Close();

                    this.Hide();
              
                    
                }




            }

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

          this.Close();

           
        }
       


    

        private void pictMOSTRAR_Click(object sender, EventArgs e)
        {
            pictOCULTAR.BringToFront();
            textBox2.PasswordChar= '\0'; 
        }

        private void pictOCULTAR_Click(object sender, EventArgs e)
        {
            pictMOSTRAR.BringToFront();
            textBox2.PasswordChar= '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            validar validar = new validar();
            validar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
