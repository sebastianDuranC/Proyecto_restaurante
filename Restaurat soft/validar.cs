using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurat_soft
{
    public partial class validar : Form
    {
        public validar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainclass.validar(textBox1.Text, textBox2.Text) == false)
            {

                MessageBox.Show("INVALIDO USUARIO...VERIFIQUE");

            }
            else
            {

                this.Hide();
                Registrar_nuevo registrar = new Registrar_nuevo();
 
                registrar.Show();


            }
        }

        private void pictMOSTRAR_Click(object sender, EventArgs e)
        {
            pictOCULTAR.BringToFront();
            textBox2.PasswordChar = '\0';
        }

        private void pictOCULTAR_Click(object sender, EventArgs e)
        {
            pictMOSTRAR.BringToFront();
            textBox2.PasswordChar = '*';
        }
    }
}
