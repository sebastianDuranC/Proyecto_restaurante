using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurat_soft.Resources
{
    public partial class MetodoPago : Form

    {
        SqlConnection cnn = new SqlConnection("server=LAPTOP-NHM1I0G4\\SQLEXPRESS;database=SoftRESTAURANT;integrated security=true");
        SqlCommand cmd = new SqlCommand();

       
        private Timer ti, ti2;
        public MetodoPago()
        {
            InitializeComponent();

            ti = new Timer();
            ti.Tick += new EventHandler(timer1_Tick);
            ti.Enabled = true;
            ti2 = new Timer();
            ti2.Tick += new EventHandler(timer1_Tick);
            ti2.Enabled = true;


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            

        }
        void calcularCAMBIO()
        {

            try
            {





                double recibo = double.Parse(txtRECIBO.Text);
                     double total = double.Parse(texttotal.Text);
                   double cambio;


                      cambio = recibo - total;



                  txtCAMBIO.Text = cambio.ToString();





            }
            catch (Exception)
            {
                MessageBox.Show("NO SE INGRESO NINGUN DATOS PARA CALCULAR", "ERRROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
            



        }


        private void MetodoPago_Load(object sender, EventArgs e)
        {

        }

        private void txtCAMBIO_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcularCAMBIO();
         


        }

        private void cbxMETODO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRECIBO_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCOMIDA_Click(object sender, EventArgs e)
        {
            cbxMETODO.Text = "";
            texttotal.Text = "";
            txtCAMBIO.Text = "";
            txtRECIBO.Text = "";

            MessageBox.Show("PEDIDO REALIZADO CORRECTAMENTE", "GUARDANDO",MessageBoxButtons.OK);

            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtCAMBIO_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtRECIBO_TextChanged(object sender, EventArgs e)
        {
            if (txtRECIBO.Text!="")
            {
                double suma = Convert.ToDouble(txtRECIBO.Text)- Convert.ToDouble(texttotal.Text);
                txtCAMBIO.Text = suma.ToString();
                   
                
                //double cambio;
                   //double recibo = double.Parse(txtRECIBO.Text);
                   //double total = double.Parse(TxtTotal.Text);
                   


                   //  cambio = recibo - total;



                   //   txtCAMBIO.Text = cambio.ToString();
               }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime hoy = DateTime.Now;
            label1.Text = hoy.ToString("hh:mm:ss");

            DateTime fecha = DateTime.Now;
            label2.Text = fecha.ToString("D");
        }
    }
}
