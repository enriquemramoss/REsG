using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CENTIDAD
{
    public class REPORTEENCARGADOS
    {
        string sFechaInicio;
        string sFechaFin;
        string sUbicacion;
        string sNombreEncargado;
        int sNoReporte;
        string sNoDReporte;
        int sIDInsumo;
        DataTable cDataTable;
        public REPORTEENCARGADOS()
        {
            sFechaInicio = "";
            sFechaFin = "";
            sNombreEncargado = "";
            sNoReporte = 0;
            sNoDReporte="";
            sIDInsumo = 0;
        }
        public string FechaInicio
        {
            get
            {
                return sFechaInicio;
            }
            set
            {
                sFechaInicio = value;
            }
        }
        public string Ubicacion
        {
            get
            {
                return sUbicacion;
            }
            set
            {
                sUbicacion = value;
            }
        }
        public string NoDReporte
        {
            get
            {
                return sNoDReporte;
            }
            set
            {
                sNoDReporte = value;
            }
        }
        public string FechaFin
        {
            get
            {
                return sFechaFin;
            }
            set
            {
                sFechaFin = value;
            }
        }
        public string NombreEncargado
        {
            get
            {
                return sNombreEncargado;
            }
            set
            {
                sNombreEncargado = value;
            }
        }
        public int NoReporte
        {
            get
            {
                return sNoReporte;
            }
            set
            {
                sNoReporte = value;
            }
        }
        public int IDInsumo
        {
            get
            {
                return sIDInsumo;
            }
            set
            {
                sIDInsumo = value;
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
    }
}
