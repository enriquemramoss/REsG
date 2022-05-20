using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CVALIDACION;
using CNEGOCIO;
using CENTIDAD;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MInsumos : Form
    {
        ExpresionesRegulares VAL = new ExpresionesRegulares();
        Contacto Con = new Contacto();
        INSUMO EI = new INSUMO();
        USUARIOACTIVO UA;
        Formato fr = new Formato();
        bool Modificar;
        int LX, LY, SW, SH;
        public MInsumos(USUARIOACTIVO UA, INSUMO EI,bool Modificar)
        {
            this.UA = UA;
            this.Modificar = Modificar;
            InitializeComponent();
            if (Modificar)
            {
                this.EI = EI;
                lblTitulo.Text = "MODIFICAR INSUMO";
                BTNLIMPIAR.Visible = false;
                BTNACEPTAR.Visible = false;
                btnModificar.Visible = true;
                btnCancelar.Visible = true;
            }
        }

        private void MInicio_Load(object sender, EventArgs e)
        {
            if (Modificar)
            {
                tModelo.Text = EI.Modelo;
                tTipo.Text = EI.Tipo;
                int cont = 0;
                foreach (var item in CBU.Items)
                {
                    if (item.ToString() == EI.Ubicación)
                        CBU.SelectedIndex = cont;
                    cont++;
                }
                tPrecio.Text = EI.Precio;
                tNoSerie.Text = EI.NoSerie;
                tDescripcion.Text = EI.Descripcion;
                tInformacion.Text = EI.Informacion;
                pModelo.BackColor = Color.Green;
                pTipo.BackColor = Color.Green;
                pPrecio.BackColor = Color.Green;
                pSerie.BackColor = Color.Green;
                pDescripcion.BackColor = Color.Green;
                pInformacion.BackColor = Color.Green;
            }
            else
                CBU.SelectedIndex = 0;
        }

        private void BTNACEPTAR_Click(object sender, EventArgs e)
        {
            if (pModelo.BackColor == Color.Green && pTipo.BackColor == Color.Green && pSerie.BackColor == Color.Green && pPrecio.BackColor == Color.Green && pDescripcion.BackColor == Color.Green && pInformacion.BackColor == Color.Green)
            {
                LlenarDatos();
                Con.RegistroInsumo(EI);
                Mensaje2 M = new Mensaje2("Registro Exitoso", "Insumo Registrado");
                if (M.ShowDialog() == DialogResult.OK) { limpiar(); }
            }
            else
            {
                Mensaje2 M = new Mensaje2("Error de Registro", "Favor de llenar los campos faltantes");
                M.ShowDialog();
            }

        }
        public void LlenarDatos()
        {
            EI.Descripcion = tDescripcion.Text;
            EI.Ubicación = CBU.Text;
            EI.Tipo = tTipo.Text;
            EI.NoEconomico = UA.NoEconomico;
            EI.Precio = tPrecio.Text;
            EI.Informacion = tInformacion.Text;
            EI.NoSerie = tNoSerie.Text;
            EI.Modelo = tModelo.Text;
            EI.FechaRegistro = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BTNLIMPIAR_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            tModelo.Text = "";
            tTipo.Text = "";
            CBU.SelectedItem = -1;
            tPrecio.Text = "";
            tNoSerie.Text = "";
            tDescripcion.Text = "";
            tInformacion.Text = "";
            pModelo.BackColor = Color.Silver;
            pTipo.BackColor = Color.Silver;
            pPrecio.BackColor = Color.Silver;
            pSerie.BackColor = Color.Silver;
            pDescripcion.BackColor = Color.Silver;
            pInformacion.BackColor = Color.Silver;
            tModelo.Focus();
        }

        private void tModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.LetraDigito(e);
        }

        private void tTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.SoloLetrasSE(e);
        }

        private void tPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.NumerosPunto(e);
        }

        private void tModelo_KeyUp(object sender, KeyEventArgs e)
        {
            if(!VAL.Vacio(tModelo.Text))
            {
                pModelo.BackColor = Color.Green;
            }
            else
                pModelo.BackColor = Color.Red;

        }

        private void tTipo_KeyUp(object sender, KeyEventArgs e)
        {
            if (!VAL.Vacio(tTipo.Text))
            {
                pTipo.BackColor = Color.Green;
            }
            else
                pTipo.BackColor = Color.Red;
        }

        private void tDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            if (!VAL.Vacio(tDescripcion.Text))
            {
                pDescripcion.BackColor = Color.Green;
            }
            else
                pDescripcion.BackColor = Color.Red;
        }

        private void tModelo_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void tTipo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tPrecio_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tNoSerie_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void tInformacion_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            if(VAL.Precio(tPrecio.Text))
                pPrecio.BackColor = Color.Green;
            else
                pPrecio.BackColor = Color.Red;


        }

        private void tInformacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (!VAL.Vacio(tInformacion.Text))
                pInformacion.BackColor = Color.Green;
            else
                pInformacion.BackColor = Color.Red;
        }

        private void tNoSerie_KeyUp(object sender, KeyEventArgs e)
        {
            if (!VAL.Vacio(tNoSerie.Text))
                pSerie.BackColor = Color.Green;
            else
                pSerie.BackColor = Color.Red;
        }

        private void tNoSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.LetraDigitoSE(e);
        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (pModelo.BackColor == Color.Green && pTipo.BackColor == Color.Green && pSerie.BackColor == Color.Green && pPrecio.BackColor == Color.Green && pDescripcion.BackColor == Color.Green && pInformacion.BackColor == Color.Green)
            {
                LlenarDatos();
                Mensaje M = new Mensaje("Seguro que desea modificar los datos del insumo", "Modificar Insumo");
                if (M.ShowDialog() == DialogResult.OK)
                {
                    Con.ModificarInsumo(EI);
                    this.Close();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }
    }
}
