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
    public partial class FormCOMPRA : Form
    {
        public FormCOMPRA()
        {
            InitializeComponent();
        }

        private void btnCOMIDA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1["Cantidad", i].Value = txtcantidad.Text;
                dataGridView1["Producto", i].Value = txtNOMBRE.Text;
                dataGridView1["Precio", i].Value = txtprecio.Text;
                dataGridView1["Tipo_de_Pago", i].Value = cbtipopago.Text;
                dataGridView1["Precio_Final", i].Value = (Convert.ToInt32(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text)).ToString();

            }
            txtcantidad.Clear();
            txtNOMBRE.Clear();
            txtprecio.Clear();
            cbtipopago.Text = "";


        }
    }
}
