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
using static Restaurat_soft.AGREGAR;
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

            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            btnBorrar.Name = "Eliminar";
            grid1.Columns.Add(btnBorrar);
            DTPRODUCTO();        
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
            foreach (DataGridViewRow row in grid1.Rows)
            {

                count++;
                row.Cells[1].Value = count;
               


            }
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
                foreach (DataGridViewRow item in grid1.Rows)
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

                grid1.Rows.Add(new object[] {wdg.lblSOPA.Text,1, wdg.lblPRECIOC.Text,wdg.label1.Text });
                calcular();
            };
           
        }
       
      
        

        private void calcular()
        {
            double total = 0;
            lblPRECIO.Text = "";
            foreach (DataGridViewRow item in grid1.Rows)
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
            if (grid1.Rows.Count>0)
            {
                try
                {
                    DialogResult rppt = MessageBox.Show("DESEAR ELIMINAR PEDIDO? ", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rppt == DialogResult.Yes)
                    {



                        grid1.Rows.Clear();
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
           
            if (grid1.Rows.Count > 0)
                {
                    try
                    {
                        DialogResult rppt = MessageBox.Show("DESEA CONTINUAR CON LA COMPRA? ", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rppt == DialogResult.Yes)
                        {

                  
                         MetodoPago F1 = new MetodoPago();
                         F1.texttotal.Text = lblPRECIO.Text;
                         F1.lblNombreACCESO.Text = label4.Text;

                        AddOwnedForm(F1);
                      
                      
                          F1.Show();


                        lblPRECIO.Text = "";
                         //grid1.Rows.Clear();
    
                       



                        
               

                            
                        }
                    }
                    catch (Exception)
                    {


                    }

                } else
                {
                    MessageBox.Show("NO TIENE PRODUCTOS AGREGADO...", "VERIFIQUE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid1.Rows.Clear();
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


        private void addItem_Click(object sender, EventArgs e)
        {
            AGREGAR aGREGAR = new AGREGAR();
            aGREGAR.SetMenuForm(this);
            aGREGAR.Show();


        }

        private void MENÚ_Shown(object sender, EventArgs e)
        {
            AddItems("Sopa de mani - Comida", 8.50, 8.50, categories.comida, "comida1.jpg");
            AddItems("Pique Macho - Comida", 50, 50, categories.comida, "comida.png");
            AddItems("Chancho al Horno - Comida", 20, 20, categories.comida, "comida3.jpg");
            AddItems("Coca Cola 2 litros - Bebida", 10, 10, categories.bebidas, "bebida.jpg");
            AddItems("Locro Gallina - Comida", 10, 10, categories.bebidas, "comida5.jpg");


       

        }

       

      
   

        

        
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.grid1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                grid1.Rows.Remove(grid1.CurrentRow);
                calcular();
            }

        }

        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.ColumnIndex >= 0 && this.grid1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            //{

            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    DataGridViewButtonCell celbtn = this.grid1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
            //    Icon icon = new Icon(Environment.CurrentDirectory + @"\\\delete.ico");
            //    e.Graphics.DrawIcon(icon, e.CellBounds.Left + 1, e.CellBounds.Top + 1);

            //    this.grid1.Rows[e.RowIndex].Height = icon.Height + 1;
            //    this.grid1.Columns[e.ColumnIndex].Width = icon.Width + 1;

            //    e.Handled = true;

            //}

                if (e.ColumnIndex >= 0 && this.grid1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    DataGridViewButtonCell celbtn = this.grid1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                    // Cargar el ícono y redimensionarlo a un tamaño específico (por ejemplo, 16x16 píxeles)
                    Icon originalIcon = new Icon(Environment.CurrentDirectory + @"\delete.ico");
                    Bitmap resizedIcon = new Bitmap(originalIcon.ToBitmap(), new Size(40, 40));

                    // Dibujar el ícono redimensionado en la celda
                    e.Graphics.DrawImage(resizedIcon, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                    this.grid1.Rows[e.RowIndex].Height = resizedIcon.Height + 8;
                    this.grid1.Columns[e.ColumnIndex].Width = resizedIcon.Width + 8;

                    e.Handled = true;
                }
            

        }
        private DataGridView dt_producto;

        public DataGridView Dt_producto { get => dt_producto; set => dt_producto = value; }

        public void DTPRODUCTO()
        {



            Dt_producto = grid1;
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AgregarComida(Comida nuevaComida)
        {
            // Agrega la nueva comida a tu menú utilizando la función AddItems.
            AddItems(nuevaComida.Nombre, nuevaComida.Costo, nuevaComida.Costo, categories.comida ,"Pollo_horno.jpg");


        }

    }
}
