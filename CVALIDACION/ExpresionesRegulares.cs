using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;

namespace CVALIDACION
{
    public class ExpresionesRegulares
    {
        public bool Contraseña(string sContraseña)
        {
            string strRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?_&])([A-Za-z\d$@$!%*?_&]|[^ ]){8,15}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sContraseña))
                return (true);
            return (false);
        }
        public bool Correo(string sEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sEmail))
                return (true);
            return (false);
        }
        public bool Curp(string sCurp)
        {
            string strRegex = @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sCurp))
                return (true);
            return (false);
        }

        public bool Telefono(string sTelefono)
        {
            string strRegex = @"^[0-9]{10}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sTelefono))
                return (true);
            return (false);
        }
        public bool NombreApellidos(string nombreapellidos)
        {
            string strRegex = @"^([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\']+[\s])+([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\'])+[\s]?([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\'])?$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(nombreapellidos))
                return (true);
            return (false);
        }
        public bool Promedio(string sPromedio)
        {
            string strRegex = @"^([0-9]{1,2}.[0-9]{1,2})$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sPromedio))
                return (true);
            return (false);
        }
        public bool Direccion(string sDireccion)
        {
            string strRegex = @"^(.*[^\s])$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sDireccion))
                return (true);
            return (false);
        }
        public bool Precio(string sPrecio)
        {
            string strRegex = @"^([0-9]+(.[0-9]{2})?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sPrecio))
                return (true);
            return (false);
        }
        public bool Vacio(string sValor)
        {
            string strRegex = @"^\s*$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(sValor))
                return (true);
            return (false);
        }
        public bool EnviarCorreo(string receptor, string asunto, string titulo, string usuario, string contraseña)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential
                        ("ingenieriasoftwareitlp@gmail.com", "IngenieriaDeSoftware");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            mail = new MailMessage();
            try
            {
                mail.From = new MailAddress("ingenieriasoftwareitlp@gmail.com",
                titulo, System.Text.Encoding.UTF8);
                mail.To.Add(receptor);
                mail.Subject = asunto;
                mail.Body = "Sistema de Control de Inventarios del Macrocentro\nSu Usuario es: " + usuario + "\nSu contraseña es: " + contraseña;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                SmtpServer.Send(mail);
                return true;
                //MessageBox.Show("Correo enviado exitosamente", "Exito");
            }
            catch (Exception ex)
            {
                return false;
                //MessageBox.Show("No se pudo enviar el correo, favor de volverlo a intentar", "Error de envio");
            }
        }

        //public bool CodigoPostal(string codigopostal)
        //{
        //    string strRegex = @"^[0-9]{5}$";
        //    Regex re = new Regex(strRegex);
        //    if (re.IsMatch(codigopostal))
        //        return (true);
        //    return (false);
        //}
        //public bool CodigoPostalCan(string codigopostalcan)
        //{
        //    string strRegex = @"^[A-Z][0-9][A-Z][0-9][A-Z][0-9]$";
        //    Regex re = new Regex(strRegex);
        //    if (re.IsMatch(codigopostalcan))
        //        return (true);
        //    return (false);
        //} //public bool NombreUsuario(string nombreusuario)
        //{
        //    string strRegex = @"^[A-Za-z0-9]{4,8}$";
        //    Regex re = new Regex(strRegex);
        //    if (re.IsMatch(nombreusuario))
        //        return (true);
        //    return (false);
        //}
    }
}
