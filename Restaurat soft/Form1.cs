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
                   
                this.Hide();
                    ACCESO frmacceso = new ACCESO();
                    frmacceso.Show();

                
            }



                
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
