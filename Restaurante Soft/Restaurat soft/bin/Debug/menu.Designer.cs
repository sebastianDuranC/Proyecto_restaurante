﻿namespace Restaurat_soft
{
    partial class MENÚ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENÚ));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuDIA = new System.Windows.Forms.Panel();
            this.addItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPOSTRE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBEBIDA = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCOMIDA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOPCION = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPRECIO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnREMOVER = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softRESTAURANTDataSet2 = new Restaurat_soft.SoftRESTAURANTDataSet2();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPRODUCTO = new System.Windows.Forms.FlowLayoutPanel();
            this.pedidosTableAdapter = new Restaurat_soft.SoftRESTAURANTDataSet2TableAdapters.pedidosTableAdapter();
            this.empleadosDataSet1 = new Restaurat_soft.EMPLEADOSDataSet();
            this.pedidosTableAdapter1 = new Restaurat_soft.SoftRESTAURANTDataSet2TableAdapters.pedidosTableAdapter();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuDIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softRESTAURANTDataSet2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "15:10:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "29/5/2023";
            // 
            // MenuDIA
            // 
            this.MenuDIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuDIA.Controls.Add(this.addItem);
            this.MenuDIA.Controls.Add(this.label5);
            this.MenuDIA.Controls.Add(this.button8);
            this.MenuDIA.Controls.Add(this.button4);
            this.MenuDIA.Controls.Add(this.btnPOSTRE);
            this.MenuDIA.Controls.Add(this.groupBox1);
            this.MenuDIA.Controls.Add(this.btnBEBIDA);
            this.MenuDIA.Controls.Add(this.pictureBox2);
            this.MenuDIA.Controls.Add(this.btnCOMIDA);
            this.MenuDIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuDIA.Location = new System.Drawing.Point(0, 0);
            this.MenuDIA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuDIA.Name = "MenuDIA";
            this.MenuDIA.Size = new System.Drawing.Size(175, 609);
            this.MenuDIA.TabIndex = 4;
            // 
            // addItem
            // 
            this.addItem.Image = ((System.Drawing.Image)(resources.GetObject("addItem.Image")));
            this.addItem.Location = new System.Drawing.Point(0, 509);
            this.addItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(175, 63);
            this.addItem.TabIndex = 9;
            this.addItem.Text = "     EXTRA";
            this.addItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 772);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "By: Fabio Zambrana";
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(-2, 685);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 63);
            this.button8.TabIndex = 4;
            this.button8.Text = "     ATRAS\r\n";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(-2, 115);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "     TODOS";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPOSTRE
            // 
            this.btnPOSTRE.Image = ((System.Drawing.Image)(resources.GetObject("btnPOSTRE.Image")));
            this.btnPOSTRE.Location = new System.Drawing.Point(-2, 365);
            this.btnPOSTRE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPOSTRE.Name = "btnPOSTRE";
            this.btnPOSTRE.Size = new System.Drawing.Size(177, 63);
            this.btnPOSTRE.TabIndex = 2;
            this.btnPOSTRE.Text = "     POSTRE";
            this.btnPOSTRE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOSTRE.UseVisualStyleBackColor = true;
            this.btnPOSTRE.Click += new System.EventHandler(this.btnPOSTRE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(175, 8);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBEBIDA
            // 
            this.btnBEBIDA.Image = ((System.Drawing.Image)(resources.GetObject("btnBEBIDA.Image")));
            this.btnBEBIDA.Location = new System.Drawing.Point(-2, 282);
            this.btnBEBIDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBEBIDA.Name = "btnBEBIDA";
            this.btnBEBIDA.Size = new System.Drawing.Size(177, 67);
            this.btnBEBIDA.TabIndex = 1;
            this.btnBEBIDA.Text = "     BEBIDA";
            this.btnBEBIDA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBEBIDA.UseVisualStyleBackColor = true;
            this.btnBEBIDA.Click += new System.EventHandler(this.btnBEBIDA_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnCOMIDA
            // 
            this.btnCOMIDA.Image = ((System.Drawing.Image)(resources.GetObject("btnCOMIDA.Image")));
            this.btnCOMIDA.Location = new System.Drawing.Point(-4, 200);
            this.btnCOMIDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCOMIDA.Name = "btnCOMIDA";
            this.btnCOMIDA.Size = new System.Drawing.Size(177, 67);
            this.btnCOMIDA.TabIndex = 0;
            this.btnCOMIDA.Text = "    COMIDA";
            this.btnCOMIDA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCOMIDA.UseVisualStyleBackColor = true;
            this.btnCOMIDA.Click += new System.EventHandler(this.btnCOMIDA_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBuscar);
            this.panel1.Controls.Add(this.lblOPCION);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(175, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 81);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBuscar.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscar.DefaultText = "";
            this.textBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBuscar.ForeColor = System.Drawing.Color.Black;
            this.textBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBuscar.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBuscar.IconLeft")));
            this.textBuscar.Location = new System.Drawing.Point(0, 47);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.PasswordChar = '\0';
            this.textBuscar.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBuscar.PlaceholderText = "Buscar";
            this.textBuscar.SelectedText = "";
            this.textBuscar.Size = new System.Drawing.Size(314, 33);
            this.textBuscar.TabIndex = 6;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // lblOPCION
            // 
            this.lblOPCION.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOPCION.AutoSize = true;
            this.lblOPCION.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPCION.Location = new System.Drawing.Point(244, 21);
            this.lblOPCION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOPCION.Name = "lblOPCION";
            this.lblOPCION.Size = new System.Drawing.Size(106, 34);
            this.lblOPCION.TabIndex = 5;
            this.lblOPCION.Text = "MENÚ";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(1179, 19);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(55, 51);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblPRECIO);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnREMOVER);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(175, 532);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 77);
            this.panel3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1172, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "  Bs.";
            // 
            // lblPRECIO
            // 
            this.lblPRECIO.AutoSize = true;
            this.lblPRECIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRECIO.Location = new System.Drawing.Point(1070, 15);
            this.lblPRECIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPRECIO.Name = "lblPRECIO";
            this.lblPRECIO.Size = new System.Drawing.Size(0, 31);
            this.lblPRECIO.TabIndex = 7;
            this.lblPRECIO.Click += new System.EventHandler(this.lblPRECIO_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(952, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "TOTAL: ";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(667, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "     COMPLETAR  COMPRA";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnREMOVER
            // 
            this.btnREMOVER.BackColor = System.Drawing.Color.Firebrick;
            this.btnREMOVER.ForeColor = System.Drawing.Color.White;
            this.btnREMOVER.Image = ((System.Drawing.Image)(resources.GetObject("btnREMOVER.Image")));
            this.btnREMOVER.Location = new System.Drawing.Point(288, 3);
            this.btnREMOVER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnREMOVER.Name = "btnREMOVER";
            this.btnREMOVER.Size = new System.Drawing.Size(120, 52);
            this.btnREMOVER.TabIndex = 3;
            this.btnREMOVER.Text = "       REMOVER";
            this.btnREMOVER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnREMOVER.UseVisualStyleBackColor = false;
            this.btnREMOVER.Click += new System.EventHandler(this.btnREMOVER_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Controls.Add(this.grid1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(571, 81);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 451);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid1.BackgroundColor = System.Drawing.Color.White;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.QTY,
            this.PRECIO,
            this.TOTAL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid1.EnableHeadersVisualStyles = false;
            this.grid1.Location = new System.Drawing.Point(2, 2);
            this.grid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid1.RowHeadersVisible = false;
            this.grid1.RowHeadersWidth = 51;
            this.grid1.RowTemplate.Height = 24;
            this.grid1.Size = new System.Drawing.Size(454, 644);
            this.grid1.TabIndex = 0;
            this.grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            this.grid1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grid_CellPainting);
            // 
            // NOMBRE
            // 
            this.NOMBRE.FillWeight = 101.0101F;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.FillWeight = 49.81732F;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.FillWeight = 112.438F;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.FillWeight = 136.7346F;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "pedidos";
            this.pedidosBindingSource.DataSource = this.softRESTAURANTDataSet2;
            // 
            // softRESTAURANTDataSet2
            // 
            this.softRESTAURANTDataSet2.DataSetName = "SoftRESTAURANTDataSet2";
            this.softRESTAURANTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel2.Controls.Add(this.panelPRODUCTO);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(175, 81);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1268, 641);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // panelPRODUCTO
            // 
            this.panelPRODUCTO.BackColor = System.Drawing.Color.Silver;
            this.panelPRODUCTO.Location = new System.Drawing.Point(2, 2);
            this.panelPRODUCTO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPRODUCTO.Name = "panelPRODUCTO";
            this.panelPRODUCTO.Size = new System.Drawing.Size(912, 641);
            this.panelPRODUCTO.TabIndex = 0;
            this.panelPRODUCTO.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPRODUCTO_Paint);
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosDataSet1
            // 
            this.empleadosDataSet1.DataSetName = "EMPLEADOSDataSet";
            this.empleadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosTableAdapter1
            // 
            this.pedidosTableAdapter1.ClearBeforeFill = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MENÚ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuDIA);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MENÚ";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MENÚ_Load);
            this.Shown += new System.EventHandler(this.MENÚ_Shown);
            this.MenuDIA.ResumeLayout(false);
            this.MenuDIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softRESTAURANTDataSet2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MenuDIA;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPOSTRE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBEBIDA;
        private System.Windows.Forms.Button btnCOMIDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private SoftRESTAURANTDataSet2 softRESTAURANTDataSet2;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private SoftRESTAURANTDataSet2TableAdapters.pedidosTableAdapter pedidosTableAdapter;
        private EMPLEADOSDataSet empleadosDataSet1;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Button button8;
        private Guna.UI.WinForms.GunaLabel lblOPCION;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnREMOVER;
        private System.Windows.Forms.FlowLayoutPanel panelPRODUCTO;
        private SoftRESTAURANTDataSet2TableAdapters.pedidosTableAdapter pedidosTableAdapter1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2TextBox textBuscar;
        public System.Windows.Forms.Label lblPRECIO;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addItem;
        public System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}