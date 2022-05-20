using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using CENTIDAD;
namespace CDATOS
{
    public class CONEXION
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public void conectar()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=ALMACENMACRO;Integrated Security=True");
                con.Open();
            }
            catch (Exception m)
            {
                MessageBox.Show("No se conectó a la base de datos: " + m.ToString());
            }
        }
        public void desconectar()
        {
            con.Close();
        }
        public void CrearRequisicion(REQUISICION EREQ)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "NuevaRequisicion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(EREQ.NoEconomico)));
            cmd.Parameters.Add(new SqlParameter("@Fecha", (EREQ.FechaRequisicion)));
            cmd.Parameters.Add(new SqlParameter("@a", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            EREQ.NoRequisicion = Convert.ToInt32(cmd.Parameters["@a"].Value);
        }
        public void RegistrarInsumoRequisicion(REQUISICION EREQ)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "InsertarInsumosRequisicion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Cantidad", EREQ.CantidadInsumo));
            cmd.Parameters.Add(new SqlParameter("@Insumo", EREQ.Insumo));
            cmd.Parameters.Add(new SqlParameter("@Caracteristicas", EREQ.Caracteristica));
            cmd.Parameters.Add(new SqlParameter("@Ubicacion", EREQ.Ubicacion));
            cmd.Parameters.Add(new SqlParameter("@ID_Requisicion", EREQ.NoRequisicion));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }

        public bool RegistrarUsuario(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "RegistrarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(US.NoEconomico)));
            cmd.Parameters.Add(new SqlParameter("@UNombre", US.Nombre));
            cmd.Parameters.Add(new SqlParameter("@Puesto", US.Puesto));
            cmd.Parameters.Add(new SqlParameter("@Curp", US.CURP));
            cmd.Parameters.Add(new SqlParameter("@Correo", US.Correo));
            cmd.Parameters.Add(new SqlParameter("@Contraseña", US.Contraseña));
            cmd.Parameters.Add(new SqlParameter("@Activo", 1));
            cmd.Parameters.Add(new SqlParameter("@Privilegio", US.Privilegio));
            cmd.ExecuteNonQuery();
            this.desconectar();
            return true;
        }
        public bool RegistrarUsuarioMaestro(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "RegistrarUsuarioMaestro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(US.NoEconomico)));
            cmd.Parameters.Add(new SqlParameter("@Nombre", US.Nombre));
            cmd.Parameters.Add(new SqlParameter("@Puesto", US.Puesto));
            cmd.Parameters.Add(new SqlParameter("@Curp", US.CURP));
            cmd.Parameters.Add(new SqlParameter("@Correo", US.Correo));
            cmd.Parameters.Add(new SqlParameter("@Contraseña", US.Contraseña));
            cmd.ExecuteNonQuery();
            this.desconectar();
            return true;
        }
        public bool NoEconomicoExistente(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "NoEconomicoExistente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(US.NoEconomico)));
            cmd.Parameters.Add(new SqlParameter("@resultado2", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            int documentoId = Convert.ToInt32(cmd.Parameters["@resultado2"].Value);
            if (documentoId == 0)
                return false;
            else
                return true;
        }
        public bool CorreoExistente(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "CorreoExistente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Correo", (US.Correo)));
            cmd.Parameters.Add(new SqlParameter("@resultado2", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            int documentoId = Convert.ToInt32(cmd.Parameters["@resultado2"].Value);
            if (documentoId == 0)
                return false;
            else
                return true;
        }
        public void Consulta(INSUMO IN, DataGridView DG)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ConsultarInsumoUTMN", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter para = new SqlParameter("@ID", SqlDbType.VarChar);
            para.Value = IN.ID;
            SqlParameter param = new SqlParameter("@Encargado", SqlDbType.VarChar);
            param.Value = IN.Encargado;
            SqlParameter param2 = new SqlParameter("@Ubicacion", SqlDbType.VarChar);
            param2.Value = IN.Ubicación;
            SqlParameter param3 = new SqlParameter("@Tipo", SqlDbType.VarChar);
            param3.Value = IN.Tipo;
            SqlParameter param4 = new SqlParameter("@Modelo", SqlDbType.VarChar);
            param4.Value = IN.Modelo;
            SqlParameter param5 = new SqlParameter("@NoSerie", SqlDbType.VarChar);
            param5.Value = IN.NoSerie;
            SqlParameter param6 = new SqlParameter("@Descripcion", SqlDbType.VarChar);
            param6.Value = IN.Descripcion;
            SqlParameter param7 = new SqlParameter("@Informacion", SqlDbType.VarChar);
            param7.Value = IN.Informacion;
            SqlParameter param8 = new SqlParameter("@Activo", SqlDbType.Int);
            param8.Value = IN.Activo;
            command.Parameters.Add(para);
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
            command.Parameters.Add(param7);
            command.Parameters.Add(param8);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DG.DataSource = dt;
            this.desconectar();
        }
        public void ConsultaP(INSUMO IN, DataGridView DG)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ConsultarInsumoP", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@PrecioI", SqlDbType.Money);
            param.Value = IN.Precio;
            SqlParameter param2 = new SqlParameter("@PrecioF", SqlDbType.Money);
            param2.Value = IN.PrecioH;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DG.DataSource = dt;
            this.desconectar();
        }
        public bool RegistroInsumo(INSUMO IN)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "RegistrarInsumo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Descripcion", IN.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Ubicacion", IN.Ubicación));
            cmd.Parameters.Add(new SqlParameter("@Tipo", IN.Tipo));
            cmd.Parameters.Add(new SqlParameter("@NoEconomico","0"));
            cmd.Parameters.Add(new SqlParameter("@Informacion", IN.Informacion));
            cmd.Parameters.Add(new SqlParameter("@No_serie", IN.NoSerie));
            cmd.Parameters.Add(new SqlParameter("@Modelo", IN.Modelo));
            cmd.Parameters.Add(new SqlParameter("@Precio", Convert.ToDouble(IN.Precio)));
            cmd.Parameters.Add(new SqlParameter("@FechaRegistro", IN.FechaRegistro));
            cmd.ExecuteNonQuery();
            this.desconectar();
            return true;
        }
        public bool SaberSiExisteUsuarioMaestro()
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "ExisteUsuarioMaestro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@resultado2", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            int documentoId = Convert.ToInt32(cmd.Parameters["@resultado2"].Value);
            if (documentoId == 0)
                return false;
            else
                return true;
        }
        public int Login(USUARIO EU)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "Loguin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(EU.NoEconomico)));
            cmd.Parameters.Add(new SqlParameter("@Contraseña", EU.Contraseña));
            cmd.Parameters.Add(new SqlParameter("@resultado2", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            int documentoId = Convert.ToInt32(cmd.Parameters["@resultado2"].Value);
            return documentoId;
        }
        public void MostrarTipos(ComboBox CB)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "Tipos";
            cmd.CommandType = CommandType.StoredProcedure;
            string query = cmd.CommandText.ToString();
            System.Data.DataTable midataset = new System.Data.DataTable();
            SqlDataAdapter midataadapter = new SqlDataAdapter(query, con);
            midataadapter.Fill(midataset);
            if (midataset.Rows.Count > 0)
            {
                for (int i = 0; i < midataset.Rows.Count; i++)
                {
                    CB.Items.Add(midataset.Rows[i][0].ToString().ToUpper());
                }
            }
            this.desconectar();
        }
        public void ReporteUbicacion(REPORTE ER, DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ReporUbicacion", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@FechaIn", SqlDbType.VarChar);
            param.Value = ER.FechaI;
            SqlParameter param2 = new SqlParameter("@FechaFin", SqlDbType.VarChar);
            param2.Value = ER.FechaFin;
            SqlParameter param3 = new SqlParameter("@Ubicacion", SqlDbType.VarChar);
            param3.Value = ER.Busqueda;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            ER.Datatable = dt;
            this.desconectar();
        }
        public void ReporteTipo(REPORTE ER, DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ReporTipo", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@FechaIn", SqlDbType.VarChar);
            param.Value = ER.FechaI;
            SqlParameter param2 = new SqlParameter("@FechaFin", SqlDbType.VarChar);
            param2.Value = ER.FechaFin;
            SqlParameter param3 = new SqlParameter("@Tipo", SqlDbType.VarChar);
            param3.Value = ER.Busqueda;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            ER.Datatable = dt;
            this.desconectar();
        }

        public void DatosUsuarioActivo(USUARIOACTIVO UA)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "DatosUsuarioActivo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //parametros
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(UA.NoEconomico)));
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);

            //Crear adaptador de datos
            System.Data.DataTable midataset = new System.Data.DataTable();
            //Llenar dataset
            midataadapter.Fill(midataset);
            //Asigarle el valor adecuado a las propiedades del ComboBoxa 
            if (midataset.Rows.Count > 0)
            {
                UA.Nombre = (midataset.Rows[0][0].ToString());
                UA.Puesto = (midataset.Rows[0][1].ToString());
                UA.CURP = (midataset.Rows[0][2].ToString());
            }
            //Desconectar la base de datos
            this.desconectar();
        }
        public void DatosUsuarioSeleccionado(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "DatosUsuarioSeleccionado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //parametros
            cmd.Parameters.Add(new SqlParameter("@Encargado", US.Nombre));
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);

            //Crear adaptador de datos
            System.Data.DataTable midataset = new System.Data.DataTable();
            //Llenar dataset
            midataadapter.Fill(midataset);
            //Asigarle el valor adecuado a las propiedades del ComboBoxa 
            if (midataset.Rows.Count > 0)
            {
                US.Nombre = (midataset.Rows[0][0].ToString());
                US.Puesto = (midataset.Rows[0][1].ToString());
                US.CURP = (midataset.Rows[0][2].ToString());
                US.NoEconomico= (midataset.Rows[0][3].ToString());
            }
            //Desconectar la base de datos
            this.desconectar();
        }
        public void TablaRequisiciones(REPORTE ER, DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("TablaRequisiciones", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@FechaInicio", SqlDbType.VarChar);
            param.Value = ER.FechaI;
            SqlParameter param2 = new SqlParameter("@FechaFin", SqlDbType.VarChar);
            param2.Value = ER.FechaFin;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            ER.Datatable = dt;
            this.desconectar();
        }
        public void MostrarUSuariosActivos(ComboBox CB)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "VerUsuarioRegistradosActivos";
            cmd.CommandType = CommandType.StoredProcedure;
            string query = cmd.CommandText.ToString();
            System.Data.DataTable midataset = new System.Data.DataTable();
            SqlDataAdapter midataadapter = new SqlDataAdapter(query, con);
            midataadapter.Fill(midataset);
            if (midataset.Rows.Count > 0)
            {
                for (int i = 0; i < midataset.Rows.Count; i++)
                {
                    CB.Items.Add(midataset.Rows[i][0].ToString().ToUpper());
                }
            }
            this.desconectar();
        }
        public void MostrarUSuarios(ComboBox CB)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "VerUsuarioRegistrados";
            cmd.CommandType = CommandType.StoredProcedure;
            string query = cmd.CommandText.ToString();
            System.Data.DataTable midataset = new System.Data.DataTable();
            SqlDataAdapter midataadapter = new SqlDataAdapter(query, con);
            midataadapter.Fill(midataset);
            if (midataset.Rows.Count > 0)
            {
                for (int i = 0; i < midataset.Rows.Count; i++)
                {
                    CB.Items.Add(midataset.Rows[i][0].ToString().ToUpper());
                }
            }
            this.desconectar();
        }
        public void InsumoSinResguardo(DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("VerInsumosSinResguardo", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            this.desconectar();
        }
        public void ResguardoTemporal(INSUMO EI)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "ResguardoTemporal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(EI.ID)));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }
        public void ModificarEncargado(REPORTEENCARGADOS EREG,USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "ModificarEncargado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", US.NoEconomico));
            cmd.Parameters.Add(new SqlParameter("@ID_Insumo", EREG.IDInsumo));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }
        public void NoResguardoTemporal(INSUMO EI)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "NoResguardoTemporal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(EI.ID)));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }
        public void CrearReporteEncargado(REPORTEENCARGADOS EREG)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "ReporEncargado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@FechaIn", (EREG.FechaInicio)));
            cmd.Parameters.Add(new SqlParameter("@FechaFin", (EREG.FechaFin)));
            cmd.Parameters.Add(new SqlParameter("@NomUsuario", (EREG.NombreEncargado)));
            cmd.Parameters.Add(new SqlParameter("@NoRepor", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            EREG.NoReporte = Convert.ToInt32(cmd.Parameters["@NoRepor"].Value);
        }
        public void InsertarInsumosEncargado(REPORTEENCARGADOS EREG)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "EncargadoInsumo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoRepor", (EREG.NoReporte)));
            cmd.Parameters.Add(new SqlParameter("@insumo", (EREG.IDInsumo)));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }
        public void MostrarReporteEncargado(REPORTEENCARGADOS EREG, DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ReporteEncargado", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@Encargado", SqlDbType.VarChar);
            param.Value = EREG.NombreEncargado;
            SqlParameter param2 = new SqlParameter("@FechaIn", SqlDbType.VarChar);
            param2.Value = EREG.FechaInicio;
            SqlParameter param3 = new SqlParameter("@FechaFin", SqlDbType.VarChar);
            param3.Value = EREG.FechaFin;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            EREG.Datatable = dt;
            this.desconectar();
        }
        public void EliminarInsumo(INSUMO EI)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "EliminarInsumo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ID_insumo", Convert.ToInt32((EI.ID))));
            cmd.Parameters.Add(new SqlParameter("@Activo", Convert.ToInt32((EI.Activo))));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }
        public bool ModificarInsumo(INSUMO IN)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "ModificarInsumo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ID_Insumo", Convert.ToInt32(IN.ID)));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", IN.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Ubicacion", IN.Ubicación));
            cmd.Parameters.Add(new SqlParameter("@Tipo", IN.Tipo));
            cmd.Parameters.Add(new SqlParameter("@Informacion", IN.Informacion));
            cmd.Parameters.Add(new SqlParameter("@No_serie", IN.NoSerie));
            cmd.Parameters.Add(new SqlParameter("@Modelo", IN.Modelo));
            cmd.Parameters.Add(new SqlParameter("@Precio", Convert.ToDouble(IN.Precio)));
            cmd.ExecuteNonQuery();
            this.desconectar();
            return true;
        }
        public void DatosInsumo(INSUMO EI)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "DatosInsumo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //parametros
            cmd.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(EI.ID)));
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);

            //Crear adaptador de datos
            System.Data.DataTable midataset = new System.Data.DataTable();
            //Llenar dataset
            midataadapter.Fill(midataset);
            //Asigarle el valor adecuado a las propiedades del ComboBoxa 
            if (midataset.Rows.Count > 0)
            {
                EI.Modelo = (midataset.Rows[0][0].ToString());
                EI.Tipo = (midataset.Rows[0][1].ToString());
                EI.Ubicación = (midataset.Rows[0][2].ToString());
                EI.Precio = (midataset.Rows[0][3].ToString());
                EI.NoSerie = (midataset.Rows[0][4].ToString());
                EI.Descripcion = (midataset.Rows[0][5].ToString());
                EI.Informacion = (midataset.Rows[0][6].ToString());
            }
            //Desconectar la base de datos
            this.desconectar();
        }
        public void RecuperarContraseña(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "Recuperar_Contraseña";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //parametros
            cmd.Parameters.Add(new SqlParameter("@Correo",US.Correo));
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);

            //Crear adaptador de datos
            System.Data.DataTable midataset = new System.Data.DataTable();
            //Llenar dataset
            midataadapter.Fill(midataset);
            //Asigarle el valor adecuado a las propiedades del ComboBoxa 
            if (midataset.Rows.Count > 0)
            {
                US.NoEconomico = (midataset.Rows[0][0].ToString());
                US.Contraseña = (midataset.Rows[0][1].ToString());
            }
            //Desconectar la base de datos
            this.desconectar();
        }

        public void MostrarUsuariosRegistrados(USUARIO US,DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("MostrarUsuarios", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@NoEconomico", SqlDbType.VarChar);
            param.Value = US.NoEconomico;
            SqlParameter param2 = new SqlParameter("@Nombre", SqlDbType.VarChar);
            param2.Value = US.Nombre;
            SqlParameter param3 = new SqlParameter("@puesto", SqlDbType.VarChar);
            param3.Value = US.Puesto;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            US.Datatable = dt;
            this.desconectar();
        }
        public void EliminarUsuario(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "EliminarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ID_Usuario", US.NoEconomico));
            cmd.Parameters.Add(new SqlParameter("@Activo", US.Activo));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }
        public void DatosUsuarioTodo(USUARIO UA)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "DatosUsuarioTodo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //parametros
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(UA.NoEconomico)));
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);

            //Crear adaptador de datos
            System.Data.DataTable midataset = new System.Data.DataTable();
            //Llenar dataset
            midataadapter.Fill(midataset);
            //Asigarle el valor adecuado a las propiedades del ComboBoxa 
            if (midataset.Rows.Count > 0)
            {
                UA.Nombre = (midataset.Rows[0][0].ToString());
                UA.Puesto = (midataset.Rows[0][1].ToString());
                UA.CURP = (midataset.Rows[0][2].ToString());
                UA.Correo = (midataset.Rows[0][3].ToString());
                UA.Contraseña= (midataset.Rows[0][4].ToString());
                UA.Privilegio = (midataset.Rows[0][5].ToString());
                UA.Maestro = Convert.ToInt32((midataset.Rows[0][6].ToString()));
            }
            //Desconectar la base de datos
            this.desconectar();
        }
        public void DatosUsuarioMaestro(USUARIOMAESTRO UA)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "DatosUsuarioMaestro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;


            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);
            //Crear adaptador de datos
            System.Data.DataTable midataset = new System.Data.DataTable();
            //Llenar dataset
            midataadapter.Fill(midataset);
            //Asigarle el valor adecuado a las propiedades del ComboBoxa 
            if (midataset.Rows.Count > 0)
            {
                UA.NoEconomico = (midataset.Rows[0][0].ToString());
                UA.Nombre = (midataset.Rows[0][1].ToString());
                UA.Puesto = (midataset.Rows[0][2].ToString());
                UA.CURP = (midataset.Rows[0][3].ToString());
                UA.Correo = (midataset.Rows[0][4].ToString());
                UA.Contraseña = (midataset.Rows[0][5].ToString());
                UA.Activo = Convert.ToInt32((midataset.Rows[0][6].ToString()));
                UA.Privilegio = (midataset.Rows[0][7].ToString());
                UA.Maestro = Convert.ToInt32((midataset.Rows[0][8].ToString()));
            }
            //Desconectar la base de datos
            this.desconectar();
        }
        public void DatosUsuarioTodo(USUARIOACTIVO UA)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "DatosUsuarioTodo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //parametros
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(UA.NoEconomico)));
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);

            //Crear adaptador de datos
            System.Data.DataTable midataset = new System.Data.DataTable();
            //Llenar dataset
            midataadapter.Fill(midataset);
            //Asigarle el valor adecuado a las propiedades del ComboBoxa 
            if (midataset.Rows.Count > 0)
            {
                UA.Nombre = (midataset.Rows[0][0].ToString());
                UA.Puesto = (midataset.Rows[0][1].ToString());
                UA.CURP = (midataset.Rows[0][2].ToString());
                UA.Correo = (midataset.Rows[0][3].ToString());
                UA.Contraseña = (midataset.Rows[0][4].ToString());
                string[]sp = (midataset.Rows[0][5].ToString()).Split(' ');
                int[] privilegios = Array.ConvertAll(sp, int.Parse);
                UA.Privilegio = privilegios;
                UA.Maestro = Convert.ToInt32((midataset.Rows[0][6].ToString()));
            }
            //Desconectar la base de datos
            this.desconectar();
        }
        public void ModificarUsuario(USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "ModificarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", Convert.ToInt32(US.NoEconomico)));
            cmd.Parameters.Add(new SqlParameter("@NuevoNumeroEconomico", Convert.ToInt32(US.NuevoNoEconomico)));
            cmd.Parameters.Add(new SqlParameter("@UNombre", US.Nombre));
            cmd.Parameters.Add(new SqlParameter("@Puesto", US.Puesto));
            cmd.Parameters.Add(new SqlParameter("@Curp", US.CURP));
            cmd.Parameters.Add(new SqlParameter("@Correo", US.Correo));
            cmd.Parameters.Add(new SqlParameter("@Contraseña", US.Contraseña));
            cmd.Parameters.Add(new SqlParameter("@Privilegio", US.Privilegio));
            cmd.ExecuteNonQuery();
            this.desconectar();
        }
        public void ConsultarReporteRequisicion(REQUISICION EREQ, DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ConsultarReporteRequisicion", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@ID", SqlDbType.VarChar);
            param.Value = EREQ.NoDReporte;
            SqlParameter param2 = new SqlParameter("@Encargado", SqlDbType.VarChar);
            param2.Value = EREQ.Encargado;
            SqlParameter param3 = new SqlParameter("@FechaI", SqlDbType.VarChar);
            param3.Value = EREQ.FechaRequisicion;
            SqlParameter param4 = new SqlParameter("@FechaF", SqlDbType.VarChar);
            param4.Value = EREQ.FechaRequisicionFin;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            EREQ.Datatable = dt;
            this.desconectar();
        }
        public void ConsultarReporteEncargos(REPORTEENCARGADOS EREQ, DataGridView DT)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ConsultarReporteEncargados", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter param = new SqlParameter("@ID", SqlDbType.VarChar);
            param.Value = EREQ.NoDReporte;
            SqlParameter param2 = new SqlParameter("@Encargado", SqlDbType.VarChar);
            param2.Value = EREQ.NombreEncargado;
            SqlParameter param3 = new SqlParameter("@FechaI", SqlDbType.VarChar);
            param3.Value = EREQ.FechaInicio;
            SqlParameter param4 = new SqlParameter("@FechaF", SqlDbType.VarChar);
            param4.Value = EREQ.FechaFin;
            command.Parameters.Add(param);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DT.DataSource = dt;
            EREQ.Datatable = dt;
            this.desconectar();
        }
        public void NoResguardados (NOTIFICACIÓN NT)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "NoResguardados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@count", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            NT.NoInsumos = Convert.ToInt32(cmd.Parameters["@count"].Value);
        }
        public void CambiarFechaInsumos(NOTIFICACIÓN NT)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "CambiarFechaInsumos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Fecha",DateTime.Now.Date.ToString()));
            cmd.Parameters.Add(new SqlParameter("@count", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.desconectar();
            NT.NoInsumosCambiados = Convert.ToInt32(cmd.Parameters["@count"].Value);
        }
        public void SaberQueUsuarioEsElEncargado(REPORTEENCARGADOS EREG,USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "SaberQueUsuarioEsElEncargado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ID_Reporte", EREG.NoReporte));
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            US.NoEconomico = cmd.Parameters["@NoEconomico"].Value.ToString();
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);
            System.Data.DataTable midataset = new System.Data.DataTable();
            midataadapter.Fill(midataset);
            if (midataset.Rows.Count > 0)
            {
                EREG.FechaInicio = (midataset.Rows[0][0].ToString());
                EREG.FechaFin = (midataset.Rows[0][1].ToString());
            }
            this.desconectar();
        }
        public void SaberQueUsuarioEsElDeLaRequisicion(REQUISICION EREQ, USUARIO US)
        {
            this.conectar();
            cmd = new SqlCommand();
            cmd.CommandText = "SaberQueUsuarioEsElDeLaRequisicion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@ID_Requisicion", EREQ.NoRequisicion));
            cmd.Parameters.Add(new SqlParameter("@NoEconomico", 0)).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            US.NoEconomico = cmd.Parameters["@NoEconomico"].Value.ToString();
            SqlDataAdapter midataadapter = new SqlDataAdapter(cmd);
            System.Data.DataTable midataset = new System.Data.DataTable();
            midataadapter.Fill(midataset);
            if (midataset.Rows.Count > 0)
            {
                EREQ.FechaRequisicion = (midataset.Rows[0][0].ToString());
            }
            this.desconectar();
        }
        public void ObtenerInsumosdelReportedeEncargo(REPORTEENCARGADOS EREG)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ObtenerInsumosdelReportedeEncargo", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter para = new SqlParameter("@ID_Reporte", SqlDbType.Int);
            para.Value = EREG.NoReporte; 
            command.Parameters.Add(para);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            EREG.Datatable = dt;
            this.desconectar();
        }
        public void ObtenerInsumosdelReportedeRequisicion(REQUISICION EREQ)
        {
            this.conectar();
            SqlCommand command = new SqlCommand("ObtenerInsumosdelReportedeRequisicion", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlParameter para = new SqlParameter("@ID_Reporte", SqlDbType.Int);
            para.Value = EREQ.NoRequisicion;
            command.Parameters.Add(para);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            EREQ.Datatable = dt;
            this.desconectar();
        }
        public void RespaldoBD(string archivo)
        {
            this.conectar();
            String database = con.Database.ToString();
            string q = "BACKUP DATABASE [" + database + "] TO DISK='" + archivo + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
            SqlCommand scmd = new SqlCommand(q, con);
            scmd.ExecuteNonQuery();
            this.desconectar();
        }
        public void RestaurarBD(string archivo)
        {
            this.conectar();
            String database = con.Database.ToString();
            string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            cmd1.ExecuteNonQuery();
            string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + archivo + "' WITH REPLACE;");
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.ExecuteNonQuery();
            string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            cmd3.ExecuteNonQuery();
            this.desconectar();
        }
        }
}
