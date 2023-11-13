namespace Restaurat_soft
{
    partial class AGREGAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGREGAR));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.agregar_imagen = new Guna.UI2.WinForms.Guna2Button();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.guardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // agregar_imagen
            // 
            this.agregar_imagen.BorderRadius = 1;
            this.agregar_imagen.BorderThickness = 1;
            this.agregar_imagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.agregar_imagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.agregar_imagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.agregar_imagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.agregar_imagen.FillColor = System.Drawing.Color.RoyalBlue;
            this.agregar_imagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.agregar_imagen.ForeColor = System.Drawing.Color.White;
            this.agregar_imagen.Location = new System.Drawing.Point(466, 239);
            this.agregar_imagen.Name = "agregar_imagen";
            this.agregar_imagen.Size = new System.Drawing.Size(180, 45);
            this.agregar_imagen.TabIndex = 8;
            this.agregar_imagen.Text = "Agregar Imagen";
            this.agregar_imagen.Click += new System.EventHandler(this.agregar_comida_Click);
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "Comida",
            "Bebidas",
            "Postres"});
            this.cb_categoria.Location = new System.Drawing.Point(64, 224);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(121, 24);
            this.cb_categoria.TabIndex = 10;
            this.cb_categoria.Text = "SELECCIONE ";
            // 
            // guardar
            // 
            this.guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardar.BackgroundImage")));
            this.guardar.BorderRadius = 1;
            this.guardar.BorderThickness = 1;
            this.guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(245, 307);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(142, 45);
            this.guardar.TabIndex = 9;
            this.guardar.Text = "GUARDAR";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // txtImage
            // 
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.Location = new System.Drawing.Point(466, 68);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(164, 151);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 0;
            this.txtImage.TabStop = false;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(261, 117);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 22);
            this.txtprecio.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 55);
            this.label7.TabIndex = 21;
            this.label7.Text = "EXTRA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "PRECIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "CATEGORIA";
            // 
            // AGREGAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.agregar_imagen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtImage);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AGREGAR";
            this.Text = "AGREGAR";
            this.Load += new System.EventHandler(this.AGREGAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox txtImage;
        private System.Windows.Forms.TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2Button agregar_imagen;
        private Guna.UI2.WinForms.Guna2Button guardar;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}