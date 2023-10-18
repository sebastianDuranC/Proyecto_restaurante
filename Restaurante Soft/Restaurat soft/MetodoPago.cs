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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurat_soft.Resources
{
    public partial class MetodoPago : Form

    {

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
            // TODO: esta línea de código carga datos en la tabla 'softRESTAURANTDataSet4.pedidos' Puede moverla o quitarla según sea necesario.


           

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
            txtCAMBIO.Text = "";
            txtRECIBO.Text = "";

            textBox1.Text = "";
            textBox2.Text = "";
          

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
                   
             
               }

        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
          

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text==""||txtRECIBO.Text=="")
            {
                MessageBox.Show("Campo vacio","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {


                clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

                Ticket1.TextoCentro("xxxx Restaurant Victoria xxxxx "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda("          Santa Cruz - Bolivia   ");
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda("Dirc: 6to Anillo Av.Banzer #10");
                Ticket1.TextoIzquierda("Tel:62040124 ");
                Ticket1.TextoIzquierda("Nit: 107245814");
                Ticket1.TextoIzquierda("   ");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda("NIT: " + textBox1.Text);
                Ticket1.TextoIzquierda("Razón Social: " + textBox2.Text);
                Ticket1.TextoIzquierda("Fecha Emision: " + DateTime.Now.ToShortDateString() + "  /  " + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Emitido por: " + lblNombreACCESO.Text);
                Ticket1.TextoIzquierda(" ");
                clsFactura.CreaTicket.LineasGuion();

                clsFactura.CreaTicket.EncabezadoVenta();
                clsFactura.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in grid2.Rows)
                {
                    // PROD                     //PrECIO                                    CANT                         TOTAL
                    //Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), int.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[3].Value.ToString())); //imprime una linea de descripcion

                    //Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[1].Value.ToString(), .Parse(r.Cells[2].Value.ToString()))) ; //imprime una linea de descripcion

                }




                clsFactura.CreaTicket.LineasGuion();

                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", double.Parse(texttotal.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtRECIBO.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtCAMBIO.Text));


                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("        By: Fabio Zambrana       ");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);

                MessageBox.Show("Gracias por preferirnos");

                
                this.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
            
                DialogResult rppt = MessageBox.Show("Desea Cancelar el Pedido?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rppt != DialogResult.No)
                {

                    Close();



                }
          







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
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
