using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace CENTIDAD
{
    public class REPORTE
    {
        string sFiltrar;
        string sBusqueda;
        string sFechaI;
        string cFechaFin;
        DataTable cDataTable;
        
        public string Filtrar
        {
            get
            {
                return sFiltrar;
            }
            set
            {
                sFiltrar = value;
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
        public string Busqueda
        {
            get
            {
                return sBusqueda;
            }
            set
            {
                sBusqueda = value;
            }
        }
        public string FechaI
        {
            get
            {
                return sFechaI;
            }
            set
            {
                sFechaI = value;
            }
        }
        public string FechaFin
        {
            get
            {
                return cFechaFin;
            }
            set
            {
                cFechaFin = value;
            }
        }
    }
}
