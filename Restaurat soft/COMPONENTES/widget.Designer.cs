namespace Restaurat_soft.COMPONENTES
{
    partial class sopaMANI
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sopaMANI));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPRECIOC = new System.Windows.Forms.Label();
            this.ptbSOPA = new Guna.UI.WinForms.GunaPictureBox();
            this.lblSOPA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSOPA)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Controls.Add(this.ptbSOPA);
            this.gunaShadowPanel1.Controls.Add(this.lblSOPA);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(230, 221);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPRECIOC);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 48);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.ptbSOPA_Click);
            // 
            // lblPRECIOC
            // 
            this.lblPRECIOC.AutoSize = true;
            this.lblPRECIOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRECIOC.ForeColor = System.Drawing.Color.Green;
            this.lblPRECIOC.Location = new System.Drawing.Point(75, 9);
            this.lblPRECIOC.Name = "lblPRECIOC";
            this.lblPRECIOC.Size = new System.Drawing.Size(61, 25);
            this.lblPRECIOC.TabIndex = 0;
            this.lblPRECIOC.Text = "8 Bs.";
            // 
            // ptbSOPA
            // 
            this.ptbSOPA.BaseColor = System.Drawing.Color.White;
            this.ptbSOPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSOPA.Image = ((System.Drawing.Image)(resources.GetObject("ptbSOPA.Image")));
            this.ptbSOPA.Location = new System.Drawing.Point(53, 54);
            this.ptbSOPA.Name = "ptbSOPA";
            this.ptbSOPA.Size = new System.Drawing.Size(98, 102);
            this.ptbSOPA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSOPA.TabIndex = 2;
            this.ptbSOPA.TabStop = false;
            this.ptbSOPA.Click += new System.EventHandler(this.ptbSOPA_Click);
            // 
            // lblSOPA
            // 
            this.lblSOPA.AutoSize = true;
            this.lblSOPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSOPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOPA.Location = new System.Drawing.Point(18, 26);
            this.lblSOPA.Name = "lblSOPA";
            this.lblSOPA.Size = new System.Drawing.Size(156, 25);
            this.lblSOPA.TabIndex = 0;
            this.lblSOPA.Text = "SOPA DE MANÍ";
            this.lblSOPA.Click += new System.EventHandler(this.ptbSOPA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "8,50";
            this.label1.Visible = false;
            // 
            // sopaMANI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "sopaMANI";
            this.Size = new System.Drawing.Size(230, 221);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSOPA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaPictureBox ptbSOPA;
        public System.Windows.Forms.Label lblSOPA;
        public System.Windows.Forms.Label lblPRECIOC;
        public System.Windows.Forms.Label label1;
    }
}
