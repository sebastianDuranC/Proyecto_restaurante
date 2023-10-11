using Bunifu.UI.WinForms.Helpers.Transitions;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using Restaurat_soft.COMPONENTES;
using Restaurat_soft.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurat_soft
{
    public partial class MENÚ : Form
    { private Timer ti, ti2;
      
        public MENÚ()
        {
            InitializeComponent();
            ti = new Timer();
            ti.Tick += new EventHandler(timer);
            ti.Enabled = true;
            ti2 = new Timer();
            ti2.Tick += new EventHandler(timer);
            ti2.Enabled = true;
            
        }


        private void MENÚ_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softRESTAURANTDataSet2.pedidos' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.softRESTAURANTDataSet2.pedidos);
            this.WindowState = FormWindowState.Maximized;

            //gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ACCESO ACCESO = new ACCESO();
            ACCESO.Show();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void jUEVESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            ACCESO aCCESO= new ACCESO();    
            aCCESO.Close();

            Form1 form = new Form1();
            form.ShowDialog();  

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ACCESO aCCESO = new ACCESO();
            aCCESO.Show();
            this.Close();
        }

        private void button4_Click(object sender,EventArgs e)
        {

            panelPRODUCTO.Visible = true;
            lblOPCION.Text = "TODOS";
            textBuscar.Text = "";

            textBuscar.Text = "";


            
        }

        private void btnCOMIDA_Click(object sender, EventArgs e)
        {
          
            lblOPCION.Text = "COMIDA";
            textBuscar.Text = "Comida";
           
       

            foreach (var item in panelPRODUCTO.Controls)
            {
                var wdg = (sopaMANI)item;

                wdg.Visible = wdg.lblSOPA.Text.ToLower().ToLower().Contains(textBuscar.Text.Trim().ToLower());




            }


        }

        private void btnBEBIDA_Click(object sender, EventArgs e)
        {
            lblOPCION.Text = "BEBIDA";
            textBuscar.Text = "";
            //calcular();
            textBuscar.Text = "Bebida";
        }

        private void btnPOSTRE_Click(object sender, EventArgs e)
        {
            lblOPCION.Text = "POSTRE";
            textBuscar.Text = "Postre";
        }

        private void timer(object ob, EventArgs evt)
        {

            DateTime hoy = DateTime.Now;
            label1.Text = hoy.ToString("hh:mm:ss");

            DateTime fecha = DateTime.Now;
            label2.Text = fecha.ToString("D");
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {

                count++;
                row.Cells[1].Value = count;
               


            }
        }

        private void gunaDataGridView1_C(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();

        }


     
        public void AddItems(string name, double coste,double total, categories  category, string icon)
        {
            var w = new sopaMANI() {
                title = name,
                cost = coste,
                total= total,
                category = category,
                ico = System.Drawing.Image.FromFile("icons/" + icon),
                Tag = category  
               


            };
            panelPRODUCTO.Controls.Add(w);
            w.onselect += (ss, ee) =>
            { 
                var wdg = (sopaMANI)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.id)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString())+1 ;
                        //item.Cells[3].Value = (double.Parse(item.Cells[1].Value.ToString()) *
                        //                               double.Parse(item.Cells[3].Value.ToString().Replace("$", ""))).ToString("N2"); ;
                        item.Cells[3].Value = (double.Parse(item.Cells[1].Value.ToString()) *
                                                       double.Parse(item.Cells[3].Value.ToString().Replace("$", ""))).ToString("N2"); ;
                        calcular();
                        return;

                    }
                }

                grid.Rows.Add(new object[] {wdg.lblSOPA.Text,1, wdg.lblPRECIOC.Text,wdg.label1.Text });
                calcular();
            };
           
        }

        private void calcular()
        {
            double total = 0;
            lblPRECIO.Text = "";
            foreach (DataGridViewRow item in grid.Rows)
            {
                total += double.Parse(item.Cells[3].Value.ToString());

            }

           lblPRECIO.Text= total.ToString("N2");


        }
      

        private void txtBUSCAR_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void txtBUSCAR_KeyUp(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

            foreach (var item in panelPRODUCTO.Controls)
            {
                var wdg = (sopaMANI)item;

                wdg.Visible = wdg.lblSOPA.Text.ToLower().ToLower().Contains(textBuscar.Text.Trim().ToLower());




            }
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter ||textBuscar.Text. Trim().Length == 0)
            {

                foreach (var item in panelPRODUCTO.Controls)
                {
                    var wdg = (sopaMANI)item;

                    wdg.Visible = wdg.lblSOPA.Text.ToLower().ToLower().Contains(textBuscar.Text.Trim().ToLower());
                        



                }

            }
        }
       
        private void MenuDIA_Paint(object sender, PaintEventArgs e)
        {
          


        }

        private void btnREMOVER_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count>0)
            {
                try
                {
                    DialogResult rppt = MessageBox.Show("DESEAR ELIMINAR PEDIDO? ", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rppt == DialogResult.Yes)
                    {



                        grid.Rows.Clear();
                        lblPRECIO.Text = "0.00";
                    }
                }
                catch (Exception)
                {


                }

            }
            else
            {
                MessageBox.Show("No tienes productos agregado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }




        }


      

        private void button1_Click(object sender, EventArgs e)
        {
           

                if (grid.Rows.Count > 0)
                {
                    try
                    {
                        DialogResult rppt = MessageBox.Show("DESEA CONTINUAR CON LA COMPRA? ", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rppt == DialogResult.Yes)
                        {

                  
                         MetodoPago F1 = new MetodoPago();
                         F1.texttotal.Text = lblPRECIO.Text;
                         F1.lblNombreACCESO.Text = label4.Text;
                           F1.grid2 = grid;

                      
                          F1.Show();

                        lblPRECIO.Text = "";
                        grid.Rows.Clear();

                       



                        
               

                            
                        }
                    }
                    catch (Exception)
                    {


                    }

                } else
                {
                    MessageBox.Show("NO TIENE PRODUCTOS AGREGADO...", "VERIFIQUE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid.Rows.Clear();
                }

              
            

        }

    
        private void panelPRODUCTO_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void lblPRECIO_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MENÚ_Shown(object sender, EventArgs e)
        {
            AddItems("Sopa de mani - Comida", 8.50, 8.50, categories.comida, "comida1.jpg");
            AddItems("Pique Macho - Comida", 50, 50, categories.comida, "comida.png");
            AddItems("Chancho al Horno - Comida", 20, 20, categories.comida, "comida3.jpg");
            AddItems("Coca Cola 2 litros - Bebida", 10, 10, categories.bebidas, "bebida.jpg");
            AddItems("Locro Gallina - Comida", 10, 10, categories.bebidas, "comida5.jpg");



        }



    }
}
