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
using CVALIDACION;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class MRecuperarContra : Form
    {
        USUARIO US= new USUARIO();
        
        ExpresionesRegulares EX = new ExpresionesRegulares();
        Seguridad SE = new Seguridad();
        Contacto Con = new Contacto();
        public MRecuperarContra()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            //this.Close();
            if (EX.Correo(tCorreo.Text))
            {
                US.Correo = tCorreo.Text;
                Con.RecuperarContraseña(US);
                if (US.NoEconomico=="0"||US.Contraseña=="")
                {
                    Mensaje2 M2 = new Mensaje2("Correo no Coincide", "No se pudo encontrar el correo favor de verificar");
                    if (M2.ShowDialog() == DialogResult.OK)
                    {
                        US = new USUARIO();
                       tCorreo.Focus();
                        tCorreo.Text = "";
                    }
                }
                else
                {
                    if (EX.EnviarCorreo(US.Correo, "Correo de Recuperación", "Programa Control de Insumos Macrocentro", US.NoEconomico,(SE.DesEncriptar(US.Contraseña))))
                    {
                        Mensaje2 M2 = new Mensaje2("Favor de revisar su bandeja de entrada", "Correo Enviado Exitosamente");
                        if (M2.ShowDialog() == DialogResult.OK)
                        {
                            tCorreo.Text = "";
                            this.Close();
                        }
                    }
                    else
                    {
                        Mensaje2 M2 = new Mensaje2("Favor de intentar más tarde", "Error en la conexión");
                        if (M2.ShowDialog() == DialogResult.OK)
                        {
                            US = new USUARIO();
                            tCorreo.Focus();
                            tCorreo.Text = "";
                        }
                    }
                }
            }
            else
            {
                Mensaje2 M2 = new Mensaje2("El correo no tiene el formato correcto", "Formato Incorrecto");
                M2.ShowDialog();
            }

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {

        }

        private void pCorreo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
