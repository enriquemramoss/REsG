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

    public partial class MRegistroUsuario : Form
    {
        Formato fr = new Formato();
        int Usuario;
        ExpresionesRegulares ex = new ExpresionesRegulares();
        Contacto Con = new Contacto();
        USUARIO US = new USUARIO();
        Seguridad SE = new Seguridad();
        USUARIOACTIVO UA = new USUARIOACTIVO();
        string CorreoValido;
        string NoEconomico;
        int LX, LY, SW, SH;
        public MRegistroUsuario(USUARIOACTIVO UA,USUARIO US,int b)
        {
            InitializeComponent();
            this.US = US;
            this.UA = UA;
            Usuario = b;
            if (b==0)
                CambiarDiseño();
            if (b == 2)
                CambiarDiseñoModificar();
        }
        public void CambiarDiseño()
        {
            panelHeader.Visible = true;
            label7.Text = label7.Text + " MAESTRO";
            btnPermisos.Visible = false;
        }
        public void CambiarDiseñoModificar()
        {
            panelHeader.Visible = true;
            label7.Text = "MODIFICAR USUARIO";
            btnRegistrar.Visible = false;
            btnModificar.Visible = true;
            tEconomico.Text = US.NoEconomico;
            tEconomico.Enabled = true;
            tNombre.Text = US.Nombre;
            tPuesto.Text = US.Puesto;
            tCurp.Text = US.CURP;
            tCorreo.Text = US.Correo;
            tContraseña.Text = SE.DesEncriptar(US.Contraseña);
            TConfirmacion.Text = SE.DesEncriptar(US.Contraseña);
            pNEco.BackColor = Color.Green;
            pNombre.BackColor = Color.Green;
            pPuesto.BackColor = Color.Green;
            pCurp.BackColor = Color.Green;
            pCorreo.BackColor = Color.Green;
            pContraseña.BackColor = Color.Green;
            pConfi.BackColor = Color.Green;
            CorreoValido = US.Correo;
            NoEconomico = US.NoEconomico;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MRegistroUsuario_Load(object sender, EventArgs e)
        {
            if (US.Maestro == 1)
                btnPermisos.Visible = false;
            tEconomico.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.SoloNumero(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.LetraDigito(e);

        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (ex.Curp(tCurp.Text))
            {
               
                pCurp.BackColor = Color.Green;
            }
            else
            {
                pCurp.BackColor = Color.Red;
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.FormaCorreo(e);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tEconomico.Text.Length <= 3 && tEconomico.Text != "" && tEconomico.Text != "0" && tEconomico.Text != "00" && tEconomico.Text != "000")
            {
                pNEco.BackColor = Color.Green;
            }

            else
            {
                pNEco.BackColor = Color.Red;
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (ex.NombreApellidos(tNombre.Text.ToUpper()))
            {
                pNombre.BackColor = Color.Green;
            }
            else
            {
                pNombre.BackColor = Color.Red;
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (!ex.Vacio(tPuesto.Text))
            {
                pPuesto.BackColor = Color.Green;
            }

            else
            {
                pPuesto.BackColor = Color.Red;
            }
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (ex.Correo(tCorreo.Text))
            {
                pCorreo.BackColor = Color.Green;
            }
            else
            {
                pCorreo.BackColor = Color.Red;
            }

        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if (ex.Contraseña(tContraseña.Text))
            {
                pContraseña.BackColor = Color.Green;
            }

            else
            {
                pContraseña.BackColor = Color.Red;
            }
            if (TConfirmacion.Text == tContraseña.Text)
            {
                pConfi.BackColor = Color.Green;
            }
            else
            {
                pConfi.BackColor = Color.Red;
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (TConfirmacion.Text == tContraseña.Text)
            {
                pConfi.BackColor = Color.Green;
            }
            else
            {
                pConfi.BackColor = Color.Red;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            fr.FormaConstraseña(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            tEconomico.Clear();
            tNombre.Clear();
            tCurp.Clear();
            tPuesto.Clear();
            TConfirmacion.Clear();
            tCorreo.Clear();
            tContraseña.Clear();
            tEconomico.Focus();
            NE.Text = "";
            NO.Text = "";
            PU.Text = "";
            CU.Text = "";
            CO.Text = "";
            CON1.Text = "";
            CON2.Text = "";
            pNEco.BackColor = Color.Silver;
            pNombre.BackColor = Color.Silver;
            pCurp.BackColor = Color.Silver;
            pPuesto.BackColor = Color.Silver;
            pCorreo.BackColor = Color.Silver;
            pContraseña.BackColor = Color.Silver;
            pConfi.BackColor = Color.Silver;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MRegistroUsuario_MouseUp(object sender, MouseEventArgs e)
        {
            //textBox7.PasswordChar 

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            tContraseña.UseSystemPasswordChar = false;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            tContraseña.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pNEco.BackColor == Color.Green && pNombre.BackColor == Color.Green && pPuesto.BackColor == Color.Green && pCurp.BackColor == Color.Green && pCorreo.BackColor == Color.Green && pContraseña.BackColor == Color.Green && pConfi.BackColor == Color.Green)
            {
                LlenarDatos();
                if (Con.CorreoExistente(US))
                {
                    pCorreo.BackColor = Color.Red;
                    Mensaje2 M = new Mensaje2("El correo ya se encuentra registrado.\nFavor de escribir otro.", "Correo ya registrado");
                    if (M.ShowDialog() == DialogResult.OK) { tCorreo.Focus(); }
                }
                else
                {
                    if (Con.NoEconomicoExistente(US))
                    {
                        pNEco.BackColor = Color.Red;
                        Mensaje2 M = new Mensaje2("El No.Economico ya está en uso.\nFavor de escribir otro.", "No.Economico ya registrado");
                        if (M.ShowDialog() == DialogResult.OK) { tEconomico.Focus(); }
                    }
                    else
                    if (Usuario == 1)
                    {
                        Con.RegistroUsuario(US);
                        Mensaje2 M = new Mensaje2("Registro Exitoso", "Usuario Registrado");
                        if (M.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; this.Close(); }
                    }
                    else
                    {
                        Con.RegistroUsuarioMaestro(US);
                        Mensaje2 M2 = new Mensaje2("Registro Exitoso", "Usuario Maestro Registrado");
                        if (M2.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; this.Close(); }
                    }
                }
            }
            else
            {
                Mensaje2 M2 = new Mensaje2("Error Registro", "Favor de revisar los campos en rojo");
                if (M2.ShowDialog() == DialogResult.OK) { }
            }
        }
        public void LlenarDatos()
        {
            US.NoEconomico = tEconomico.Text;
            US.NuevoNoEconomico = NoEconomico;
            US.Nombre = tNombre.Text;
            US.Puesto = tPuesto.Text;
            US.Contraseña = SE.Encriptar(tContraseña.Text);
            US.Correo = tCorreo.Text;
            US.CURP = tCurp.Text;
        }

        private void pNEco_Paint(object sender, PaintEventArgs e)
        {

        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (pNEco.BackColor == Color.Green && pNombre.BackColor == Color.Green && pPuesto.BackColor == Color.Green && pCurp.BackColor == Color.Green && pCorreo.BackColor == Color.Green && pContraseña.BackColor == Color.Green && pConfi.BackColor == Color.Green)
            {
                LlenarDatos();
                if (Con.CorreoExistente(US)&&CorreoValido!=US.Correo)
                {
                    pCorreo.BackColor = Color.Red;
                    Mensaje2 M = new Mensaje2("El correo ya se encuentra registrado.\nFavor de escribir otro.", "Correo ya registrado");
                    if (M.ShowDialog() == DialogResult.OK) { tCorreo.Focus(); }
                }
                else
                {
                    if (Con.NoEconomicoExistente(US) && NoEconomico != US.NoEconomico)
                    {
                        pNEco.BackColor = Color.Red;
                        Mensaje2 M = new Mensaje2("El No.Economico ya está en uso.\nFavor de escribir otro.", "No.Economico ya registrado");
                        if (M.ShowDialog() == DialogResult.OK) { tEconomico.Focus(); }
                    }
                    else
                    {
                        Con.ModificarUsuario(US);
                        Mensaje2 M = new Mensaje2("Datos modificados exitosamente", "Usuario Modificado");
                        if (M.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; this.Close(); }
                    }
                    }
                }
            else
            {
                Mensaje2 M2 = new Mensaje2("Error Registro", "Favor de revisar los campos en rojo");
                if (M2.ShowDialog() == DialogResult.OK) { }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MPrivilegios MP = new MPrivilegios(US,UA);
            MP.ShowDialog();
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
