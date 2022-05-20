namespace WindowsFormsApp1.FORMULARIOS
{
    partial class MUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlConsultaEspec = new System.Windows.Forms.Panel();
            this.RPuesto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RNombre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Rencargado = new System.Windows.Forms.RadioButton();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBUSQUEDA = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.DGVI = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConsultaEspec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(643, 114);
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
            this.pnlConsultaEspec.Controls.Add(this.RPuesto);
            this.pnlConsultaEspec.Controls.Add(this.label2);
            this.pnlConsultaEspec.Controls.Add(this.RNombre);
            this.pnlConsultaEspec.Controls.Add(this.label1);
            this.pnlConsultaEspec.Controls.Add(this.Rencargado);
            this.pnlConsultaEspec.Controls.Add(this.lblEncargado);
            this.pnlConsultaEspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pnlConsultaEspec.ForeColor = System.Drawing.Color.White;
            this.pnlConsultaEspec.Location = new System.Drawing.Point(37, 114);
            this.pnlConsultaEspec.Name = "pnlConsultaEspec";
            this.pnlConsultaEspec.Size = new System.Drawing.Size(501, 30);
            this.pnlConsultaEspec.TabIndex = 286;
            this.pnlConsultaEspec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConsultaEspec_Paint);
            // 
            // RPuesto
            // 
            this.RPuesto.AutoSize = true;
            this.RPuesto.Checked = true;
            this.RPuesto.Location = new System.Drawing.Point(426, 9);
            this.RPuesto.Name = "RPuesto";
            this.RPuesto.Size = new System.Drawing.Size(14, 13);
            this.RPuesto.TabIndex = 292;
            this.RPuesto.TabStop = true;
            this.RPuesto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 291;
            this.label2.Text = "PUESTO";
            // 
            // RNombre
            // 
            this.RNombre.AutoSize = true;
            this.RNombre.Checked = true;
            this.RNombre.Location = new System.Drawing.Point(281, 9);
            this.RNombre.Name = "RNombre";
            this.RNombre.Size = new System.Drawing.Size(14, 13);
            this.RNombre.TabIndex = 290;
            this.RNombre.TabStop = true;
            this.RNombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 289;
            this.label1.Text = "NOMBRE";
            // 
            // Rencargado
            // 
            this.Rencargado.AutoSize = true;
            this.Rencargado.Checked = true;
            this.Rencargado.Location = new System.Drawing.Point(128, 9);
            this.Rencargado.Name = "Rencargado";
            this.Rencargado.Size = new System.Drawing.Size(14, 13);
            this.Rencargado.TabIndex = 288;
            this.Rencargado.TabStop = true;
            this.Rencargado.UseVisualStyleBackColor = true;
            this.Rencargado.CheckedChanged += new System.EventHandler(this.Rencargado_CheckedChanged);
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncargado.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.ForeColor = System.Drawing.Color.White;
            this.lblEncargado.Location = new System.Drawing.Point(7, 6);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(99, 18);
            this.lblEncargado.TabIndex = 92;
            this.lblEncargado.Text = "NO. ECONOMICO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(30, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 42);
            this.label7.TabIndex = 288;
            this.label7.Text = "MANEJO DE USUARIOS";
            // 
            // TBUSQUEDA
            // 
            this.TBUSQUEDA.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUSQUEDA.Location = new System.Drawing.Point(544, 114);
            this.TBUSQUEDA.Multiline = true;
            this.TBUSQUEDA.Name = "TBUSQUEDA";
            this.TBUSQUEDA.Size = new System.Drawing.Size(93, 30);
            this.TBUSQUEDA.TabIndex = 289;
            this.TBUSQUEDA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBUSQUEDA_KeyUp);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(720, 276);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 39);
            this.btnEliminar.TabIndex = 296;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btn_Eliminar);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(133)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(720, 218);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 39);
            this.btnModificar.TabIndex = 297;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btn_Modificar);
            // 
            // DGVI
            // 
            this.DGVI.AllowUserToAddRows = false;
            this.DGVI.AllowUserToDeleteRows = false;
            this.DGVI.AllowUserToResizeColumns = false;
            this.DGVI.AllowUserToResizeRows = false;
            this.DGVI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.DGVI.Location = new System.Drawing.Point(37, 150);
            this.DGVI.MultiSelect = false;
            this.DGVI.Name = "DGVI";
            this.DGVI.ReadOnly = true;
            this.DGVI.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVI.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVI.Size = new System.Drawing.Size(644, 344);
            this.DGVI.TabIndex = 298;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(720, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 299;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVI);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.TBUSQUEDA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlConsultaEspec);
            this.DoubleBuffered = true;
            this.Name = "MUsuarios";
            this.Text = "MConsultas";
            this.Load += new System.EventHandler(this.MConsultas_Load);
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView DGVI;
        private System.Windows.Forms.RadioButton RPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}