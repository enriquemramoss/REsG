use master
go
--Drop database ALMACENMACRO
go
create database [ALMACENMACRO]
go
USE [ALMACENMACRO]
GO
/****** Object:  Table [dbo].[Insumo]    Script Date: 26/11/2018 20:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insumo](
	[Clave] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Ubicacion] [varchar](6) NOT NULL,
	[Tipo] [varchar](30) NOT NULL,
	[NoEconomico] [numeric](3, 0) NOT NULL,
	[Activo] [int] NOT NULL,
	[Informacion] [varchar](200) NOT NULL,
	[Resguardo] [numeric](1, 0) NOT NULL,
	[No_serie] [varchar](20) NOT NULL,
	[Modelo] [varchar](100) NOT NULL,
	[Precio] [float] NOT NULL,
	[FechaRegistro] [date] NOT NULL,
 CONSTRAINT [PK_Insumo] PRIMARY KEY CLUSTERED 
(
	[Clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Insumo_Req]    Script Date: 26/11/2018 20:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insumo_Req](
	[ID_Insumo_req] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [numeric](3, 0) NULL,
	[Insumo] [varchar](100) NULL,
	[Caracteristicas] [varchar](200) NULL,
	[Ubicacion] [varchar](5) NULL,
	[ID_Requisicion] [int] NULL,
 CONSTRAINT [PK1_Insumo_req] PRIMARY KEY CLUSTERED 
(
	[ID_Insumo_req] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notas]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notas](
	[Descripcion] [varchar](100) NOT NULL,
	[NoEconomico] [numeric](3, 0) NOT NULL,
 CONSTRAINT [PK_Notas] PRIMARY KEY CLUSTERED 
(
	[Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repor_Encargado_insumo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repor_Encargado_insumo](
	[ID_Insumo] [int] NOT NULL,
	[ID_Reporte] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repor_encargados]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repor_encargados](
	[ID_Reporte] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_inicio] [date] NOT NULL,
	[Fecha_fin] [date] NOT NULL,
	[NoEconomico] [numeric](3, 0) NOT NULL,
	[Activo] [int]
 CONSTRAINT [PK_Reporte] PRIMARY KEY CLUSTERED 
(
	[ID_Reporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requisicion]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requisicion](
	[ID_Requisicion] [int] IDENTITY(1,1) NOT NULL,
	[NoEconomico] [numeric](3, 0) NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_Requisicion] PRIMARY KEY CLUSTERED 
(
	[ID_Requisicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[NoEconomico] [numeric](3, 0) NOT NULL,
	[UNombre] [varchar](40) NOT NULL,
	[Puesto] [varchar](50) NOT NULL,
	[Curp] [varchar](18) NOT NULL,
	[Correo] [varchar](40) NOT NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[Activo] [numeric](1, 0) NULL,
	[Privilegio] [varchar](30) NOT NULL,
	[Maestro] [int] not null,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[NoEconomico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Insumo]  WITH CHECK ADD  CONSTRAINT [FK2_Usuario] FOREIGN KEY([NoEconomico])
REFERENCES [dbo].[Usuario] ([NoEconomico]) ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Insumo] CHECK CONSTRAINT [FK2_Usuario]
GO
ALTER TABLE [dbo].[Insumo_Req]  WITH CHECK ADD  CONSTRAINT [FK1_Requisicion] FOREIGN KEY([ID_Requisicion])
REFERENCES [dbo].[Requisicion] ([ID_Requisicion])
GO
ALTER TABLE [dbo].[Insumo_Req] CHECK CONSTRAINT [FK1_Requisicion]
GO
ALTER TABLE [dbo].[Notas]  WITH CHECK ADD  CONSTRAINT [FK1_Notas] FOREIGN KEY([NoEconomico])
REFERENCES [dbo].[Usuario] ([NoEconomico]) ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Notas] CHECK CONSTRAINT [FK1_Notas]
GO
ALTER TABLE [dbo].[Repor_Encargado_insumo]  WITH CHECK ADD  CONSTRAINT [FK1_Reporte] FOREIGN KEY([ID_Reporte])
REFERENCES [dbo].[Repor_encargados] ([ID_Reporte])
GO
ALTER TABLE [dbo].[Repor_Encargado_insumo] CHECK CONSTRAINT [FK1_Reporte]
GO
ALTER TABLE [dbo].[Repor_Encargado_insumo]  WITH CHECK ADD  CONSTRAINT [FK2_REIInsumo] FOREIGN KEY([ID_Insumo])
REFERENCES [dbo].[Insumo] ([Clave])
GO
ALTER TABLE [dbo].[Repor_Encargado_insumo] CHECK CONSTRAINT [FK2_REIInsumo]
GO
ALTER TABLE [dbo].[Repor_encargados]  WITH CHECK ADD  CONSTRAINT [FK1_Usuario] FOREIGN KEY([NoEconomico])
REFERENCES [dbo].[Usuario] ([NoEconomico]) ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Repor_encargados] CHECK CONSTRAINT [FK1_Usuario]
GO
ALTER TABLE [dbo].[Requisicion]  WITH CHECK ADD  CONSTRAINT [FK1_UsuarioR] FOREIGN KEY([NoEconomico])
REFERENCES [dbo].[Usuario] ([NoEconomico]) ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Requisicion] CHECK CONSTRAINT [FK1_UsuarioR]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarInsumoE]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
go

GO
   create procedure [dbo].[ConsultarInsumoE]
   @Encargado varchar
   as
   select Ubicacion as Ubicación,Tipo,Precio,Modelo,No_serie as 'No.Serie'
   From Insumo I
GO
/****** Object:  StoredProcedure [dbo].[ConsultarInsumoP]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[ConsultarInsumoUTMN]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create procedure [dbo].[ConsultarInsumoUTMN]
   @ID varchar (10),
   @Encargado varchar(40),
   @Ubicacion varchar(6),
   @Tipo      varchar(30),
   @Modelo varchar(100),
   @NoSerie varchar(20),
   @Descripcion varchar(100),
   @Informacion varchar(200),
   @Activo      int
   as
   if (@Activo=1 or @Activo=0)
   select  Clave as 'ID Insumo',Unombre as Encargado,Ubicacion as Ubicación,Tipo,Precio,Modelo,No_serie as 'No.Serie',Descripcion as Descripción, Informacion as Información
   ,Case
   When I.Activo=1 Then 'Activo'
   When I.Activo=0 Then 'Eliminado' end "Activo"
   From Insumo I, Usuario U
   Where  
   CAST(I.Clave AS VARCHAR(10)) like('%'+@ID+'%') and U.NoEconomico=I.NoEconomico and (I.Ubicacion like ('%'+@Ubicacion + '%') and I.Tipo like ('%'+@Tipo + '%') and I.Modelo like ('%'+@Modelo + '%') and I.No_serie like ('%'+@NoSerie + '%')
   and I.Descripcion like ('%'+@Descripcion + '%') and I.Informacion like ('%'+@Informacion + '%') and U.UNombre like ('%'+@Encargado + '%')) and I.Activo=@Activo
   ;
   else
    select  Clave as 'ID Insumo',Unombre as Encargado,Ubicacion as Ubicación,Tipo,Precio,Modelo,No_serie as 'No.Serie',Descripcion as Descripción, Informacion as Información
   ,Case
   When I.Activo=1 Then 'Activo'
   When I.Activo=0 Then 'Eliminado' end "Activo"
   From Insumo I, Usuario U
   Where  
   CAST(I.Clave AS VARCHAR(10)) like ('%'+@ID+'%') and U.NoEconomico=I.NoEconomico and (I.Ubicacion like ('%'+@Ubicacion + '%') and I.Tipo like ('%'+@Tipo + '%') and I.Modelo like ('%'+@Modelo + '%') and I.No_serie like ('%'+@NoSerie + '%')
   and I.Descripcion like ('%'+@Descripcion + '%') and I.Informacion like ('%'+@Informacion + '%') and U.UNombre like ('%'+@Encargado + '%'))
   ;
GO
create procedure [dbo].[ConsultarReporteRequisicion]
   @ID varchar (10),
   @Encargado varchar(40),
   @FechaI     date,
   @FechaF    date
   as
   Select ID_Requisicion as ID, UNombre as Encargado,Fecha as 'Fecha de Registro'
   From Requisicion R,Usuario U
   Where CAST(R.ID_Requisicion AS VARCHAR(10)) like ('%'+@ID+'%') and UNombre like ('%'+@Encargado+'%') and Fecha >=@FechaI and Fecha <=@FechaF
   and R.NoEconomico = U.NoEconomico
GO
create procedure [dbo].[ConsultarReporteEncargados]
   @ID varchar (10),
   @Encargado varchar(40),
   @FechaI     date,
   @FechaF    date
   as
   Select ID_Reporte as ID, UNombre as Encargado,Fecha_inicio as 'Fecha de Registro',Fecha_fin as 'Fecha de Fin'
      ,Case
   When R.Activo=1 Then 'En Proceso'
   When R.Activo=0 Then 'Terminada' end "Activa"
   From Repor_encargados R,Usuario U
   Where CAST(R.ID_Reporte AS VARCHAR(10)) like ('%'+@ID+'%') and UNombre like ('%'+@Encargado+'%') and Fecha_inicio >=@FechaI and Fecha_inicio<=@FechaF
   and U.NoEconomico=R.NoEconomico
GO

--exec ConsultarInsumoUTMN '','','','','','','','','2'
/****** Object:  StoredProcedure [dbo].[CorreoExistente]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create procedure [dbo].[CorreoExistente]
   @Correo	varchar(40),
   @resultado2 int output 
   as
   select @resultado2=Count (Correo)
   from Usuario
   where @Correo=Correo
   return @resultado2
GO
/****** Object:  StoredProcedure [dbo].[DatosInsumo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[DatosInsumo]
   @ID int
   as
   select  Modelo,Tipo,Ubicacion,Precio,No_serie,Descripcion,Informacion
   From Insumo I
   Where @ID = Clave
GO
/****** Object:  StoredProcedure [dbo].[DatosUsuarioActivo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   Create procedure [dbo].[DatosUsuarioActivo]
   @NoEconomico numeric(8)
   as
   select UNombre,Puesto,Curp
   From Usuario
   Where @NoEconomico=NoEconomico
   go
   --Exec DatosUsuarioActivo'138'

GO
/****** Object:  StoredProcedure [dbo].[DatosUsuarioSeleccionado]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DatosUsuarioSeleccionado]
  @Encargado varchar (100)
  as
  	select UNombre,Puesto,Curp,NoEconomico
	from Usuario
	where UNombre=@Encargado
GO
/****** Object:  StoredProcedure [dbo].[DatosUsuarioTodo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create procedure [dbo].[DatosUsuarioTodo]
   @NoEconomico numeric(8)
   as
   select UNombre,Puesto,Curp,Correo,Contraseña,Privilegio,Maestro
   From Usuario
   Where @NoEconomico=NoEconomico
GO
 create proc [dbo].[DatosUsuarioMaestro]
  as
  select *
  From Usuario
  Where Maestro = 1
GO
/****** Object:  StoredProcedure [dbo].[EliminarInsumo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarInsumo]
@ID_insumo int,
@Activo int
  as
  update Insumo
  set Activo=@Activo
  where @ID_insumo=Clave
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EliminarUsuario]
	@ID_Usuario numeric(8),
	@Activo int
AS
			UPDATE Usuario
            SET Activo = @Activo
            WHERE @ID_Usuario=NoEconomico
GO
/****** Object:  StoredProcedure [dbo].[EncargadoInsumo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EncargadoInsumo]
	@NoRepor	int,
	@insumo		int
as
	insert into Repor_Encargado_insumo values
	(@insumo,@NoRepor)
GO
/****** Object:  StoredProcedure [dbo].[ExisteUsuarioMaestro]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   --U.UNombre like @Encargado + '%' and U.NoEconomico=I.NoEconomico and
   create procedure [dbo].[ExisteUsuarioMaestro]
   @resultado2 int output 
   as
   select @resultado2=Count (Privilegio)
   from Usuario
   where Privilegio='1 1 1 1 1 1 1 1 1 1 1'
   return @resultado2
GO
/****** Object:  StoredProcedure [dbo].[InsertarInsumosRequisicion]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create procedure [dbo].[InsertarInsumosRequisicion]
    @Cantidad			numeric(3),
	@Insumo				varchar(100),
	@Caracteristicas		varchar(200),
	@Ubicacion			varchar(5),
	@ID_Requisicion		int
   as
   insert  into Insumo_Req (Cantidad,Insumo,Caracteristicas,Ubicacion,ID_Requisicion) values (@Cantidad,@Insumo,@Caracteristicas,@Ubicacion,@ID_Requisicion)
GO
/****** Object:  StoredProcedure [dbo].[Loguin]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   --Exec RegistrarUsuarioMaestro();
create procedure [dbo].[Loguin]
@NoEconomico numeric(3),
@Contraseña varchar(100),
@resultado2 int output
as
if((SELECT count(NoEconomico) FROM Usuario U WHERE U.NoEconomico=@NoEconomico and U.Contraseña=@Contraseña and Activo=1)=1)
select @resultado2=1;
else 
select @resultado2=0;
GO
/****** Object:  StoredProcedure [dbo].[ModificarEncargado]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarEncargado]
 @NoEconomico numeric(3),
 @ID_Insumo int
  as
  Update Insumo
  Set NoEconomico=@NoEconomico
  Where @ID_Insumo=Clave
GO
/****** Object:  StoredProcedure [dbo].[ModificarInsumo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarInsumo]
    @ID_Insumo          int,
	@Descripcion		varchar(100),
	@Ubicacion		varchar(6),
	@Tipo			varchar(30),
	@Informacion		varchar(200),
	@No_serie		varchar(20),
	@Modelo			varchar(100),
	@Precio			float
  as
  update Insumo
  set Descripcion=@Descripcion, Ubicacion = @Ubicacion, Tipo = @Tipo,Informacion=@Informacion,No_serie=@No_serie,Modelo = @Modelo,Precio=@Precio
  where Clave=@ID_Insumo
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarUsuario]
    @NoEconomico numeric(3),
	@NuevoNumeroEconomico numeric(3),
	@UNombre varchar(40) ,
	@Puesto varchar(50) ,
	@Curp varchar(18) ,
	@Correo varchar(40),
	@Contraseña varchar(100),
	@Privilegio varchar(30) 
  as
  update Usuario
  set NoEconomico=@NoEconomico,UNombre=@UNombre,Puesto=@Puesto,Curp=@Curp,Correo=@Correo,Contraseña=@Contraseña,Privilegio=@Privilegio
  where NoEconomico=@NuevoNumeroEconomico
GO
-- exec ModificarUsuario '138','159','Luis Fernando','Jefe PRo','RASE961125HBSMNB00','kikin_9.20@hotmail.com','1234','1 1 1 1 1 1 1 1 1 1 1'
/****** Object:  StoredProcedure [dbo].[MostrarUsuarios]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[MostrarUsuarios]
@NoEconomico varchar (3),
@Nombre varchar(40),
@puesto varchar(50)
AS
			select NoEconomico,UNombre,Puesto,Curp,Correo
			,Case
            When Maestro=1 Then 'MASTER'
            When Maestro=0 Then 'USUARIO' end "Nivel"
			,Case
            When Activo=1 Then 'ACTIVO'
            When Activo=0 Then 'ELIMINADO' end "Estatus"
			from Usuario
			where CAST(NoEconomico AS VARCHAR(3)) like('%'+@NoEconomico+'%') and UNombre like ('%'+@Nombre + '%')and Puesto like '%'+@puesto + '%' and Activo != 3
GO
exec MostrarUsuarios '','',''
/****** Object:  StoredProcedure [dbo].[NoEconomicoExistente]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NoEconomicoExistente]
   @NoEconomico	numeric(3),
   @resultado2 int output 
   as
   select @resultado2=Count (NoEconomico)
   from Usuario
   where  @NoEconomico=NoEconomico
   return @resultado2
GO
/****** Object:  StoredProcedure [dbo].[NoResguardoTemporal]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NoResguardoTemporal]
	@ID	int
as
	update Insumo
	set Resguardo=0
	where Clave=@ID
GO
/****** Object:  StoredProcedure [dbo].[NuevaRequisicion]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   CREATE procedure [dbo].[NuevaRequisicion]
   @NoEconomico		numeric(3),
   @Fecha			date,
   @a               int out
   as
   insert  into Requisicion (NoEconomico,Fecha) values (@NoEconomico,@Fecha)
   select @a = scope_identity()
GO
/****** Object:  StoredProcedure [dbo].[Recuperar_Contraseña]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Recuperar_Contraseña]
@Correo[varchar](40)
AS
				Select NoEconomico,Contraseña
				FROM Usuario
				Where @Correo=Correo and Activo=1
GO
/****** Object:  StoredProcedure [dbo].[RegistrarInsumo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec EliminarUsuario 15310672

create procedure [dbo].[RegistrarInsumo]
	@Descripcion		varchar(100),
	@Ubicacion		varchar(6),
	@Tipo			varchar(30),
	@NoEconomico	numeric(3),
	@Informacion		varchar(200),
	@No_serie		varchar(20),
	@Modelo			varchar(100),
	@Precio			float,
	@FechaRegistro   date
as
	 insert into Insumo (Descripcion,Ubicacion,Tipo,NoEconomico,Activo,Informacion,Resguardo,No_serie,Modelo,Precio,FechaRegistro) values 
	 (@Descripcion,@Ubicacion,@Tipo,@NoEconomico,1,@Informacion,0,@No_serie,@Modelo,@Precio,@FechaRegistro)
GO
/****** Object:  StoredProcedure [dbo].[RegistrarUsuario]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RegistrarUsuario]
   @NoEconomico	numeric(3),
   @UNombre	  varchar(40),
   @Puesto		varchar(50),
   @Curp		varchar(18),
   @Correo		varchar(40),
   @Contraseña	varchar(100),
   @Activo      int,
   @Privilegio varchar(30)
   as
	   insert into Usuario values
	   (@NoEconomico,@UNombre,@Puesto,@Curp,@Correo,@Contraseña,@Activo,@Privilegio,0)
GO
exec RegistrarUsuario '0','Sin resguardo',' ',' ',' ',' ',3,' '
GO
/****** Object:  StoredProcedure [dbo].[RegistrarUsuarioMaestro]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create procedure [dbo].[RegistrarUsuarioMaestro]
   @Noeconomico	numeric(3),
   @Nombre      varchar(40),
   @Puesto		varchar(50),
   @Curp		varchar(18),
   @Correo		varchar(40),
   @Contraseña	varchar(100)
   as
	   insert into Usuario values
	   (@NoEconomico,@Nombre,@Puesto,@Curp,@Correo,@Contraseña,1,'1 1 1 1 1 1 1 1 1 1 1',1)
GO
/****** Object:  StoredProcedure [dbo].[ReporEncargado]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ReporEncargado]
	@FechaIn	date,
	@FechaFin	Date,
	@NomUsuario	varchar(100),
	@NoRepor	int output
as
	declare @NoEconomico	numeric(3)
	select @NoEconomico=NoEconomico
	from Usuario
	where @NomUsuario=UNombre
	insert into Repor_encargados values
	(@FechaIn,@FechaFin,@NoEconomico,1)
	select @NoRepor=@@identity
GO
/****** Object:  StoredProcedure [dbo].[ReporteEncargado]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure SaberQueUsuarioEsElEncargado
@ID_Reporte int,
@NoEconomico numeric(3) output
as
Select @NoEconomico=U.NoEconomico
From Usuario U,Repor_encargados RE
Where @ID_Reporte=RE.ID_Reporte and U.NoEconomico=RE.NoEconomico

Select Fecha_inicio,Fecha_fin
From Usuario U,Repor_encargados RE
Where @ID_Reporte=RE.ID_Reporte and U.NoEconomico=RE.NoEconomico
go


create procedure SaberQueUsuarioEsElDeLaRequisicion
@ID_Requisicion int,
@NoEconomico numeric(3) output
as
Select @NoEconomico=U.NoEconomico
From Usuario U,Requisicion R
Where @ID_Requisicion=R.ID_Requisicion and U.NoEconomico=R.NoEconomico

Select R.Fecha
From Usuario U,Requisicion R
Where R.ID_Requisicion=@ID_Requisicion and U.NoEconomico=R.NoEconomico
go


go
exec SaberQueUsuarioEsElEncargado '6','138'
go
go
create procedure ObtenerInsumosdelReportedeEncargo
@ID_Reporte int
as
Select I.No_Serie as 'Número de Serie',I.Descripcion as Descripción,I.Modelo as Modelo,Precio as 'Precio Unitario'
From Insumo I,Repor_encargados RE, Repor_Encargado_insumo REI
Where @ID_Reporte = RE.ID_Reporte and RE.ID_Reporte=REI.ID_Reporte and I.Clave=REI.ID_Insumo
Go
create procedure ObtenerInsumosdelReportedeRequisicion
@ID_Reporte int
as
Select Cantidad as 'Cantidad Insumo',Insumo,Caracteristicas as Característica,Ubicacion as 'Ubicación Destino'
From Requisicion R, Insumo_Req IR
Where @ID_Reporte = R.ID_Requisicion and R.ID_Requisicion=IR.ID_Insumo_req
Go
create procedure [dbo].[ReporteEncargado]
	@Encargado	varchar(100),
	@FechaIn	date,
	@FechaFin	Date
as
	declare @NoEconomico	numeric(3)
	select @NoEconomico=NoEconomico
	from Usuario
	where UNombre=@Encargado

	select distinct tipo as 'Insumo',No_serie,Descripcion as Descripción,Modelo,Fecha_inicio as 'Fecha Inicio',Fecha_fin as 'Fecha Fin', Ubicacion as Ubicación
	from Repor_encargados RE,Insumo I,Repor_Encargado_insumo REI
	where @NoEconomico=RE.NoEconomico and Fecha_inicio>=@FechaIn and Fecha_inicio<=@FechaFin 
	and I.Clave=REI.ID_Insumo and RE.Activo=1
GO
/****** Object:  StoredProcedure [dbo].[ReporTipo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ReporTipo]
	@FechaIn	date,
	@FechaFin	date,
	@Tipo		varchar(30)
as
	select No_serie as'No. Serie',Descripcion as Descripción,Modelo,FechaRegistro as 'Fecha de Registro',Ubicacion as Ubicación,UNombre as 'Encargado'
	from Insumo,Usuario
	where FechaRegistro>=@FechaIn and FechaRegistro<=@FechaFin and
	Insumo.NoEconomico=Usuario.NoEconomico and Tipo=@Tipo and Insumo.Activo=1
GO
/****** Object:  StoredProcedure [dbo].[ReporUbicacion]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   
create procedure [dbo].[ReporUbicacion]
	@FechaIn	date,
	@FechaFin	date,
	@Ubicacion	varchar(5)
as
	select No_serie as'No.Serie',Descripcion as 'Descripción',Modelo,FechaRegistro as 'Fecha de Registro',UNombre as 'Encargado'
	from Insumo,Usuario
	where FechaRegistro>@FechaIn and FechaRegistro<@FechaFin and
	Insumo.NoEconomico=Usuario.NoEconomico and Ubicacion=@Ubicacion and Insumo.Activo=1 
GO
/****** Object:  StoredProcedure [dbo].[ResguardoTemporal]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ResguardoTemporal]
	@ID	int
as
	update Insumo
	set Resguardo=1
	where Clave=@ID
GO
/****** Object:  StoredProcedure [dbo].[TablaRequisiciones]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   CREATE procedure [dbo].[TablaRequisiciones]
   @FechaInicio date,
   @FechaFin date
   as
   Select R.ID_Requisicion as 'No. Solicitud', UNombre as Usuario,Puesto,Insumo as Insumo, Cantidad,R.Fecha as 'Fecha solicitud'
   From Requisicion R,Insumo_Req I, Usuario U
   where R.NoEconomico=U.NoEconomico and R.ID_Requisicion = I.ID_Requisicion and R.Fecha>=@FechaInicio and R.Fecha<=@FechaFin
GO
/****** Object:  StoredProcedure [dbo].[Tipos]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

   create procedure [dbo].[Tipos]
   as
   Select distinct Tipo
   From Insumo
GO
/****** Object:  StoredProcedure [dbo].[VerInsumosSinResguardo]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VerInsumosSinResguardo]
as
	select clave as 'ID Insumo',Descripcion as 'Descripción',Ubicacion as Ubicación,Tipo,Informacion,No_serie as 'No. Serie',Modelo,Precio,FechaRegistro as 'Fecha de registro'
	from Insumo
	where Resguardo=0 And Activo=1
GO
/****** Object:  StoredProcedure [dbo].[VerUsuarioRegistrados]    Script Date: 26/11/2018 20:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VerUsuarioRegistradosActivos]
  as
  select UNombre
  from Usuario
  Where Activo=1
GO

create procedure [dbo].[VerUsuarioRegistrados]
  as
  select UNombre
  from Usuario
  Where Activo != 3
GO
create procedure NoResguardados
	@count	int output
as
	select @count=count(Clave)
	from Insumo
	where Resguardo=0
go
create procedure CambiarFechaInsumos
	@Fecha	date,
	@count	int output
as
	declare @NoEconomico numeric (3)
	declare @ID_Reporte numeric (5)
	declare @ID_Insumo numeric(5)
	
	select @ID_Reporte=ID_Reporte
	from Repor_encargados
	where Fecha_fin<@Fecha and Repor_encargados.Activo=1

	select @count=count(Clave)
	from Insumo,Repor_encargados,Repor_Encargado_insumo
	where Fecha_fin<@fecha and Insumo.Clave=Repor_Encargado_insumo.ID_Insumo and Repor_Encargado_insumo.ID_Reporte=@ID_Reporte and Repor_encargados.Activo=1

	Update Insumo
	set Resguardo=0,NoEconomico=0
	from Insumo
		inner join Repor_Encargado_insumo
		on (Insumo.Clave=Repor_Encargado_insumo.ID_Insumo and Repor_Encargado_insumo.ID_Reporte=@ID_Reporte)
	
	update Repor_encargados
	set Activo=0
	where Fecha_fin<@Fecha and Activo=1
	
	if(@count=null)
	select @count=0
go
declare @pepe int
Exec CambiarFechaInsumos '2018/11/30',@pepe
Select @Pepe
SET IDENTITY_INSERT Insumo on; 
go
insert into Insumo(Clave,Descripcion,Ubicacion,Tipo,NoEconomico,Activo,Informacion,Resguardo,No_serie,Modelo,Precio,FechaRegistro) values
(1,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'14)Monitor Dell 22" Service Tag:2H95V82',0,'1512173737','3771',2500,'2018/11/15'),
(2,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'15)Monitor Dell 22" Service Tag:FR95V82',0,'1512173738','3771',2500,'2018/11/15'),
(3,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'16)Monitor Dell 22" Service Tag:DR95V82',0,'1512173739','3771',2500,'2018/11/15'),
(4,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'17)Monitor Dell 22" Service Tag:7R95V82',0,'1512173740','3771',2500,'2018/11/15'),
(5,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'18)Monitor Dell 22" Service Tag:8J95V82',0,'1512173741','3771',2500,'2018/11/15'),
(6,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'19)Monitor Dell 22" Service Tag:DH95V82',0,'1512173742','3771',2500,'2018/11/15'),
(7,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'20)Monitor Dell 22" Service Tag:BJ95V82',0,'1512173743','3771',2500,'2018/11/15'),
(8,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'21)Monitor Dell 22" Service Tag:6R95V82',0,'1512173744','3771',2500,'2018/11/15'),
(9,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'22)Monitor Dell 22" Service Tag:9595V82',0,'1512173745','3771',2500,'2018/11/15'),
(10,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'23)Monitor Dell 22" Service Tag:J185V82',0,'1512173746','3771',2500,'2018/11/15'),
(11,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'24)Monitor Dell 22" Service Tag:GH95V82',0,'1512173747','3771',2500,'2018/11/15'),
(12,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'25)Monitor Dell 22" Service Tag:4H95V82',0,'1512173748','3771',2500,'2018/11/15'),
(13,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'26)Monitor Dell 22" Service Tag:JR95V82',0,'1512173749','3771',2500,'2018/11/15'),
(14,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'27)Monitor Dell 22" Service Tag:8595V82',0,'1512173750','3771',2500,'2018/11/15'),
(15,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'28)Monitor Dell 22" Service Tag:H695V82',0,'1512173751','3771',2500,'2018/11/15'),
(16,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'29)Monitor Dell 22" Service Tag:FH95V82',0,'1512173752','3771',2500,'2018/11/15'),
(17,'DELL OPTIPLEX 3050','MCB','Monitor',0,1,'30)Monitor Dell 22" Service Tag:F695V82',0,'1512173753','3771',2500,'2018/11/15'),
(18,'COMPUT EXACTO','MCD','Computadora',0,1,'1) Computadora ServiceTag: 940399093937 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173737','3770',10781.02,'2018/11/16'),
(19,'COMPUT EXACTO','MCD','Computadora',0,1,'2) Computadora ServiceTag: 940399081796 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173738','3770',10781.02,'2018/11/16'),
(20,'COMPUT EXACTO','MCD','Computadora',0,1,'3) Computadora ServiceTag: 940399093770 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173753','3770',10781.02,'2018/11/16'),
(21,'COMPUT EXACTO','MCD','Computadora',0,1,'4) Computadora ServiceTag: 940399082326 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173739','3770',10781.02,'2018/11/16'),
(22,'COMPUT EXACTO','MCD','Computadora',0,1,'5) Computadora ServiceTag: 940399092850 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173740','3770',10781.02,'2018/11/16'),
(23,'COMPUT EXACTO','MCD','Computadora',0,1,'6) Computadora ServiceTag: 940399095903 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173741','3770',10781.02,'2018/11/16'),
(24,'COMPUT EXACTO','MCD','Computadora',0,1,'7) Computadora ServiceTag: 940399093851 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173742','3770',10781.02,'2018/11/16'),
(25,'COMPUT EXACTO','MCD','Computadora',0,1,'8) Computadora ServiceTag: 940399093335 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173743','3770',10781.02,'2018/11/16'),
(26,'COMPUT EXACTO','MCD','Computadora',0,1,'9) Computadora ServiceTag: 940399095022 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173744','3770',10781.02,'2018/11/16'),
(27,'COMPUT EXACTO','MCD','Computadora',0,1,'10) Computadora ServiceTag: 940399093926 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173745','3770',10781.02,'2018/11/16'),
(28,'COMPUT EXACTO','MCD','Computadora',0,1,'11) Computadora ServiceTag: 940399093952 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173746','3770',10781.02,'2018/11/16'),
(29,'COMPUT EXACTO','MCD','Computadora',0,1,'12) Computadora ServiceTag: 940399093795 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173747','3770',10781.02,'2018/11/16'),
(30,'COMPUT EXACTO','MCD','Computadora',0,1,'13) Computadora ServiceTag: 940399095069 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173748','3770',10781.02,'2018/11/16'),
(31,'COMPUT EXACTO','MCD','Computadora',0,1,'14) Computadora ServiceTag: 940399092307 Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173749','3770',10781.02,'2018/11/16'),
(32,'COMPUT EXACTO','MCD','Computadora',0,1,'15) Computadora ServiceTag: 94039909**** Procesador: Intel Core 7 RAM: 8.00GB Disco Duro: 500GB',0,'1412173750','3770',10781.02,'2018/11/16'),
(33,'Monitor LED AOC','MCD','Monitor',0,1,'1) Monitor LED AOC 21.5" ServiceTag: FSLE4HA071987',0,'1612173738','3772',5560,'2018/10/17'),
(34,'Monitor LED AOC','MCD','Monitor',0,1,'2) Monitor LED AOC 21.5" ServiceTag: FSLE4HA071973',0,'1612173739','3772',5560,'2018/10/17'),
(35,'Monitor LED AOC','MCD','Monitor',0,1,'3) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072176',0,'1612173740','3772',5560,'2018/10/17'),
(36,'Monitor LED AOC','MCD','Monitor',0,1,'4) Monitor LED AOC 21.5" ServiceTag: FSLE4HA071976',0,'1612173741','3772',5560,'2018/10/17'),
(37,'Monitor LED AOC','MCD','Monitor',0,1,'5) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072222',0,'1612173742','3772',5560,'2018/10/17'),
(38,'Monitor LED AOC','MCD','Monitor',0,1,'6) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072109',0,'1612173743','3772',5560,'2018/10/17'),
(39,'Monitor LED AOC','MCD','Monitor',0,1,'7) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072206',0,'1612173744','3772',5560,'2018/10/17'),
(40,'Monitor LED AOC','MCD','Monitor',0,1,'8) Monitor LED AOC 21.5" ServiceTag: FSLE4HA071953',0,'1612173745','3772',5560,'2018/10/17'),
(41,'Monitor LED AOC','MCD','Monitor',0,1,'9) Monitor LED AOC 21.5" ServiceTag: FSLE4HA078609',0,'1612173746','3772',5560,'2018/10/17'),
(42,'Monitor LED AOC','MCD','Monitor',0,1,'10) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072214',0,'1612173747','3772',5560,'2018/10/17'),
(43,'Monitor LED AOC','MCD','Monitor',0,1,'11) Monitor LED AOC 21.5" ServiceTag: FSLE4HA078625',0,'1612173748','3772',5560,'2018/10/17'),
(44,'Monitor LED AOC','MCD','Monitor',0,1,'12) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072208',0,'1612173749','3772',5560,'2015/10/17'),
(45,'Monitor LED AOC','MCD','Monitor',0,1,'13) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072212',0,'1612173750','3772',5560,'2018/10/17'),
(46,'Monitor LED AOC','MCD','Monitor',0,1,'14) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072211',0,'1612173751','3772',5560,'2018/10/17'),
(47,'Monitor LED AOC','MCD','Monitor',0,1,'15) Monitor LED AOC 21.5" ServiceTag: FSLE4HA072112',0,'1612173752','3772',5560,'2018/10/17'),
(48,'Monitor de prueba HP','MCD','Monitor',0,1,'1) Monitor HP Service Tag: MX14657986',0,'1712173737','3773',1500,'2018/10/18'),
(49,'Monitor de prueba HP','MCD','Monitor',0,1,'2) Monitor HP Service Tag: MX14660668',0,'1712173738','3773',1500,'2018/10/18'),
(50,'Monitor de prueba HP','MCD','Monitor',0,1,'3) Monitor HP Service Tag: THTGA01531',0,'1712173739','3773',1500,'2018/10/18'),
(51,'Monitor de prueba COMPAQ','MCD','Monitor',0,1,'4) Monitor Compaq Service Tag: 250CP28KC518',0,'1812173737','3774',2000,'2018/10/19'),
(52,'Monitor de prueba HP','MCD','Monitor',0,1,'5) Monitor HP Service Tag: MX15072761',0,'1712173740','3773',1500,'2018/10/18'),
(53,'Monitor de prueba COMPAQ','MCD','Monitor',0,1,'6) Monitor Compaq Service Tag: 141BM28GA206',0,'1812173738','3774',2000,'2018/10/19'),
(54,'Monitor de prueba HP','MCD','Monitor',0,1,'7) Monitor HP Service Tag: THTFV52912',0,'1712173741','3773',1500,'2018/10/18'),
(55,'Monitor de prueba COMPAQ','MCD','Monitor',0,1,'8) Monitor Compaq Service Tag: 250CP28KC494',0,'1812173739','3774',2000,'2018/10/19'),
(56,'Computadora Sin Nombre','MCD','Computadora',0,1,'1) Sin No. Serie',0,'1912173737','3775',3000,'2018/10/20'),
(57,'Computadora Sin Nombre','MCD','Computadora',0,1,'2) Sin No. Serie',0,'1912173738','3775',3000,'2018/10/20'),
(58,'Computadora Multimedia Computer System','MCD','Computadora',0,1,'3) Computadora No. Serie: 040271054',0,'2012173737','3776',8058.03,'2018/10/21'),
(59,'Computadora Compaq','MCD','Computadora',0,1,'4) Computadora No. Serie: 6X2C-KN8Z-E07C',0,'2112173737','3777',7539,'2018/10/22'),
(60,'Computadora Multimedia Computer System','MCD','Computadora',0,1,'5) Computadora No. Serie: 032647695',0,'2012173738','3776',8058.03,'2018/10/23'),
(61,'Computadora Multimedia Computer System','MCD','Computadora',0,1,'6) Computadora No. Serie:04271236',0,'2012173739','3776',8058.03,'2018/10/23'),
(62,'Computadora Compaq','MCD','Computadora',0,1,'7) Computadora No. Serie: 6X2B-KN8Z-T19M',0,'2112173738','3777',7539,'2018/10/22'),
(63,'Computadora Multimedia Computer System','MCD','Computadora',0,1,'8) Computadora No. Serie: 040271279',0,'2012173740','3776',8058.03,'2018/10/23'),
(64,'Computadora Sin Nombre','MCD','Computadora',0,1,'9) Sin No. Serie',0,'1912173739','3775',3000,'2018/10/24'),
(65,'Computadora Sin Nombre','MCD','Computadora',0,1,'10) Sin No. Serie',0,'1912173740','3775',3000,'2018/10/24'),
(66,'Computadora Sin Nombre','MCD','Computadora',0,1,'11) Sin No. Serie',0,'1912173741','3775',3000,'2018/10/24'),
(67,'Computadora Compaq','MCD','Computadora',0,1,'12) Computadora No. Serie:6X2C-KN8Z-20L0',0,'2112173739','3777',7539,'2018/10/22'),
(68,'Computadora Sin Nombre','MCD','Computadora',0,1,'13) Sin No. Serie',0,'1912173742','3775',3000,'2018/10/24'),
(69,'M.C.S. Pentium 4 1.6 Ghz','MCD','Computadora',0,1,'Computadora No. Serie S/N Monitor No. Serie 141BM28GA206',0,'2212173737','3777',9548,'2018/10/25')

	select count(Clave)
	from Insumo,Repor_encargados,Repor_Encargado_insumo
	where Fecha_fin<'2018/11/30' and Insumo.Clave=Repor_Encargado_insumo.ID_Insumo and Repor_Encargado_insumo.ID_Reporte=1
