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
    public partial class MCatalogoReportes : Form
    {
        REPORTEENCARGADOS EREG = new REPORTEENCARGADOS();
        REQUISICION EREQ = new REQUISICION();
        Contacto Con = new Contacto();
        USUARIOACTIVO UA;
        USUARIO US = new USUARIO();
        USUARIOMAESTRO UM = new USUARIOMAESTRO();
        public MCatalogoReportes(USUARIOACTIVO UA)
        {
            this.UA = UA;
            InitializeComponent();
        }

        private void pnlConsultaEspec_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Chequeado()
        {
            LimpiarVariable();
            if (RReporte.Checked == true)
            {
                if (CBR.SelectedIndex==0)
                {
                    EREQ.NoDReporte = TBUSQUEDA.Text;
                }
                else
                {
                    EREG.NoDReporte = TBUSQUEDA.Text;
                }
            }
            if (Rencargado.Checked == true)
            {
                if (CBR.SelectedIndex == 0)
                {
                    EREQ.Encargado= TBUSQUEDA.Text;
                }
                else
                {
                    EREG.NombreEncargado = TBUSQUEDA.Text;
                }
            }
            
                if (CBR.SelectedIndex == 0)
                {
                    EREQ.FechaRequisicion = dTPFechaInicio.Text;
                    EREQ.FechaRequisicionFin = dTPFechaFin.Text;
            }
                else
                {
                    EREG.FechaFin = dTPFechaInicio.Text;
                    EREG.FechaFin = dTPFechaFin.Text;
                }
            //Con.Consulta(EI, DGVI);
            Application.DoEvents();
        }
        private void TBUSQUEDA_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Rencargado_CheckedChanged(object sender, EventArgs e)
        {
            TBUSQUEDA.Focus();
        }
        public void LimpiarVariable()
        {
            //EI = new INSUMO();
        }

        private void btn_Eliminar(object sender, EventArgs e)
        {

        }


        private void CBACTIVOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeado();
            //Con.Consulta(EI, DGVI);
            if (CBR.SelectedIndex == 1)
            {
                Con.ConsultarReporteEncargados(EREG, DGVI);
            }
            if (CBR.SelectedIndex == 0)
            {
                Con.ConsultarReporteRequisicion(EREQ, DGVI);
            }
        }

        private void TBUSQUEDA_TextChanged(object sender, EventArgs e)
        {
            //Application.DoEvents();
            Chequeado();
            if (CBR.SelectedIndex == 1)
            {
                Con.ConsultarReporteEncargados(EREG, DGVI);
            }
            if (CBR.SelectedIndex == 0)
            {
                Con.ConsultarReporteRequisicion(EREQ, DGVI);
            }
            if (DGVI.Rows.Count!=0)
            FastAutoSizeColumns(DGVI);
            //Application.DoEvents();
        }
        public void FastAutoSizeColumns(DataGridView targetGrid)
        {
            // Cast out a DataTable from the target grid datasource.
            // We need to iterate through all the data in the grid and a DataTable supports enumeration.
            var gridTable = (DataTable)targetGrid.DataSource;

            // Create a graphics object from the target grid. Used for measuring text size.
            using (var gfx = targetGrid.CreateGraphics())
            {
                // Iterate through the columns.
                for (int i = 0; i < gridTable.Columns.Count; i++)
                {
                    // Leverage Linq enumerator to rapidly collect all the rows into a string array, making sure to exclude null values.
                    string[] colStringCollection = gridTable.AsEnumerable().Where(r => r.Field<object>(i) != null).Select(r => r.Field<object>(i).ToString()).ToArray();

                    // Sort the string array by string lengths.
                    colStringCollection = colStringCollection.OrderBy((x) => x.Length).ToArray();

                    // Get the last and longest string in the array.
                    string longestColString = colStringCollection.Last();

                    // Use the graphics object to measure the string size.
                    var colWidth = gfx.MeasureString(longestColString, targetGrid.Font);

                    // If the calculated width is larger than the column header width, set the new column width.
                    if (colWidth.Width > targetGrid.Columns[i].HeaderCell.Size.Width)
                    {
                        targetGrid.Columns[i].Width = (int)colWidth.Width;
                    }
                    else // Otherwise, set the column width to the header width.
                    {
                        targetGrid.Columns[i].Width = targetGrid.Columns[i].HeaderCell.Size.Width;
                    }
                }
            }
        }

        private void btnREIMPRIMIR_Click(object sender, EventArgs e)
        {
            if (DGVI.RowCount > 0)
            {
                if (CBR.SelectedIndex == 1)
                {
                    EREG.NoReporte=Convert.ToInt32(DGVI[0, DGVI.CurrentRow.Index].Value.ToString());
                    Con.SaberQueUsuarioEsElEncargado(EREG, US);
                    Con.DatosUsuarioTodo(US);
                    Con.ObtenerInsumosdelReportedeEncargo(EREG);
                    Vista V = new Vista(US,EREG,4);
                    V.Show();
                }
                if (CBR.SelectedIndex == 0)
                {
                    EREQ.NoRequisicion = Convert.ToInt32(DGVI[0, DGVI.CurrentRow.Index].Value.ToString());
                    Con.SaberQueUsuarioEsElDeLaRequisicion(EREQ, US);
                    Con.DatosUsuarioTodo(US);
                    Con.ObtenerInsumosdelReportedeRequisicion(EREQ);
                    Vista V = new Vista(UA, EREQ, 2);
                    V.Show();
                }
            }
        }

        private void MCatalogoReportes_Load(object sender, EventArgs e)
        {
            TBUSQUEDA.Focus();
            CBR.SelectedIndex = 0;
            Chequeado();
            if (CBR.SelectedIndex==1)
            {
                Con.ConsultarReporteEncargados(EREG, DGVI);
            }
            if (CBR.SelectedIndex==0)
            {
                Con.ConsultarReporteRequisicion(EREQ, DGVI);
            }
        }

        private void dTPFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            Chequeado();
            if (CBR.SelectedIndex == 1)
            {
                Con.ConsultarReporteEncargados(EREG, DGVI);
            }
            if (CBR.SelectedIndex == 0)
            {
                Con.ConsultarReporteRequisicion(EREQ, DGVI);
            }
        }

        private void dTPFechaFin_ValueChanged(object sender, EventArgs e)
        {
            Chequeado();
            if (CBR.SelectedIndex == 1)
            {
                Con.ConsultarReporteEncargados(EREG, DGVI);
            }
            if (CBR.SelectedIndex == 0)
            {
                Con.ConsultarReporteRequisicion(EREQ, DGVI);
            }
        }
    }
}

