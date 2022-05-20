namespace WindowsFormsApp1.FORMULARIOS
{
    partial class MInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MInicio));
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbBien = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbHora.Location = new System.Drawing.Point(546, 366);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(77, 45);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "Hora";
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbFecha.Location = new System.Drawing.Point(20, 366);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(92, 45);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha";
            // 
            // lbBien
            // 
            this.lbBien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbBien.AutoSize = true;
            this.lbBien.BackColor = System.Drawing.Color.Transparent;
            this.lbBien.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbBien.Location = new System.Drawing.Point(179, 9);
            this.lbBien.Name = "lbBien";
            this.lbBien.Size = new System.Drawing.Size(458, 77);
            this.lbBien.TabIndex = 2;
            this.lbBien.Text = "BIENVENIDO USUARIO";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lbUsuario.Location = new System.Drawing.Point(267, 86);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(340, 58);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "Armando Yuen Coria";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUsuario.Click += new System.EventHandler(this.lbUsuario_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 485);
            this.Controls.Add(this.lbBien);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbHora);
            this.DoubleBuffered = true;
            this.Name = "MInicio";
            this.Text = "MInicio";
            this.Load += new System.EventHandler(this.MInicio_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MInicio_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbBien;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Timer timer1;
    }
}