using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CENTIDAD;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MInicio : Form
    {
        public MInicio(USUARIOACTIVO UA)
        {
            InitializeComponent();
            lbUsuario.Text = UA.Nombre;
            Invalidate();
        }

        private void MInicio_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void MInicio_Paint(object sender, PaintEventArgs e)
        {
            // Área cliente del formulario.
            //
            Rectangle r = this.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            int c = r.Width / 2;

            // Establecemos la nueva posición del control Label.
            //
            lbUsuario.Location = new Point(c - lbUsuario.Width / 2, lbUsuario.Location.Y);
        }
    }
}
