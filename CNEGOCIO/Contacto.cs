using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CENTIDAD;
using CDATOS;
using System.Windows.Forms;
using System.Data;
namespace CNEGOCIO
{
    public class Contacto
    {
        CONEXION CON = new CONEXION();
        public bool RegistroUsuario(USUARIO US) {
            return CON.RegistrarUsuario(US);
        }
        public bool RegistroUsuarioMaestro(USUARIO US)
        {
            return CON.RegistrarUsuarioMaestro(US);
        }
        public void Consulta(INSUMO IN,DataGridView DG)
        {
             CON.Consulta(IN,DG);
        }
        public void ConsultaP(INSUMO IN, DataGridView DG)
        {
            CON.ConsultaP(IN, DG);
        }
        public bool RegistroInsumo(INSUMO IN)
        {
            return CON.RegistroInsumo(IN);
        }
        public bool SaberSiExisteUsuarioMaestro()
        {
            return CON.SaberSiExisteUsuarioMaestro();
        }
        public void MostrarTipos(ComboBox CB)
        {
            CON.MostrarTipos(CB);
        }
        public void ReporteTipo(REPORTE ER,DataGridView DG)
        {
            CON.ReporteTipo(ER, DG);
        }
        public void ReporteUbicacion(REPORTE ER,DataGridView DG)
        {
            CON.ReporteUbicacion(ER,DG);
        }
        public int Login(USUARIO US)
        {
            return CON.Login(US);
        }
        public bool NoEconomicoExistente(USUARIO US)
        {
            return CON.NoEconomicoExistente(US);
        }
        public bool CorreoExistente(USUARIO US){return CON.CorreoExistente(US);}
        public void CrearRequisicion(REQUISICION EREQ) { CON.CrearRequisicion(EREQ); }
        public void RegistrarInsumoRequisicion(REQUISICION EREQ) { CON.RegistrarInsumoRequisicion(EREQ); }
        public void DatosUsuarioActivo(USUARIOACTIVO UA) { CON.DatosUsuarioActivo(UA); }
        public void TablaRequisicion(REPORTE ER, DataGridView DG) { CON.TablaRequisiciones(ER, DG); }
        public void MostrarUsuario(ComboBox CB) { CON.MostrarUSuarios(CB); }
        public void MostrarUsuarioActivos(ComboBox CB) { CON.MostrarUSuariosActivos(CB); }
        public void InsumoSinResguardo(DataGridView DT) { CON.InsumoSinResguardo(DT); }
        public void ResguardoTemporal(INSUMO EI) { CON.ResguardoTemporal(EI); }
        public void NoResguardoTemporal(INSUMO EI) { CON.NoResguardoTemporal(EI); }
        public void DatosUsuarioSelecionado(USUARIO US) { CON.DatosUsuarioSeleccionado(US); }
        public void CrearReporteEncargo(REPORTEENCARGADOS EREG) { CON.CrearReporteEncargado(EREG); }
        public void InsertarInsumoEncargado(REPORTEENCARGADOS EREG) { CON.InsertarInsumosEncargado(EREG); }
        public void ModificarEncargado(REPORTEENCARGADOS EREG, USUARIO US) { CON.ModificarEncargado(EREG,US); }
        public void MostrarReporteEncargados(REPORTEENCARGADOS EREG, DataGridView DG) { CON.MostrarReporteEncargado(EREG, DG); }
        public void EliminarInsumo(INSUMO EI) { CON.EliminarInsumo(EI); }
        public void ModificarInsumo(INSUMO EI) {CON.ModificarInsumo(EI); }
        public void DatosInsumo(INSUMO EI) { CON.DatosInsumo(EI);}
        public void RecuperarContraseña(USUARIO US) { CON.RecuperarContraseña(US); }
        public void MostrarUsuariosRegistrados(USUARIO US,DataGridView DT){ CON.MostrarUsuariosRegistrados(US, DT); }
        public void EliminarUsuario(USUARIO US) { CON.EliminarUsuario(US); }
        public void DatosUsuarioTodo(USUARIO US) {CON.DatosUsuarioTodo(US); }
        public void DatosUsuarioTodo(USUARIOACTIVO US) { CON.DatosUsuarioTodo(US); }
        public void DatosUsuarioMaestro(USUARIOMAESTRO US) { CON.DatosUsuarioMaestro(US); }
        public void ModificarUsuario(USUARIO US) { CON.ModificarUsuario(US); }
        public void ConsultarReporteRequisicion(REQUISICION EREQ, DataGridView DTG) { CON.ConsultarReporteRequisicion(EREQ,DTG); }
        public void ConsultarReporteEncargados(REPORTEENCARGADOS EREG, DataGridView DTG) { CON.ConsultarReporteEncargos(EREG, DTG); }
        public void NoResguardados(NOTIFICACIÓN NT) { CON.NoResguardados(NT); }
        public void CambiarFechaInsumos(NOTIFICACIÓN NT) { CON.CambiarFechaInsumos(NT); }
        public void SaberQueUsuarioEsElEncargado(REPORTEENCARGADOS EREG, USUARIO US) { CON.SaberQueUsuarioEsElEncargado(EREG, US); }
        public void ObtenerInsumosdelReportedeEncargo(REPORTEENCARGADOS EREG) { CON.ObtenerInsumosdelReportedeEncargo(EREG); }
        public void SaberQueUsuarioEsElDeLaRequisicion(REQUISICION EREQ, USUARIO US) { CON.SaberQueUsuarioEsElDeLaRequisicion(EREQ, US); }
        public void ObtenerInsumosdelReportedeRequisicion(REQUISICION EREQ) { CON.ObtenerInsumosdelReportedeRequisicion(EREQ); }
        public void RespaldoBD(String st) { CON.RespaldoBD(st); }
        public void RestaurarBD(String st) { CON.RestaurarBD(st); }
    }
}
