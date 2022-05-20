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
    public partial class MReporteResguardo : Form
    {
        Contacto Con = new Contacto();
        INSUMO EI = new INSUMO();
        USUARIO US = new USUARIO();
        REPORTEENCARGADOS EREG = new REPORTEENCARGADOS();
        public MReporteResguardo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(DG2.RowCount) >= 1)
            {
                LlenarDatos();
                Con.DatosUsuarioSelecionado(US);
                LlenarDatos2();
                Con.CrearReporteEncargo(EREG);
                DataTable da = new DataTable();
                da.Columns.Add("Número de Serie", typeof(string));
                da.Columns.Add("Descripción", typeof(string));
                da.Columns.Add("Modelo", typeof(string));
                da.Columns.Add("Precio Unitario", typeof(string));
                for (int i = 0; i < DG2.RowCount; i++)
                {
                    EREG.IDInsumo = Convert.ToInt32(DG2[0, i].Value);
                    Con.InsertarInsumoEncargado(EREG);
                    Con.ModificarEncargado(EREG, US);
                    da.Rows.Add(DG2[1, i].Value, DG2[2, i].Value, DG2[3, i].Value, DG2[4, i].Value);
                }
                EREG.Datatable = da;
                Vista V = new Vista(US, EREG, 4);
                V.Show();
                this.Close();
            }
            else
            {
                Mensaje2 m = new Mensaje2("Favor de seleccionar registros", "Error al geenerar reporte");
                m.ShowDialog();
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    EI.ID = (DG[0, DG.CurrentRow.Index].Value.ToString());
                    DG2.RowCount++;
                    DG2[0, DG2.RowCount - 1].Value = DG[0, Convert.ToInt32(DG.CurrentRow.Index.ToString())].Value;
                    DG2[1, DG2.RowCount - 1].Value = DG[5, Convert.ToInt32(DG.CurrentRow.Index.ToString())].Value;
                    DG2[2, DG2.RowCount - 1].Value = DG[1, Convert.ToInt32(DG.CurrentRow.Index.ToString())].Value;
                    DG2[3, DG2.RowCount - 1].Value = DG[6, Convert.ToInt32(DG.CurrentRow.Index.ToString())].Value;
                    DG2[4, DG2.RowCount - 1].Value = DG[7, Convert.ToInt32(DG.CurrentRow.Index.ToString())].Value;
                    Con.ResguardoTemporal(EI);
                    Con.InsumoSinResguardo(DG);

           
        }

        private void MReporteResguardo_Load(object sender, EventArgs e)
        {
            dTPFechaFin.MinDate = DateTime.Now.Date;
            dTPFechaFin.Value = DateTime.Now.Date;
            dTPFechaFin.Value.AddDays(1);
            Con.MostrarUsuarioActivos(CB);
            Con.InsumoSinResguardo(DG);
            CB.SelectedIndex = 0;
        }
        public void LlenarDatos()
        {
            US.Nombre = CB.SelectedItem.ToString();
            EREG.NombreEncargado = CB.SelectedItem.ToString();
            EREG.FechaInicio=DateTime.Now.ToString("yyyy/MM/dd");
            EREG.FechaFin = string.Format(dTPFechaFin.Text, "yyyy/MM/dd");
        }
        public void LlenarDatos2()
        {
            EREG.NombreEncargado = US.Nombre;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DG2.RowCount > 0)
            {
                EI.ID = (DG2[0, DG2.CurrentRow.Index].Value.ToString());
                DG2.Rows.RemoveAt(DG2.CurrentRow.Index);
                Con.NoResguardoTemporal(EI);
                Con.InsumoSinResguardo(DG);
            }
        }
        public void RegresarEliminados()
        {
            if (DG2.RowCount > 0)
            {
                foreach (var item in DG2.Rows)
                {
                    EI.ID = (DG2[0, DG2.CurrentRow.Index].Value.ToString());
                    DG2.Rows.RemoveAt(DG2.CurrentRow.Index);
                    Con.NoResguardoTemporal(EI);
                    Con.InsumoSinResguardo(DG);
                }
               
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RegresarEliminados();
            this.Close();
        }

        private void MReporteResguardo_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegresarEliminados();
        }
    }
}
