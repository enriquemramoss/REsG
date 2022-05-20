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
using CNEGOCIO;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MReporteEncargado : Form
    {
        Contacto Con = new Contacto();
        REPORTEENCARGADOS EREG = new REPORTEENCARGADOS();
        public MReporteEncargado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DG.RowCount) >= 1)
            {
                Vista V = new Vista(EREG, 5);
                V.Show();
            }
            else
            {
                Mensaje2 m = new Mensaje2("Favor de seleccionar registros", "Error al geenerar reporte");
                m.ShowDialog();
            }

        }

        private void MReporteEncargado_Load(object sender, EventArgs e)
        {
            Con.MostrarUsuario(CB);
            CB.SelectedIndex = 0;
            LlenarDatos();
            Con.MostrarReporteEncargados(EREG,DG);
        }
        public void LlenarDatos()
        {
            EREG.FechaInicio = dTPFechaInicio.Text;
            EREG.FechaFin = dTPFechaFin.Text;
            EREG.NombreEncargado = CB.SelectedItem.ToString();
        }

        private void dTPFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            LlenarDatos();
            Con.MostrarReporteEncargados(EREG,DG);
        }

        private void dTPFechaFin_ValueChanged(object sender, EventArgs e)
        {
            LlenarDatos();
            Con.MostrarReporteEncargados(EREG, DG);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
