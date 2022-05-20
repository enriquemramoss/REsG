namespace WindowsFormsApp1.FORMULARIOS
{
    partial class MRespayResta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRespayResta));
            this.label7 = new System.Windows.Forms.Label();
            this.tRuta = new System.Windows.Forms.TextBox();
            this.btnElegirDestino = new System.Windows.Forms.Button();
            this.btnRealizarRespaldo = new System.Windows.Forms.Button();
            this.btnRestauracion = new System.Windows.Forms.Button();
            this.btnElegirRestauración = new System.Windows.Forms.Button();
            this.tOrigen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(30, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 42);
            this.label7.TabIndex = 288;
            this.label7.Text = "RESPALDO Y RESTAURACIÓN";
            // 
            // tRuta
            // 
            this.tRuta.Enabled = false;
            this.tRuta.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRuta.Location = new System.Drawing.Point(157, 111);
            this.tRuta.Multiline = true;
            this.tRuta.Name = "tRuta";
            this.tRuta.ReadOnly = true;
            this.tRuta.Size = new System.Drawing.Size(547, 30);
            this.tRuta.TabIndex = 292;
            // 
            // btnElegirDestino
            // 
            this.btnElegirDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElegirDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnElegirDestino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnElegirDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirDestino.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirDestino.ForeColor = System.Drawing.Color.White;
            this.btnElegirDestino.Location = new System.Drawing.Point(159, 192);
            this.btnElegirDestino.Name = "btnElegirDestino";
            this.btnElegirDestino.Size = new System.Drawing.Size(194, 69);
            this.btnElegirDestino.TabIndex = 293;
            this.btnElegirDestino.Text = "ELEGIR CARPETA DESTINO";
            this.btnElegirDestino.UseVisualStyleBackColor = false;
            this.btnElegirDestino.Click += new System.EventHandler(this.btnElegirDestino_Click);
            // 
            // btnRealizarRespaldo
            // 
            this.btnRealizarRespaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRealizarRespaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRealizarRespaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRealizarRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarRespaldo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarRespaldo.ForeColor = System.Drawing.Color.White;
            this.btnRealizarRespaldo.Location = new System.Drawing.Point(510, 192);
            this.btnRealizarRespaldo.Name = "btnRealizarRespaldo";
            this.btnRealizarRespaldo.Size = new System.Drawing.Size(194, 69);
            this.btnRealizarRespaldo.TabIndex = 294;
            this.btnRealizarRespaldo.Text = "REALIZAR RESPALDO";
            this.btnRealizarRespaldo.UseVisualStyleBackColor = false;
            this.btnRealizarRespaldo.Click += new System.EventHandler(this.btnRealizarRespaldo_Click);
            // 
            // btnRestauracion
            // 
            this.btnRestauracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestauracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRestauracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnRestauracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestauracion.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestauracion.ForeColor = System.Drawing.Color.White;
            this.btnRestauracion.Location = new System.Drawing.Point(510, 381);
            this.btnRestauracion.Name = "btnRestauracion";
            this.btnRestauracion.Size = new System.Drawing.Size(194, 69);
            this.btnRestauracion.TabIndex = 297;
            this.btnRestauracion.Text = "REALIZAR RESTAURACIÓN";
            this.btnRestauracion.UseVisualStyleBackColor = false;
            this.btnRestauracion.Click += new System.EventHandler(this.btnRestauracion_Click);
            // 
            // btnElegirRestauración
            // 
            this.btnElegirRestauración.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElegirRestauración.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnElegirRestauración.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnElegirRestauración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirRestauración.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirRestauración.ForeColor = System.Drawing.Color.White;
            this.btnElegirRestauración.Location = new System.Drawing.Point(159, 381);
            this.btnElegirRestauración.Name = "btnElegirRestauración";
            this.btnElegirRestauración.Size = new System.Drawing.Size(194, 69);
            this.btnElegirRestauración.TabIndex = 296;
            this.btnElegirRestauración.Text = "ELEGIR ARCHIVO DE RESTAURACIÓN";
            this.btnElegirRestauración.UseVisualStyleBackColor = false;
            this.btnElegirRestauración.Click += new System.EventHandler(this.btnElegirRestauración_Click);
            // 
            // tOrigen
            // 
            this.tOrigen.Enabled = false;
            this.tOrigen.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOrigen.Location = new System.Drawing.Point(157, 294);
            this.tOrigen.Multiline = true;
            this.tOrigen.Name = "tOrigen";
            this.tOrigen.ReadOnly = true;
            this.tOrigen.Size = new System.Drawing.Size(547, 30);
            this.tOrigen.TabIndex = 295;
            // 
            // MRespayResta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 571);
            this.Controls.Add(this.btnRestauracion);
            this.Controls.Add(this.btnElegirRestauración);
            this.Controls.Add(this.tOrigen);
            this.Controls.Add(this.btnRealizarRespaldo);
            this.Controls.Add(this.btnElegirDestino);
            this.Controls.Add(this.tRuta);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.Name = "MRespayResta";
            this.Text = "MConsultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tRuta;
        private System.Windows.Forms.Button btnElegirDestino;
        private System.Windows.Forms.Button btnRealizarRespaldo;
        private System.Windows.Forms.Button btnRestauracion;
        private System.Windows.Forms.Button btnElegirRestauración;
        private System.Windows.Forms.TextBox tOrigen;
    }
}