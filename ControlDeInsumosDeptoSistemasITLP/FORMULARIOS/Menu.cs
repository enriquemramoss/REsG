using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using CENTIDAD;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class FormMenu : Form
    {
        USUARIOACTIVO UA;
        INSUMO EI;
        public FormMenu(USUARIOACTIVO UA,NotifyIcon N)
        {
            this.UA = UA;
            InitializeComponent();
            N.Visible = false;
            
        }
        public void StartForm()
        {
            Application.Run(new Carga());
        }
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Mensaje me = new Mensaje("Seguro que desea cerrar sesión", "Sesión Usuario");
            if (me.ShowDialog() == DialogResult.OK)
                this.Close();
            else
            {

            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        int LX, LY,SW,SH;
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
            panelContenedor.Refresh();
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX,LY);
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
            panelContenedor.Refresh();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 57)
            {
               
                MenuVertical.Width = 250;
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;

            }
            else
            {
                
                MenuVertical.Width = 57;
                //pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            
        }

        private void btnPRODUCTOS_Click(object sender, EventArgs e)
        {

            MInicio frm = new MInicio(UA);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);

        }

        public void btnINICIO_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new FormLogo());
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarlogo();
            if (UA.Maestro == 1)
            {
                btnREGISTROUSUARIO.Visible = true;
                btnRespaldo.Visible = true;
            }
            int Location = 0;
            List<Point> LP = new List<Point>();
            LP.Add(btnINSUMOS.Location);
            LP.Add(btnREPORTES.Location);
            LP.Add(btnCONSULTAS.Location);
            LP.Add(btnCatalogoReporte.Location);
            //01711
            if (this.UA.Privilegio[0] == 0)
                btnINSUMOS.Visible = false;
            else
                Location++;
            if (this.UA.Privilegio[1] == 0)
                btnREPORTES.Visible = false;
            else
            {
                btnREPORTES.Location = LP[Location];
                Location++;
            }
            if (this.UA.Privilegio[7] == 0)
                btnCONSULTAS.Visible = false;
            else
            {
                btnCONSULTAS.Location = LP[Location];
                Location++;
            }
            if (this.UA.Privilegio[10] == 0)
                btnCatalogoReporte.Visible = false;
            else
            {
                btnCatalogoReporte.Location = LP[Location];
                Location++;
            }
        }
        private void mostrarlogo() {
            AbrirFormInPanel(new MInicio(UA));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCONSULTAS_Click(object sender, EventArgs e)
        {
            MConsultas frm = new MConsultas(UA);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnREPORTES_Click(object sender, EventArgs e)
        {
            MReporte frm = new MReporte(UA);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnREGISTROINSUMO_Click(object sender, EventArgs e)
        {
            MUsuarios frm = new MUsuarios(UA);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCatalogoReporte_Click(object sender, EventArgs e)
        {
            MCatalogoReportes frm = new MCatalogoReportes(UA);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            MRespayResta frm = new MRespayResta();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void mostrarlogoAlCerrarForm(object sender, FormClosedEventArgs e) {
            mostrarlogo();
        }

        private void btnVENTAS_Click(object sender, EventArgs e)
        {
            MInsumos frm = new MInsumos(UA,EI,false);
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
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
       

      
    }
}
