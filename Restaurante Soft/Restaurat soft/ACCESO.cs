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
    public partial class ACCESO : Form
    {
       
        public ACCESO()
        {
            InitializeComponent();
         

        }
    

        private void label3_Click(object sender, EventArgs e)
        {
          


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FormEMPLEADOS empleados = new FormEMPLEADOS();
            empleados.Show();
            this.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

            FormEMPLEADOS empleados = new FormEMPLEADOS();
            empleados.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MENÚ menu=new MENÚ();
            menu.label4.Text = label8.Text;
            menu.Show();
            this.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {
            MENÚ MENU =new MENÚ();
            MENU.Show();    
            this.Close();





        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            inventario inventario =new inventario();
            inventario.Show();  
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            inventario inventario = new inventario();
            inventario.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            VENTAS VENTAS=new VENTAS();
            VENTAS.ShowDialog();
            this.Close();

           
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FormCOMPRA COMPRA = new FormCOMPRA();
            COMPRA.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
