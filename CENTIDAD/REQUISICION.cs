using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CENTIDAD
{
    public class REQUISICION
    {
        int sNoRequisicion;
        string sNoDReporte;
        string sEncargado;
        string sNoEconomico;
        string sFechaRequisicion;
        string sFechaRequisicionFin;
        int sCantidadInsumo;
        string sInsumo;
        string sCaracteristica;
        string sUbicacion;
        DataTable cDataTable;
        public REQUISICION()
        {
            sNoRequisicion=0;
            sNoDReporte="";
            sEncargado="";
            sNoEconomico="";
            sFechaRequisicion="";
            sFechaRequisicionFin="";
            sCantidadInsumo=0;
            sInsumo="";
            sCaracteristica="";
            sUbicacion="";
        }
        public int NoRequisicion
        {
            get
            {
                return sNoRequisicion;
            }
            set
            {
                sNoRequisicion = value;
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
        public string FechaRequisicion
        {
            get
            {
                return sFechaRequisicion;
            }
            set
            {
                sFechaRequisicion = value;
            }
        }
        public string FechaRequisicionFin
        {
            get
            {
                return sFechaRequisicionFin;
            }
            set
            {
                sFechaRequisicionFin = value;
            }
        }
        public int CantidadInsumo
        {
            get
            {
                return sCantidadInsumo;
            }
            set
            {
                sCantidadInsumo = value;
            }
        }
        public string Insumo
        {
            get
            {
                return sInsumo;
            }
            set
            {
                sInsumo = value;
            }
        }
        public string Caracteristica
        {
            get
            {
                return sCaracteristica;
            }
            set
            {
                sCaracteristica = value;
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
