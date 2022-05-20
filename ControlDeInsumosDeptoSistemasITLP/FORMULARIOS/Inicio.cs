using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CNEGOCIO;
using CENTIDAD;
using CVALIDACION;
namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class INICIO : Form
    {
        Contacto Con = new Contacto();
        Seguridad SE = new Seguridad();
        Icon IC;
        USUARIO US = new USUARIO();
        NOTIFICACIÓN NT = new NOTIFICACIÓN();
        USUARIOACTIVO UA;
        NotifyIcon noT;
        bool Notify = false;
        public INICIO()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
            //this.BringToFront();
        }
        public void StartForm()
        {
            try
            {
                Application.Run(new Carga());
            }
            catch (Exception E)
            {
                E.Message.ToString();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.BringToFront();
            linkLabel2.Visible = false;
            if (Con.SaberSiExisteUsuarioMaestro() == false)
            {
                linkLabel2.Visible = true;
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int LX, LY, SW, SH;
        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MRegistroUsuario M = new MRegistroUsuario(UA,US,0);
            if (M.ShowDialog()== DialogResult.OK)
            {
                linkLabel2.Visible = false;
            }
           
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tNumeroEconomico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)||char.IsNumber(e.KeyChar)&&tNumeroEconomico.TextLength<3)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)09)
            {
                materialRaisedButton1.Focus();
            }
            else
            if (tContraseña.TextLength < 15)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tNumeroEconomico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Tab)
            {
                tContraseña.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MRecuperarContra RC = new MRecuperarContra();
            RC.ShowDialog();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //try
            // { 
                UA = new USUARIOACTIVO();
                LlenarDatos();
                if (Con.Login(US) == 1)
                {
                    Con.DatosUsuarioTodo(UA);
                    Form Menu = new FormMenu(UA,notifyIcon1);
                if ((UA.Privilegio[4] == 1) && (UA.Privilegio[1] == 1))
                {
                    Con.CambiarFechaInsumos(NT);
                    notificacion2(NT.NoInsumosCambiados, notifyIcon1);
                    Con.NoResguardados(NT);
                    notificacion(NT.NoInsumos, notifyIcon1);
                }
                this.Hide();
                Menu.ShowDialog();
                this.Show();
                    tNumeroEconomico.Focus();
                    tNumeroEconomico.Focus();
                }
                if (Con.Login(US) == 0)
                {
                    Mensaje2 M = new Mensaje2("Usuario o contraseña no válido.\nFavor de volver a ingresar los campos correctamente.", "Acceso inválido");
                    if (M.ShowDialog() == DialogResult.OK) { }
                }
                tNumeroEconomico.Text = "";
                tContraseña.Text = "";
                tNumeroEconomico.Focus();
                tNumeroEconomico.Focus();
           // }
           // catch(Exception ex)
           // {
           //     Mensaje2 me = new Mensaje2("El formato del número económico es incorrecto", "Error de Formato");
           //     me.ShowDialog();
           // }
           
        }
        public void LlenarDatos()
        {
            if (tNumeroEconomico.Text == "")
            {
                US.NoEconomico = "0";
                UA.NoEconomico = "0";
            }
            else
            {
                US.NoEconomico = tNumeroEconomico.Text;
                UA.NoEconomico = tNumeroEconomico.Text;
            }
            US.Contraseña = SE.Encriptar(tContraseña.Text);
            UA.Contraseña = SE.Encriptar(tContraseña.Text);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //MReporteResguardo MR = new MReporteResguardo();
            //MR.ShowDialog();
        }

        private void ntfI_BalloonTipClicked(object sender, EventArgs e)
        {

        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }
        public void notificacion(int red,NotifyIcon N)
        {
            if (red != 0)
            {
                N.Visible = true;
                N.Text = "Insumos sin resguardo";
                N.BalloonTipTitle = "Insumos sin resguardo"; 
                N.BalloonTipText = "Tiene " + red + " insumos sin resguardar";
                N.BalloonTipIcon = ToolTipIcon.Info;
                N.ShowBalloonTip(3000);
            }
        }
        public void notificacion2(int red, NotifyIcon N)
        {
            if (red != 0)
            {
                N.Visible = true;
                N.Text = "Aviso";
                N.BalloonTipTitle = "El resguardo de encargo ha finalizado";
                N.BalloonTipText = "Ha vencido el plazo de resguardo de " + red + " insumos";
                N.BalloonTipIcon = ToolTipIcon.Info;
                N.ShowBalloonTip(3000);
                N.Visible = false;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                notifyIcon1.Visible = false;
                MReporteResguardo MR = new MReporteResguardo();
                MR.ShowDialog();
        }
    }
}
