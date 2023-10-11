namespace Restaurat_soft
{
    partial class FormEMPLEADOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEMPLEADOS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.softRESTAURANTDataSet = new Restaurat_soft.SoftRESTAURANTDataSet();
            this.empleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOSDataSet1 = new Restaurat_soft.EMPLEADOSDataSet1();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.eMPLEADOSDataSet = new Restaurat_soft.EMPLEADOSDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Restaurat_soft.EMPLEADOSDataSetTableAdapters.empleadosTableAdapter();
            this.empleadosTableAdapter1 = new Restaurat_soft.EMPLEADOSDataSet1TableAdapters.empleadosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empleadosTableAdapter2 = new Restaurat_soft.SoftRESTAURANTDataSetTableAdapters.empleadosTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softRESTAURANTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDOSDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.sALARIODataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadosBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(861, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBREDataGridViewTextBoxColumn.Width = 125;
            // 
            // aPELLIDOSDataGridViewTextBoxColumn
            // 
            this.aPELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPELLIDOSDataGridViewTextBoxColumn.Name = "aPELLIDOSDataGridViewTextBoxColumn";
            this.aPELLIDOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPELLIDOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEFONODataGridViewTextBoxColumn.Width = 125;
            // 
            // sALARIODataGridViewTextBoxColumn
            // 
            this.sALARIODataGridViewTextBoxColumn.DataPropertyName = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.HeaderText = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sALARIODataGridViewTextBoxColumn.Name = "sALARIODataGridViewTextBoxColumn";
            this.sALARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.sALARIODataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // empleadosBindingSource2
            // 
            this.empleadosBindingSource2.DataMember = "empleados";
            this.empleadosBindingSource2.DataSource = this.softRESTAURANTDataSet;
            // 
            // softRESTAURANTDataSet
            // 
            this.softRESTAURANTDataSet.DataSetName = "SoftRESTAURANTDataSet";
            this.softRESTAURANTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource1
            // 
            this.empleadosBindingSource1.DataMember = "empleados";
            this.empleadosBindingSource1.DataSource = this.eMPLEADOSDataSet1;
            // 
            // eMPLEADOSDataSet1
            // 
            this.eMPLEADOSDataSet1.DataSetName = "EMPLEADOSDataSet1";
            this.eMPLEADOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(744, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "REGISTRAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // eMPLEADOSDataSet
            // 
            this.eMPLEADOSDataSet.DataSetName = "EMPLEADOSDataSet";
            this.eMPLEADOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.eMPLEADOSDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter1
            // 
            this.empleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // empleadosTableAdapter2
            // 
            this.empleadosTableAdapter2.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(395, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(468, 107);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMPLEADOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 404);
            this.panel1.TabIndex = 10;
            // 
            // FormEMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADOS";
            this.Load += new System.EventHandler(this.FormEMPLEADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softRESTAURANTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private EMPLEADOSDataSet eMPLEADOSDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private EMPLEADOSDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private EMPLEADOSDataSet1 eMPLEADOSDataSet1;
        private System.Windows.Forms.BindingSource empleadosBindingSource1;
        private EMPLEADOSDataSet1TableAdapters.empleadosTableAdapter empleadosTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SoftRESTAURANTDataSet softRESTAURANTDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource2;
        private SoftRESTAURANTDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}