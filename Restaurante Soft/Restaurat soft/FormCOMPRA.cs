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
            mainclass.añadircompra(Convert.ToInt16(txtcantidad.Text), txtNOMBRE.Text, Convert.ToDouble(txtprecio.Text), cbtipopago.Text, Convert.ToDouble(txtprecio.Text) * Convert.ToInt16(txtcantidad.Text));





            txtcantidad.Clear();
            txtNOMBRE.Clear();
            txtprecio.Clear();
            cbtipopago.Text = "";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCOMPRA_Load(object sender, EventArgs e)
        {
            actualizar_tabla();

        }
        void actualizar_tabla()
        {
            dataGridView1.DataSource = mainclass.TB_compras();
        }

        private void txtNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
