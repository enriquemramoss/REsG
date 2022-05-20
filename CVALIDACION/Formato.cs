using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVALIDACION
{
    public class Formato
    {
        public bool SoloLetras(KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)08)
                e.Handled = false;
            else
                e.Handled = true;
            return false;

        }
        public bool SoloLetrasSE(KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)08)
                e.Handled = false;
            else
                e.Handled = true;
            return false;

        }
        public bool SoloNumero(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)08)
                e.Handled = false;
            else
                e.Handled = true;
            return false;
        }
        public bool FormaAltura(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)08 || e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
            return false;
        }
        public bool FormaCorreo(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)08 || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '@')
                e.Handled = false;
            else
                e.Handled = true;
            return false;
        }
        public bool LetraDigitoSE(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)08)
                e.Handled = false;
            else
                e.Handled = true;
            return false;
        }
        public bool LetraDigito(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' ||  e.KeyChar == (char)08)
                e.Handled = false;
            else
                e.Handled = true;
            return false;
        }

        public bool FormaConstraseña(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
            else
                e.Handled = false;
            return true;
        }
        public bool DobleEspacio(KeyPressEventArgs e, TextBox tx)
        {

            if (tx.Text.Length > 1)
            {
                if (tx.Text[tx.Text.Length - 1] == 32)
                {
                    if (e.KeyChar == ' ')
                        return true;
                }

            }
            else
                return false;
            return false;
        }
        public bool NumerosPunto(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.'|| e.KeyChar == (char)08)
                e.Handled = false;
            else
                e.Handled = true;
            return false;
        }



    }


}
