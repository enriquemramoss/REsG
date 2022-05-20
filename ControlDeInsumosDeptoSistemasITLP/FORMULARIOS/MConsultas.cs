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
    public partial class MConsultas : Form
    {
        INSUMO EI = new INSUMO();
        Contacto Con = new Contacto();
        USUARIOACTIVO UA;
        public MConsultas(USUARIOACTIVO UA)
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
            EI.Activo = CBACTIVOS.SelectedIndex;
            if (Rencargado.Checked == true)
                EI.Encargado = TBUSQUEDA.Text;
            if (RUbicacion.Checked == true)
                EI.Ubicación = TBUSQUEDA.Text;
            if (RTipo.Checked == true)
                EI.Tipo = TBUSQUEDA.Text;
            if (RDescripcion.Checked == true)
                EI.Descripcion = TBUSQUEDA.Text;
            if (RModelo.Checked == true)
                EI.Modelo = TBUSQUEDA.Text;
            if (RNoSerie.Checked == true)
                EI.NoSerie = TBUSQUEDA.Text;
            if (RInformacion.Checked == true)
                EI.Informacion = TBUSQUEDA.Text;
            if (RID.Checked == true)
                EI.ID = TBUSQUEDA.Text;
            Con.Consulta(EI, DGVI);
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
            EI = new INSUMO();
        }

        private void MConsultas_Load(object sender, EventArgs e)
        {
            if (UA.Privilegio[8]==0)
                btnModificar.Visible = false;
            if (UA.Privilegio[9] == 0)
                btnEliminar.Visible = false;
            CBACTIVOS.SelectedIndex = 2;
            Con.Consulta(EI, DGVI);
            TBUSQUEDA.Focus();
        }

        private void btn_Eliminar(object sender, EventArgs e)
        {
            if (DGVI.RowCount > 0)
            {
                String ayuda = btnEliminar.Text.ToLower();
                if (DGVI[9, DGVI.CurrentRow.Index].Value.ToString() == "Eliminado")
                    ayuda = "Reactivar";
                if (DGVI[9, DGVI.CurrentRow.Index].Value.ToString() == "Activo")
                    ayuda = "Eliminar";
                Mensaje M = new Mensaje("Seguro que desea " +ayuda+" el insumo selecionado",ayuda+" Insumo");
                if (M.ShowDialog() == DialogResult.OK)
                {
                    EI.ID = (DGVI[0, DGVI.CurrentRow.Index].Value.ToString());
                    if (DGVI[9, DGVI.CurrentRow.Index].Value.ToString() == "Eliminado")
                        EI.Activo =1;
                    if (DGVI[9, DGVI.CurrentRow.Index].Value.ToString() == "Activo")
                        EI.Activo = 0;
                    //DGVI.Rows.RemoveAt(DGVI.CurrentRow.Index);
                    Con.EliminarInsumo(EI);
                    Chequeado();
                    Con.Consulta(EI, DGVI);
                }

            }
        }

        private void btn_Modificar(object sender, EventArgs e)
        {
            if (DGVI.RowCount > 0)
            {
                EI.ID = (DGVI[0, DGVI.CurrentRow.Index].Value.ToString());
                Con.DatosInsumo(EI);
                MInsumos MI = new MInsumos(UA, EI, true);
                MI.ShowDialog();
                EI = new INSUMO();
                Con.Consulta(EI, DGVI);
                TBUSQUEDA.Text = "";
                TBUSQUEDA.Focus();
            }
        }

        private void CBACTIVOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBACTIVOS.SelectedIndex == 2)
            {
                btnEliminar.Text = "ELIMINAR/REACTIVAR";
            }
            if (CBACTIVOS.SelectedIndex == 1)
            {
                btnEliminar.Text = "  ELIMINAR";
            }
            if (CBACTIVOS.SelectedIndex == 0)
            {
                btnEliminar.Text = " REACTIVAR";
            }
            Chequeado();
            Con.Consulta(EI, DGVI);

        }

        private void TBUSQUEDA_TextChanged(object sender, EventArgs e)
        {
            //Application.DoEvents();
            Chequeado();
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
    }
}

