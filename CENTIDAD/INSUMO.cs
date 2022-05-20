using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENTIDAD
{
    public class INSUMO 
    {
        #region Atributos
        //Datos del insumo
        string sDescripcion;
        string sUbicación;
        string sModelo;
        string cPrecio;
        string cPrecioH;
        string sFechaRegistro;
        string sInformacion;
        string sID;
        string sTipo;
        string sNoEconomico;
        string sNoSerie;
        string sEncargado;
        int sActivo;

        public INSUMO()
        {
            sID = "";
            sDescripcion="";
            sUbicación = "";
            sModelo = "";
            cPrecio = "";
            PrecioH = "";
            sFechaRegistro = "";
            sInformacion = "";
            sTipo = "";
            sNoEconomico = "";
            sNoSerie = "";
            sEncargado = "";
            sActivo = 1;
        }
        /// <summary>
        /// Métodos de acceso.
        /// </summary>
        public string Descripcion
        {
            get
            {
                return sDescripcion;
            }
            set
            {
                sDescripcion = value;
            }
        }
        public string Encargado
             {
            get
            {
                return sEncargado;
            }
            set
            {
                sEncargado = value;
            }
        }
        public string Ubicación
        {
            get
            {
                return sUbicación;
            }
            set
            {
                sUbicación = value;
            }
        }
        public string Modelo
        {
            get
            {
                return sModelo;
            }
            set
            {
                sModelo = value;
            }
        }
        public string Precio
        {
            get
            {
                return cPrecio;
            }
            set
            {
                cPrecio = value;
            }
        }
        public string PrecioH
        {
            get
            {
                return cPrecioH;
            }
            set
            {
                cPrecioH = value;
            }
        }
        public string FechaRegistro
        {
            get
            {
                return sFechaRegistro;
            }
            set
            {
                sFechaRegistro = value;
            }
        }
        public string Informacion
        {
            get
            {
                return sInformacion;
            }
            set
            {
                sInformacion = value;
            }
        }
        public string Tipo
        {
            get
            {
                return sTipo;
            }
            set
            {
                sTipo = value;
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
        public string NoSerie
        {
            get
            {
                return sNoSerie;
            }
            set
            {
                sNoSerie = value;
            }
        }
        public string ID
        {
            get
            {
                return sID;
            }
            set
            {
                sID = value;
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
        #endregion
    }
}
