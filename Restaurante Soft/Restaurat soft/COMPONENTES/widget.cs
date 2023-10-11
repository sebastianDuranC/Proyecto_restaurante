using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurat_soft.COMPONENTES
{     public enum categories { comida, bebidas, postre}
    public partial class sopaMANI : UserControl
    {
       public event EventHandler onselect = null;
        private categories _category;
        private double _cost;
        private double _total;


        public sopaMANI()
        {
            InitializeComponent();
        }
       
        private void ptbSOPA_Click(object sender, EventArgs e)
        {
            onselect?.Invoke(this, e);    
           
        }

       

        public categories category { get=>_category;  set=>_category= value; }

        public string id { get; set; }
        public string title { get => lblSOPA.Text; set => lblSOPA.Text = value; }

        public double cost { get => _cost ; set { _cost = value;lblPRECIOC.Text = _cost.ToString("C2"); } }
        public double total { get => _total; set { _total = value; label1.Text = _total.ToString("N2"); } }

        public Image ico { get => ptbSOPA.Image; set => ptbSOPA.Image = value; }
    }
}
