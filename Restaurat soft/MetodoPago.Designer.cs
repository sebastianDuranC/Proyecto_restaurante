namespace Restaurat_soft.Resources
{
    partial class MetodoPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoPago));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCAMBIO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRECIBO = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbxMETODO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnCOMIDA = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texttotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtCAMBIO
            // 
            this.txtCAMBIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCAMBIO.DefaultText = "";
            this.txtCAMBIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCAMBIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCAMBIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCAMBIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCAMBIO.Enabled = false;
            this.txtCAMBIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCAMBIO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCAMBIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCAMBIO.Location = new System.Drawing.Point(35, 273);
            this.txtCAMBIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCAMBIO.Name = "txtCAMBIO";
            this.txtCAMBIO.PasswordChar = '\0';
            this.txtCAMBIO.PlaceholderText = "";
            this.txtCAMBIO.SelectedText = "";
            this.txtCAMBIO.Size = new System.Drawing.Size(139, 30);
            this.txtCAMBIO.TabIndex = 7;
            this.txtCAMBIO.TextChanged += new System.EventHandler(this.txtCAMBIO_TextChanged);
            // 
            // txtRECIBO
            // 
            this.txtRECIBO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRECIBO.DefaultText = "";
            this.txtRECIBO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRECIBO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRECIBO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRECIBO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRECIBO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRECIBO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRECIBO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRECIBO.Location = new System.Drawing.Point(259, 183);
            this.txtRECIBO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRECIBO.Name = "txtRECIBO";
            this.txtRECIBO.PasswordChar = '\0';
            this.txtRECIBO.PlaceholderText = "";
            this.txtRECIBO.SelectedText = "";
            this.txtRECIBO.Size = new System.Drawing.Size(134, 28);
            this.txtRECIBO.TabIndex = 8;
            this.txtRECIBO.TextChanged += new System.EventHandler(this.txtRECIBO_TextChanged);
            this.txtRECIBO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRECIBO_KeyPress);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(57, 149);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(72, 28);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "TOTAL";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(289, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "RECIBO";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(48, 235);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(91, 28);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "CAMBIO";
            // 
            // cbxMETODO
            // 
            this.cbxMETODO.BackColor = System.Drawing.Color.Transparent;
            this.cbxMETODO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMETODO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMETODO.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMETODO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMETODO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMETODO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxMETODO.ItemHeight = 30;
            this.cbxMETODO.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA",
            "QR"});
            this.cbxMETODO.Location = new System.Drawing.Point(253, 273);
            this.cbxMETODO.Name = "cbxMETODO";
            this.cbxMETODO.Size = new System.Drawing.Size(140, 36);
            this.cbxMETODO.TabIndex = 12;
            this.cbxMETODO.SelectedIndexChanged += new System.EventHandler(this.cbxMETODO_SelectedIndexChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(248, 238);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(153, 25);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Metodo de Pago";
            // 
            // btnCOMIDA
            // 
            this.btnCOMIDA.Image = ((System.Drawing.Image)(resources.GetObject("btnCOMIDA.Image")));
            this.btnCOMIDA.Location = new System.Drawing.Point(115, 341);
            this.btnCOMIDA.Name = "btnCOMIDA";
            this.btnCOMIDA.Size = new System.Drawing.Size(163, 65);
            this.btnCOMIDA.TabIndex = 15;
            this.btnCOMIDA.Text = "    GUARDAR";
            this.btnCOMIDA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCOMIDA.UseVisualStyleBackColor = true;
            this.btnCOMIDA.Click += new System.EventHandler(this.btnCOMIDA_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "15:10:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "29/5/2023";
            // 
            // texttotal
            // 
            this.texttotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texttotal.DefaultText = "";
            this.texttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texttotal.Enabled = false;
            this.texttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texttotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texttotal.Location = new System.Drawing.Point(35, 183);
            this.texttotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texttotal.Name = "texttotal";
            this.texttotal.PasswordChar = '\0';
            this.texttotal.PlaceholderText = "";
            this.texttotal.SelectedText = "";
            this.texttotal.Size = new System.Drawing.Size(128, 28);
            this.texttotal.TabIndex = 6;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(275, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // MetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCOMIDA);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbxMETODO);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtRECIBO);
            this.Controls.Add(this.txtCAMBIO);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MetodoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.MetodoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtCAMBIO;
        private Guna.UI2.WinForms.Guna2TextBox txtRECIBO;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMETODO;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Button btnCOMIDA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox texttotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label3;
    }
}