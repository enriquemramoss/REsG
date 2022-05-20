using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNEGOCIO;
using CENTIDAD;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MReporteInsumo : Form
    {
        USUARIOACTIVO UA;
        Contacto Con = new Contacto();
        REPORTE ER = new REPORTE();
        Vista V;
        public MReporteInsumo(USUARIOACTIVO UA)
        {
            this.UA = UA;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtGR.RowCount) >= 1)
            {
                if (CBF.SelectedIndex == 0)
                {
                    V = new Vista(UA, ER, 0);
                    V.ShowDialog();
                }
                else
                if (CBF.SelectedIndex == 1)
                {
                    V = new Vista(UA, ER, 1);
                    V.ShowDialog();
                }
            }
            else
            {
                Mensaje2 m = new Mensaje2("Favor de seleccionar registros", "Error al geenerar reporte");
                m.ShowDialog();
            }
          
        }

        private void MReporteInsumo_Load(object sender, EventArgs e)
        {
            CBF.SelectedIndex = 0;
        }

        private void CBF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBF.SelectedIndex==0)
            {
                CBB.Items.Clear();
                Con.MostrarTipos(CBB);
            }
            if (CBF.SelectedIndex == 1)
            {
                CBB.Items.Clear();
                CBB.Items.Add("MCA");
                CBB.Items.Add("MCB");
                CBB.Items.Add("MCC");
                CBB.Items.Add("MCD");
                CBB.Items.Add("MCF");
                CBB.Items.Add("MCG");
            }
        }

        private void CBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBF.SelectedIndex==0)
            {
                LlenarDatos();
                Con.ReporteTipo(ER, dtGR);
            }
            if (CBF.SelectedIndex == 1)
            {
                LlenarDatos();
                Con.ReporteUbicacion(ER, dtGR);
            }
        }
        public void LlenarDatos()
        {
            ER.FechaI = DFechaI.Text;
            ER.FechaFin = dFechaFin.Text;
            ER.Busqueda = CBB.Text;
        }

        private void DFechaI_ValueChanged(object sender, EventArgs e)
        {
            if (CBF.SelectedIndex == 0)
            {
                LlenarDatos();
                Con.ReporteTipo(ER, dtGR);
            }
            if (CBF.SelectedIndex == 1)
            {
                LlenarDatos();
                Con.ReporteUbicacion(ER, dtGR);
            }
        }

        private void dFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (CBF.SelectedIndex == 0)
            {
                LlenarDatos();
                Con.ReporteTipo(ER, dtGR);
            }
            if (CBF.SelectedIndex == 1)
            {
                LlenarDatos();
                Con.ReporteUbicacion(ER, dtGR);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
