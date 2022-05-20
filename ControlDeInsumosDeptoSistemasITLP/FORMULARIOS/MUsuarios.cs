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
    public partial class MUsuarios : Form
    {
        Contacto Con = new Contacto();
        USUARIOACTIVO UA;
        USUARIO US = new USUARIO();
        public MUsuarios(USUARIOACTIVO UA)
        {
            this.UA = UA;
            InitializeComponent();
        }

        private void pnlConsultaEspec_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Chekear()
        {
            if (Rencargado.Checked == true)
            {
                LimpiarVariable();
                US.NoEconomico = TBUSQUEDA.Text;
                Con.MostrarUsuariosRegistrados(US, DGVI);
            }
            if (RNombre.Checked == true)
            {
                LimpiarVariable();
                US.Nombre = TBUSQUEDA.Text;
                Con.MostrarUsuariosRegistrados(US, DGVI);
            }
            if (RPuesto.Checked == true)
            {
                LimpiarVariable();
                US.Puesto = TBUSQUEDA.Text;
                Con.MostrarUsuariosRegistrados(US, DGVI);
            }

        }
        private void TBUSQUEDA_KeyUp(object sender, KeyEventArgs e)
        {
            Chekear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Rencargado_CheckedChanged(object sender, EventArgs e)
        {
        }
        public void LimpiarVariable()
        {
            US = new USUARIO();
        }

        private void MConsultas_Load(object sender, EventArgs e)
        {
            Con.MostrarUsuariosRegistrados(US, DGVI);
        }


        private void btn_Eliminar(object sender, EventArgs e)
        {
            if (DGVI.RowCount > 0)
            {
                String ayuda = btnEliminar.Text.ToLower();
                if (DGVI[6, DGVI.CurrentRow.Index].Value.ToString() == "ELIMINADO")
                    ayuda = "Reactivar";
                if (DGVI[6, DGVI.CurrentRow.Index].Value.ToString() == "ACTIVO")
                    ayuda = "Eliminar";
                if ((DGVI[5, DGVI.CurrentRow.Index].Value.ToString()) == "MASTER")
                {
                    Mensaje2 M = new Mensaje2("El usuario maestro no puede ser eliminado", "Error de eliminación");
                    if (M.ShowDialog() == DialogResult.OK) { }
                }
                else
                {
                    Mensaje M = new Mensaje("Seguro que desea " +ayuda+ " el usuario", "Eliminar Usuario");
                    if (M.ShowDialog() == DialogResult.OK)
                    {
                        US.NoEconomico = (DGVI[0, DGVI.CurrentRow.Index].Value.ToString());
                        if (DGVI[6, DGVI.CurrentRow.Index].Value.ToString() == "ELIMINADO")
                            US.Activo = 1;
                        if (DGVI[6, DGVI.CurrentRow.Index].Value.ToString() == "ACTIVO")
                            US.Activo = 0;
                        Con.EliminarUsuario(US);
                        Chekear();
                        
                    }
                }
            }
        }

        private void btn_Modificar(object sender, EventArgs e)
        {
            if (DGVI.RowCount > 0)
            {
                if ((DGVI[5, DGVI.CurrentRow.Index].Value.ToString()) == "MASTER" && UA.Maestro == 0)
                {
                    Mensaje2 M = new Mensaje2("Usted no puede modificar el usuario Maestro", "Error en modificar");
                    if (M.ShowDialog() == DialogResult.OK) { }
                }
                else
                {
                    US.NoEconomico = (DGVI[0, DGVI.CurrentRow.Index].Value.ToString());
                    Con.DatosUsuarioTodo(US);
                    MRegistroUsuario MI = new MRegistroUsuario(UA,US, 2);
                    MI.ShowDialog();
                    Chekear();
                    Con.MostrarUsuariosRegistrados(US, DGVI);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MRegistroUsuario mr = new MRegistroUsuario(UA,US,1);
            mr.ShowDialog();
            Chekear();
            Con.MostrarUsuariosRegistrados(US, DGVI);
        }
    }
}
