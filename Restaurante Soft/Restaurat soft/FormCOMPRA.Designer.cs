namespace Restaurat_soft
{
    partial class FormCOMPRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCOMPRA));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCOMIDA = new System.Windows.Forms.Button();
            this.cbtipopago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.Precio,
            this.Tipo_de_Pago,
            this.Precio_Final});
            this.dataGridView1.Location = new System.Drawing.Point(13, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 258);
            this.dataGridView1.TabIndex = 20;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Tipo_de_Pago
            // 
            this.Tipo_de_Pago.HeaderText = "Tipo_de_Pago";
            this.Tipo_de_Pago.MinimumWidth = 6;
            this.Tipo_de_Pago.Name = "Tipo_de_Pago";
            // 
            // Precio_Final
            // 
            this.Precio_Final.HeaderText = "Precio_Final";
            this.Precio_Final.MinimumWidth = 6;
            this.Precio_Final.Name = "Precio_Final";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCOMIDA);
            this.panel1.Controls.Add(this.cbtipopago);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNOMBRE);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 230);
            this.panel1.TabIndex = 19;
            // 
            // btnCOMIDA
            // 
            this.btnCOMIDA.Image = ((System.Drawing.Image)(resources.GetObject("btnCOMIDA.Image")));
            this.btnCOMIDA.Location = new System.Drawing.Point(405, 144);
            this.btnCOMIDA.Name = "btnCOMIDA";
            this.btnCOMIDA.Size = new System.Drawing.Size(228, 65);
            this.btnCOMIDA.TabIndex = 30;
            this.btnCOMIDA.Text = "     AÑADIR";
            this.btnCOMIDA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCOMIDA.UseVisualStyleBackColor = true;
            this.btnCOMIDA.Click += new System.EventHandler(this.btnCOMIDA_Click);
            // 
            // cbtipopago
            // 
            this.cbtipopago.FormattingEnabled = true;
            this.cbtipopago.Location = new System.Drawing.Point(37, 164);
            this.cbtipopago.Name = "cbtipopago";
            this.cbtipopago.Size = new System.Drawing.Size(238, 26);
            this.cbtipopago.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "SELECCIONE TIPO DE PAGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "PRECIO.";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(567, 65);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(99, 24);
            this.txtprecio.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "CANTIDAD:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(363, 65);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(99, 24);
            this.txtcantidad.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "NOMBRE DEL PRODUCTO: \r\n";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(37, 65);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(238, 24);
            this.txtNOMBRE.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(155, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(811, 55);
            this.label7.TabIndex = 18;
            this.label7.Text = "CONTROL DE REGISTRO DE COMPRAS ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 678);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "FormCOMPRA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCOMPRA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Final;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCOMIDA;
        private System.Windows.Forms.ComboBox cbtipopago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label7;
    }
}