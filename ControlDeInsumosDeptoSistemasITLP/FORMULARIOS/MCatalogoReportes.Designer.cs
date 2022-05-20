namespace WindowsFormsApp1.FORMULARIOS
{
    partial class MCatalogoReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCatalogoReportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlConsultaEspec = new System.Windows.Forms.Panel();
            this.RReporte = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Rencargado = new System.Windows.Forms.RadioButton();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBUSQUEDA = new System.Windows.Forms.TextBox();
            this.btnREIMPRIMIR = new System.Windows.Forms.Button();
            this.DGVI = new System.Windows.Forms.DataGridView();
            this.CBR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dTPFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConsultaEspec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 287;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlConsultaEspec
            // 
            this.pnlConsultaEspec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.pnlConsultaEspec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsultaEspec.Controls.Add(this.RReporte);
            this.pnlConsultaEspec.Controls.Add(this.label4);
            this.pnlConsultaEspec.Controls.Add(this.Rencargado);
            this.pnlConsultaEspec.Controls.Add(this.lblEncargado);
            this.pnlConsultaEspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pnlConsultaEspec.ForeColor = System.Drawing.Color.White;
            this.pnlConsultaEspec.Location = new System.Drawing.Point(45, 73);
            this.pnlConsultaEspec.Name = "pnlConsultaEspec";
            this.pnlConsultaEspec.Size = new System.Drawing.Size(261, 30);
            this.pnlConsultaEspec.TabIndex = 286;
            this.pnlConsultaEspec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConsultaEspec_Paint);
            // 
            // RReporte
            // 
            this.RReporte.AutoSize = true;
            this.RReporte.Checked = true;
            this.RReporte.Location = new System.Drawing.Point(100, 9);
            this.RReporte.Name = "RReporte";
            this.RReporte.Size = new System.Drawing.Size(14, 13);
            this.RReporte.TabIndex = 293;
            this.RReporte.TabStop = true;
            this.RReporte.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 292;
            this.label4.Text = "NO. REPORTE";
            // 
            // Rencargado
            // 
            this.Rencargado.AutoSize = true;
            this.Rencargado.Location = new System.Drawing.Point(229, 8);
            this.Rencargado.Name = "Rencargado";
            this.Rencargado.Size = new System.Drawing.Size(14, 13);
            this.Rencargado.TabIndex = 288;
            this.Rencargado.UseVisualStyleBackColor = true;
            this.Rencargado.CheckedChanged += new System.EventHandler(this.Rencargado_CheckedChanged);
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncargado.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.ForeColor = System.Drawing.Color.White;
            this.lblEncargado.Location = new System.Drawing.Point(143, 5);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(80, 18);
            this.lblEncargado.TabIndex = 92;
            this.lblEncargado.Text = "ENCARGADO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(38, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 42);
            this.label7.TabIndex = 288;
            this.label7.Text = "CATÁLOGO REPORTES";
            // 
            // TBUSQUEDA
            // 
            this.TBUSQUEDA.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUSQUEDA.Location = new System.Drawing.Point(312, 73);
            this.TBUSQUEDA.Multiline = true;
            this.TBUSQUEDA.Name = "TBUSQUEDA";
            this.TBUSQUEDA.Size = new System.Drawing.Size(221, 30);
            this.TBUSQUEDA.TabIndex = 289;
            this.TBUSQUEDA.TextChanged += new System.EventHandler(this.TBUSQUEDA_TextChanged);
            // 
            // btnREIMPRIMIR
            // 
            this.btnREIMPRIMIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnREIMPRIMIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnREIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREIMPRIMIR.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREIMPRIMIR.ForeColor = System.Drawing.Color.Black;
            this.btnREIMPRIMIR.Location = new System.Drawing.Point(639, 128);
            this.btnREIMPRIMIR.Name = "btnREIMPRIMIR";
            this.btnREIMPRIMIR.Size = new System.Drawing.Size(179, 39);
            this.btnREIMPRIMIR.TabIndex = 296;
            this.btnREIMPRIMIR.Text = "REIMPRIMIR REPORTE";
            this.btnREIMPRIMIR.UseVisualStyleBackColor = false;
            this.btnREIMPRIMIR.Click += new System.EventHandler(this.btnREIMPRIMIR_Click);
            // 
            // DGVI
            // 
            this.DGVI.AllowUserToAddRows = false;
            this.DGVI.AllowUserToDeleteRows = false;
            this.DGVI.AllowUserToResizeColumns = false;
            this.DGVI.AllowUserToResizeRows = false;
            this.DGVI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVI.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVI.Location = new System.Drawing.Point(45, 178);
            this.DGVI.MultiSelect = false;
            this.DGVI.Name = "DGVI";
            this.DGVI.ReadOnly = true;
            this.DGVI.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVI.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVI.Size = new System.Drawing.Size(773, 316);
            this.DGVI.TabIndex = 298;
            // 
            // CBR
            // 
            this.CBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBR.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBR.FormattingEnabled = true;
            this.CBR.Items.AddRange(new object[] {
            "REQUISICIÓN",
            "RESGUARDO"});
            this.CBR.Location = new System.Drawing.Point(45, 133);
            this.CBR.Name = "CBR";
            this.CBR.Size = new System.Drawing.Size(212, 27);
            this.CBR.TabIndex = 299;
            this.CBR.SelectedIndexChanged += new System.EventHandler(this.CBACTIVOS_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 300;
            this.label5.Text = "TIPO DE REPORTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 304;
            this.label1.Text = "-";
            // 
            // dTPFechaFin
            // 
            this.dTPFechaFin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFechaFin.Location = new System.Drawing.Point(516, 134);
            this.dTPFechaFin.Name = "dTPFechaFin";
            this.dTPFechaFin.Size = new System.Drawing.Size(94, 26);
            this.dTPFechaFin.TabIndex = 303;
            this.dTPFechaFin.Value = new System.DateTime(2018, 11, 30, 3, 8, 42, 0);
            this.dTPFechaFin.ValueChanged += new System.EventHandler(this.dTPFechaFin_ValueChanged);
            // 
            // dTPFechaInicio
            // 
            this.dTPFechaInicio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFechaInicio.Location = new System.Drawing.Point(390, 134);
            this.dTPFechaInicio.Name = "dTPFechaInicio";
            this.dTPFechaInicio.Size = new System.Drawing.Size(94, 26);
            this.dTPFechaInicio.TabIndex = 302;
            this.dTPFechaInicio.Value = new System.DateTime(2018, 10, 10, 0, 0, 0, 0);
            this.dTPFechaInicio.ValueChanged += new System.EventHandler(this.dTPFechaInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            this.label2.Location = new System.Drawing.Point(283, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 301;
            this.label2.Text = "Entre las fechas\r\nde inicio";
            // 
            // MCatalogoReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPFechaFin);
            this.Controls.Add(this.dTPFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBR);
            this.Controls.Add(this.DGVI);
            this.Controls.Add(this.btnREIMPRIMIR);
            this.Controls.Add(this.TBUSQUEDA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlConsultaEspec);
            this.DoubleBuffered = true;
            this.Name = "MCatalogoReportes";
            this.Text = "MConsultas";
            this.Load += new System.EventHandler(this.MCatalogoReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlConsultaEspec.ResumeLayout(false);
            this.pnlConsultaEspec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlConsultaEspec;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.RadioButton Rencargado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBUSQUEDA;
        private System.Windows.Forms.Button btnREIMPRIMIR;
        private System.Windows.Forms.DataGridView DGVI;
        private System.Windows.Forms.RadioButton RReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPFechaFin;
        private System.Windows.Forms.DateTimePicker dTPFechaInicio;
        private System.Windows.Forms.Label label2;
    }
}