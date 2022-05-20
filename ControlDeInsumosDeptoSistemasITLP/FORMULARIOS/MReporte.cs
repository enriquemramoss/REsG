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
    public partial class MReporte : Form
    {
        USUARIOACTIVO UA;
        public MReporte(USUARIOACTIVO UA)
        {
            this.UA = UA;
            InitializeComponent();
            if (UA.Privilegio[2] == 0)
                btnRequisicion.Enabled = false;
            if (UA.Privilegio[3] == 0)
                btnRequisiciones.Enabled = false;
            if (UA.Privilegio[4] == 0)
                btnResguardo.Enabled = false;
            if (UA.Privilegio[5] == 0)
                btnInsumos.Enabled = false;
            if (UA.Privilegio[6] == 0)
                btnEncargos.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MReporte_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PResguardo_Click(object sender, EventArgs e)
        {
            try
            {
                MReporteResguardo MR = new MReporteResguardo();
                MR.ShowDialog();
            }
            catch(Exception M)
            {
                Mensaje2 lñ = new Mensaje2("No hay insumos por agregar","Error al agregar");
            }
        }

        private void PInsumos_Click(object sender, EventArgs e)
        {
            MReporteInsumo MR = new MReporteInsumo(UA);
            MR.ShowDialog();
        }

        private void PRequsicion_Click(object sender, EventArgs e)
        {
            MRequisicion MR = new MRequisicion(UA);
            MR.ShowDialog();
        }

        private void PInsumo_Click(object sender, EventArgs e)
        {
            MReporterequisicion MR = new MReporterequisicion(UA);
            MR.ShowDialog();
        }

        private void PENCARGOS_Click(object sender, EventArgs e)
        {
            MReporteEncargado MR = new MReporteEncargado();
            MR.ShowDialog();
        }
    }
}
