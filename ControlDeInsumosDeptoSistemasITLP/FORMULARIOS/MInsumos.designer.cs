namespace WindowsFormsApp1.FORMULARIOS
{
    partial class MInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MInsumos));
            this.tTipo = new System.Windows.Forms.TextBox();
            this.tModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNACEPTAR = new System.Windows.Forms.Button();
            this.BTNLIMPIAR = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.CBU = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tInformacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tNoSerie = new System.Windows.Forms.TextBox();
            this.pModelo = new System.Windows.Forms.Panel();
            this.pTipo = new System.Windows.Forms.Panel();
            this.pSerie = new System.Windows.Forms.Panel();
            this.pPrecio = new System.Windows.Forms.Panel();
            this.pDescripcion = new System.Windows.Forms.Panel();
            this.pInformacion = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pModelo.SuspendLayout();
            this.pPrecio.SuspendLayout();
            this.pDescripcion.SuspendLayout();
            this.pInformacion.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tTipo
            // 
            this.tTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tTipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTipo.Location = new System.Drawing.Point(180, 149);
            this.tTipo.MaxLength = 30;
            this.tTipo.Multiline = true;
            this.tTipo.Name = "tTipo";
            this.tTipo.Size = new System.Drawing.Size(318, 25);
            this.tTipo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tTipo, "Se ingresa el tipo de insumo:\r\nEjemplo: COMPUTADORA");
            this.tTipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tTipo_MouseClick);
            this.tTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tTipo_KeyPress);
            this.tTipo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tTipo_KeyUp);
            // 
            // tModelo
            // 
            this.tModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tModelo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tModelo.Location = new System.Drawing.Point(2, 2);
            this.tModelo.MaxLength = 20;
            this.tModelo.Multiline = true;
            this.tModelo.Name = "tModelo";
            this.tModelo.Size = new System.Drawing.Size(318, 25);
            this.tModelo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tModelo, "Formato de modelo de insumo ");
            this.tModelo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tModelo_MouseClick);
            this.tModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tModelo_KeyPress);
            this.tModelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tModelo_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ubicación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Información";
            // 
            // BTNACEPTAR
            // 
            this.BTNACEPTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNACEPTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BTNACEPTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BTNACEPTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNACEPTAR.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACEPTAR.ForeColor = System.Drawing.Color.White;
            this.BTNACEPTAR.Location = new System.Drawing.Point(556, 421);
            this.BTNACEPTAR.Name = "BTNACEPTAR";
            this.BTNACEPTAR.Size = new System.Drawing.Size(128, 52);
            this.BTNACEPTAR.TabIndex = 7;
            this.BTNACEPTAR.Text = "REGISTRAR";
            this.toolTip1.SetToolTip(this.BTNACEPTAR, "Registro Insumo");
            this.BTNACEPTAR.UseVisualStyleBackColor = false;
            this.BTNACEPTAR.Click += new System.EventHandler(this.BTNACEPTAR_Click);
            // 
            // BTNLIMPIAR
            // 
            this.BTNLIMPIAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNLIMPIAR.BackColor = System.Drawing.Color.White;
            this.BTNLIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLIMPIAR.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLIMPIAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.BTNLIMPIAR.Location = new System.Drawing.Point(699, 421);
            this.BTNLIMPIAR.Name = "BTNLIMPIAR";
            this.BTNLIMPIAR.Size = new System.Drawing.Size(118, 52);
            this.BTNLIMPIAR.TabIndex = 8;
            this.BTNLIMPIAR.Text = "LIMPIAR";
            this.toolTip1.SetToolTip(this.BTNLIMPIAR, "Limpiar Campos");
            this.BTNLIMPIAR.UseVisualStyleBackColor = false;
            this.BTNLIMPIAR.Click += new System.EventHandler(this.BTNLIMPIAR_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 42);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "REGISTRO INSUMOS";
            this.lblTitulo.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descripción";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDescripcion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(2, 2);
            this.tDescripcion.MaxLength = 100;
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(325, 83);
            this.tDescripcion.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tDescripcion, "Breve descripción del insumo");
            this.tDescripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tDescripcion_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Modelo";
            // 
            // tPrecio
            // 
            this.tPrecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.tPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPrecio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPrecio.Location = new System.Drawing.Point(2, 2);
            this.tPrecio.MaxLength = 10;
            this.tPrecio.Multiline = true;
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(306, 25);
            this.tPrecio.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tPrecio, "Formato númerico entero o\r\n entero con 2 decimales");
            this.tPrecio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tPrecio_MouseClick);
            this.tPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPrecio_KeyPress);
            this.tPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tPrecio_KeyUp);
            // 
            // CBU
            // 
            this.CBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBU.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBU.FormattingEnabled = true;
            this.CBU.Items.AddRange(new object[] {
            "MCA",
            "MCB",
            "MCC",
            "MCD",
            "MCF",
            "MCG"});
            this.CBU.Location = new System.Drawing.Point(175, 208);
            this.CBU.Name = "CBU";
            this.CBU.Size = new System.Drawing.Size(322, 28);
            this.CBU.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "$";
            // 
            // tInformacion
            // 
            this.tInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tInformacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tInformacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tInformacion.Location = new System.Drawing.Point(2, 2);
            this.tInformacion.MaxLength = 200;
            this.tInformacion.Multiline = true;
            this.tInformacion.Name = "tInformacion";
            this.tInformacion.Size = new System.Drawing.Size(325, 109);
            this.tInformacion.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tInformacion, "Información Insumo");
            this.tInformacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tInformacion_MouseClick);
            this.tInformacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tInformacion_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "No. Serie";
            // 
            // tNoSerie
            // 
            this.tNoSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNoSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tNoSerie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNoSerie.Location = new System.Drawing.Point(177, 307);
            this.tNoSerie.MaxLength = 20;
            this.tNoSerie.Multiline = true;
            this.tNoSerie.Name = "tNoSerie";
            this.tNoSerie.Size = new System.Drawing.Size(318, 25);
            this.tNoSerie.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tNoSerie, "Formato de números y letras no mayor\r\na 20 caracteres ");
            this.tNoSerie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tNoSerie_MouseClick);
            this.tNoSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNoSerie_KeyPress);
            this.tNoSerie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tNoSerie_KeyUp);
            // 
            // pModelo
            // 
            this.pModelo.BackColor = System.Drawing.Color.Silver;
            this.pModelo.Controls.Add(this.tModelo);
            this.pModelo.Location = new System.Drawing.Point(175, 100);
            this.pModelo.Name = "pModelo";
            this.pModelo.Size = new System.Drawing.Size(322, 29);
            this.pModelo.TabIndex = 0;
            this.pModelo.TabStop = true;
            // 
            // pTipo
            // 
            this.pTipo.BackColor = System.Drawing.Color.Silver;
            this.pTipo.Location = new System.Drawing.Point(178, 147);
            this.pTipo.Name = "pTipo";
            this.pTipo.Size = new System.Drawing.Size(322, 29);
            this.pTipo.TabIndex = 1;
            this.pTipo.TabStop = true;
            // 
            // pSerie
            // 
            this.pSerie.BackColor = System.Drawing.Color.Silver;
            this.pSerie.Location = new System.Drawing.Point(175, 305);
            this.pSerie.Name = "pSerie";
            this.pSerie.Size = new System.Drawing.Size(322, 29);
            this.pSerie.TabIndex = 4;
            this.pSerie.TabStop = true;
            // 
            // pPrecio
            // 
            this.pPrecio.BackColor = System.Drawing.Color.Silver;
            this.pPrecio.Controls.Add(this.tPrecio);
            this.pPrecio.Location = new System.Drawing.Point(191, 255);
            this.pPrecio.Name = "pPrecio";
            this.pPrecio.Size = new System.Drawing.Size(310, 29);
            this.pPrecio.TabIndex = 3;
            this.pPrecio.TabStop = true;
            // 
            // pDescripcion
            // 
            this.pDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pDescripcion.BackColor = System.Drawing.Color.Silver;
            this.pDescripcion.Controls.Add(this.tDescripcion);
            this.pDescripcion.Location = new System.Drawing.Point(527, 99);
            this.pDescripcion.Name = "pDescripcion";
            this.pDescripcion.Size = new System.Drawing.Size(329, 87);
            this.pDescripcion.TabIndex = 5;
            this.pDescripcion.TabStop = true;
            // 
            // pInformacion
            // 
            this.pInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pInformacion.BackColor = System.Drawing.Color.Silver;
            this.pInformacion.Controls.Add(this.tInformacion);
            this.pInformacion.Location = new System.Drawing.Point(527, 216);
            this.pInformacion.Name = "pInformacion";
            this.pInformacion.Size = new System.Drawing.Size(329, 114);
            this.pInformacion.TabIndex = 6;
            this.pInformacion.TabStop = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.iconMinimizar);
            this.panelHeader.Controls.Add(this.iconrestaurar);
            this.panelHeader.Controls.Add(this.iconmaximizar);
            this.panelHeader.Controls.Add(this.iconCerrar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(889, 25);
            this.panelHeader.TabIndex = 49;
            this.panelHeader.Visible = false;
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimizar.Image")));
            this.iconMinimizar.Location = new System.Drawing.Point(811, 5);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(15, 15);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(837, 5);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(15, 15);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 2;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(837, 5);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(15, 15);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 1;
            this.iconmaximizar.TabStop = false;
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(863, 5);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(15, 15);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 0;
            this.iconCerrar.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(556, 421);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 52);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnCancelar.Location = new System.Drawing.Point(699, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 52);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "CANCELAR";
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 535);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tNoSerie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BTNLIMPIAR);
            this.Controls.Add(this.BTNACEPTAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tTipo);
            this.Controls.Add(this.pModelo);
            this.Controls.Add(this.pTipo);
            this.Controls.Add(this.pPrecio);
            this.Controls.Add(this.pSerie);
            this.Controls.Add(this.pDescripcion);
            this.Controls.Add(this.pInformacion);
            this.Controls.Add(this.btnModificar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAgregarInsumo";
            this.Load += new System.EventHandler(this.MInicio_Load);
            this.pModelo.ResumeLayout(false);
            this.pModelo.PerformLayout();
            this.pPrecio.ResumeLayout(false);
            this.pPrecio.PerformLayout();
            this.pDescripcion.ResumeLayout(false);
            this.pDescripcion.PerformLayout();
            this.pInformacion.ResumeLayout(false);
            this.pInformacion.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tTipo;
        private System.Windows.Forms.TextBox tModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNACEPTAR;
        private System.Windows.Forms.Button BTNLIMPIAR;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.ComboBox CBU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tInformacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tNoSerie;
        private System.Windows.Forms.Panel pModelo;
        private System.Windows.Forms.Panel pTipo;
        private System.Windows.Forms.Panel pSerie;
        private System.Windows.Forms.Panel pPrecio;
        private System.Windows.Forms.Panel pDescripcion;
        private System.Windows.Forms.Panel pInformacion;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}