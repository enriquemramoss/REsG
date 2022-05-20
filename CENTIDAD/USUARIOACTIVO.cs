using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENTIDAD
{
    public class USUARIOACTIVO
    {
        string sNoEconomico;
        string sNombre;
        string sPuesto;
        string sCURP;
        string sCorreo;
        string sContraseña;
        int[] sPrivilegio;
        int sMaestro;
        public USUARIOACTIVO()
        {
        }
        public string Correo
        {
            get
            {
                return sCorreo;
            }
            set
            {
                sCorreo = value;
            }
        }
        public int Maestro
        {
            get
            {
                return sMaestro;
            }
            set
            {
                sMaestro = value;
            }
        }
        public int[] Privilegio
        {
            get
            {
                return sPrivilegio;
            }
            set
            {
                sPrivilegio = value;
            }
        }
        public string Contraseña
        {
            get
            {
                return sContraseña;
            }
            set
            {
                sContraseña = value;
            }
        }
        public string NoEconomico
        {
            get
            {
                return sNoEconomico;
            }
            set
            {
                sNoEconomico = value;
            }
        }
      
        public string Nombre
        {
            get
            {
                return sNombre;
            }
            set
            {
                sNombre = value;
            }
        }
        public string Puesto
        {
            get
            {
                return sPuesto;
            }
            set
            {
                sPuesto = value;
            }
        }
        public string CURP
        {
            get
            {
                return sCURP;
            }
            set
            {
                sCURP = value;
            }
        }

    }
}
