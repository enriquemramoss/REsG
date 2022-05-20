using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CENTIDAD
{
    public class USUARIO
    {
        #region Atributos
        //Datos del insumo
        string sNoEconomico;
        string sNombre;
        string sPuesto;
        string sCURP;
        string sCorreo;
        string sContraseña;
        DataTable cDataTable;
        string sPrivilegio;
        string sNuevoNoEconomico;
        int sMaestro;
        int sActivo;
        public USUARIO()
        {
            sNoEconomico="";
            sNombre="";
            sPuesto="";
            sCURP="";
            sCorreo="";
            sContraseña="";
            sPrivilegio = "                      ";
            sNuevoNoEconomico = "";
            sMaestro = 0;
        }
        /// <summary>
        /// Métodos de acceso.
        /// </summary>

        public string Privilegio
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
        public int Activo
        {
            get
            {
                return sActivo;
            }
            set
            {
                sActivo = value;
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
        public string NuevoNoEconomico
        {
            get
            {
                return sNuevoNoEconomico;
            }
            set
            {
                sNuevoNoEconomico = value;
            }
        }
        public DataTable Datatable
        {
            get
            {
                return cDataTable;
            }
            set
            {
                cDataTable = value;
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
        #endregion
    }
}