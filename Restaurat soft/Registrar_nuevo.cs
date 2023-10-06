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
    public partial class Registrar_nuevo : Form
    {
        SqlConnection cnn = new SqlConnection("server=LAPTOP-NHM1I0G4\\SQLEXPRESS;database=SoftRESTAURANT;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        public Registrar_nuevo()
        {
            InitializeComponent();
        }

        private void pictMOSTRAR_Click(object sender, EventArgs e)
        {
            pictOCULTAR.BringToFront();
            txtCONTRASEÑA.PasswordChar = '\0';
            txtREPETIR.PasswordChar = '\0';
        }

        private void pictOCULTAR_Click(object sender, EventArgs e)
        {
            pictMOSTRAR.BringToFront();
            txtCONTRASEÑA.PasswordChar = '*';
            txtREPETIR.PasswordChar = '*';
        }

        private void btnCOMIDA_Click(object sender, EventArgs e)
        {

            if (txtCONTRASEÑA.Text != txtREPETIR.Text)
            {

                MessageBox.Show("VERIFIQUE SI COINCIDA LA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {




                if (txtNOMBRE.Text.Trim() != "" && txtCONTRASEÑA.Text.Trim() != "" && txtUSUARIO.Text.Trim() != "" && txtREPETIR.Text.Trim() != "")
                {


                    cnn.Open();

                    string cadena = $"insert into acceso (username,uspass,nombre) values('" + txtUSUARIO.Text + "','" + txtREPETIR.Text + "','" + txtNOMBRE.Text + "')";
                    cmd = new SqlCommand(cadena, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    txtNOMBRE.Text = "";
                    txtCONTRASEÑA.Text = "";
                    txtUSUARIO.Text = "";
                    txtREPETIR.Text = "";

                    MessageBox.Show("PERSONA REGISTRADA");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("INGRESE LOS DATOS");
                }
            }
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gestionar_ACCESO acceso = new gestionar_ACCESO();
            acceso.Show();
        }
    }
}
