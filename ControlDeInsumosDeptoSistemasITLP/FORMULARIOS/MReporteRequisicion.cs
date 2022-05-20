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
    public partial class MReporterequisicion : Form
    {
        REPORTE ER = new REPORTE();
        Contacto Con = new Contacto();
        USUARIOACTIVO UA;
        public MReporterequisicion(USUARIOACTIVO UA)
        {
            this.UA = UA;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LlenarDatos();
            Con.TablaRequisicion(ER, DG);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DG.RowCount) >= 1)
            {
                Vista V = new Vista(UA, ER, 3);
                V.ShowDialog();
            }
            else
            {
                Mensaje2 m = new Mensaje2("Favor de seleccionar registros", "Error al geenerar reporte");
                m.ShowDialog();
            }

        }
        public void LlenarDatos()
        {
            ER.FechaI = DTPFechaI.Text;
            ER.FechaFin = DTPFechaFin.Text;
        }

        private void DTPFechaI_ValueChanged(object sender, EventArgs e)
        {
            LlenarDatos();
            Con.TablaRequisicion(ER, DG);
        }

        private void DTPFechaFin_ValueChanged(object sender, EventArgs e)
        {
            LlenarDatos();
            Con.TablaRequisicion(ER, DG);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
