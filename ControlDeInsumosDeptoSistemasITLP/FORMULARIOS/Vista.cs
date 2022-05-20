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

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class Vista : Form
    {
        REPORTE ER;
        REQUISICION EREQ;
        REPORTEENCARGADOS EREG;
        USUARIOACTIVO UA;
        USUARIO US;
        USUARIOMAESTRO USM = new USUARIOMAESTRO();
        int Tipo;
        public Vista(USUARIOACTIVO UA, REPORTE ER, int Tipo)
        {
            this.UA = UA;
            this.ER = ER;
            this.Tipo = Tipo;
            InitializeComponent();
        }
        public Vista(USUARIOACTIVO UA,REQUISICION EREQ, int Tipo)
        {
            this.UA = UA;
            this.EREQ = EREQ;
            this.Tipo = Tipo;
            InitializeComponent();
        }
        public Vista(USUARIO US,REPORTEENCARGADOS EREG, int Tipo)
        {
            this.US = US;
            this.EREG = EREG;
            this.Tipo = Tipo;
            InitializeComponent();
        }
        public Vista( REPORTEENCARGADOS EREG, int Tipo)
        {
            this.EREG = EREG;
            this.Tipo = Tipo;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Contacto CON = new Contacto();
            CON.DatosUsuarioMaestro(USM);
            switch (Tipo)
            {
                case 1://Reporte de Insumos por Tipo
                    {
                        ReporteInsumos RI = new ReporteInsumos();
                        RI.Database.Tables["ReporteI"].SetDataSource(ER.Datatable);
                        RI.SetParameterValue("@Ubicacion", ER.Busqueda);
                        RI.SetParameterValue("FechaIni", ER.FechaI);
                        RI.SetParameterValue("FechaFin", ER.FechaFin);
                        crystalReportViewer1.ReportSource = null;
                        crystalReportViewer1.ReportSource = RI;
                        crystalReportViewer1.Refresh();
                        break;
                    }
                case 0://Reporte de Insumos por Ubicación
                    {
                        ReporteTipo RI = new ReporteTipo();
                        RI.Database.Tables["ReporteTipo"].SetDataSource(ER.Datatable);
                        RI.SetParameterValue("@Tipo", ER.Busqueda);
                        RI.SetParameterValue("FechaIni", ER.FechaI);
                        RI.SetParameterValue("FechaFin", ER.FechaFin);
                        crystalReportViewer1.ReportSource = null;
                        crystalReportViewer1.ReportSource = RI;
                        crystalReportViewer1.Refresh();
                        break;
                    }
                case 2://Reporte de Formato de Requisicion
                    {
                        Requisicion RI = new Requisicion();
                        RI.Database.Tables["Requisicion"].SetDataSource(EREQ.Datatable);
                        RI.SetParameterValue("@Usuario", UA.Nombre);
                        RI.SetParameterValue("@Fecha", EREQ.FechaRequisicion);
                        RI.SetParameterValue("@Area", "Sistemas y Computación");
                        RI.SetParameterValue("@Curp", UA.CURP);
                        RI.SetParameterValue("@Puesto", UA.Puesto);
                        RI.SetParameterValue("@UsuarioMaestro", USM.Nombre);
                        RI.SetParameterValue("@PuestoMaestro", USM.Puesto);
                        crystalReportViewer1.ReportSource = null;
                        crystalReportViewer1.ReportSource = RI;
                        crystalReportViewer1.Refresh();
                        break;
                    }
                case 3://Reporte de Requisiciones
                    {
                        ReporteRequisiciones RI = new ReporteRequisiciones();
                        RI.Database.Tables["ReporteRequisiciones"].SetDataSource(ER.Datatable);
                        RI.SetParameterValue("FechaIni", ER.FechaI);
                        RI.SetParameterValue("FechaFin", ER.FechaFin);
                        crystalReportViewer1.ReportSource = null;
                        crystalReportViewer1.ReportSource = RI;
                        crystalReportViewer1.Refresh();
                        break;
                    }
                case 4://Reporte de Formato de Requisicion
                    {
                        ValeResguardo RI = new ValeResguardo();
                        RI.Database.Tables["ValeResguardo"].SetDataSource(EREG.Datatable);
                        RI.SetParameterValue("@Usuario", US.Nombre);
                        RI.SetParameterValue("@Area", "Sistemas y Computación");
                        RI.SetParameterValue("@Curp", US.CURP);
                        RI.SetParameterValue("@Puesto", US.Puesto);
                        RI.SetParameterValue("@FechaAsig", EREG.FechaInicio);
                        RI.SetParameterValue("@TerminoResg", EREG.FechaFin);
                        RI.SetParameterValue("@NombreMaestro", USM.Nombre);
                        RI.SetParameterValue("@PuestoMaestro", USM.Puesto);
                        crystalReportViewer1.ReportSource = null;
                        crystalReportViewer1.ReportSource = RI;
                        crystalReportViewer1.Refresh();
                        break;
                    }
                case 5://Reporte de Formato Encargos
                    {
                        ReporteEncargos RI = new ReporteEncargos();
                        RI.Database.Tables["ReporteEncargos"].SetDataSource(EREG.Datatable);
                        RI.SetParameterValue("@Encargado", EREG.NombreEncargado);
                        RI.SetParameterValue("FechaIni", EREG.FechaInicio);
                        RI.SetParameterValue("FechaFin", EREG.FechaFin);
                        crystalReportViewer1.ReportSource = null;
                        crystalReportViewer1.ReportSource = RI;
                        crystalReportViewer1.Refresh();
                        break;
                    }
            }
           
        }

        private void Vista_Load(object sender, EventArgs e)
        {

        }
    }
}
