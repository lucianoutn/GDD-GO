Use GD2C2016
Go

/*	--------------------------	CREACION DEL SCHEMA	-------------------------*/
If NOT EXISTS (Select schema_id from sys.schemas where name = 'GDD_GO')
	Execute ('CREATE SCHEMA GDD_GO AUTHORIZATION gd;');
Go

/*----------------------------	BORRADO DE TABLAS	-------------------------*/

	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'tipo_cancelacion')
	DROP TABLE GDD_GO.tipo_cancelacion

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'funciones_por_rol')
	DROP TABLE GDD_GO.funciones_por_rol

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'roles_por_usuario')
	DROP TABLE GDD_GO.roles_por_usuario

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'consulta')
	DROP TABLE GDD_GO.consulta
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'bono_comprado')
	DROP TABLE GDD_GO.bono_comprado

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'hist_cambios_plan_afiliado')
	DROP TABLE GDD_GO.hist_cambios_plan_afiliado

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'especialidades_por_profesional')
	DROP TABLE GDD_GO.especialidades_por_profesional

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'horario')
	DROP TABLE GDD_GO.horario
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'turno')
	DROP TABLE GDD_GO.turno
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'funcion')
	DROP TABLE GDD_GO.funcion

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'tipo_bono')
	DROP TABLE GDD_GO.tipo_bono

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'rol')
	DROP TABLE GDD_GO.rol

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'dia_laboral')
	DROP TABLE GDD_GO.dia_laboral

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'agenda')
	DROP TABLE GDD_GO.agenda	

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'especialidad')
	DROP TABLE GDD_GO.especialidad
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'tipo_especialidad')
	DROP TABLE GDD_GO.tipo_especialidad

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'profesional')
	DROP TABLE GDD_GO.profesional

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GDD_GO' AND  TABLE_NAME = 'afiliado')
	Drop table GDD_GO.afiliado

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GDD_GO' AND  TABLE_NAME = 'usuario')
	Drop table GDD_GO.usuario

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'plan_medico')
	DROP TABLE GDD_GO.plan_medico
/*-----------------------------------------------------------------------------------------------------------------------------------*/

/*----------------------------	CREACION DE TABLAS	-------------------------*/
Create Table GDD_GO.usuario
(	 
	 id_usuario int identity(1,1)
	,desc_username nvarchar(250)
	,desc_password varbinary(32)
	,desc_estado int
	,desc_fecha_inhabilitado datetime
	,intentos_login int
	,primary key (id_usuario)
	,unique (desc_username)
)

CREATE TABLE GDD_GO.plan_medico
(
	 id_plan_medico int
	,descripcion varchar(255)
	,bono_precio_consulta numeric(18,0)
	,bono_precio_farmacia numeric(18,0)
	,primary key (id_plan_medico)
)

Create Table GDD_GO.afiliado
(	 
	 id_afiliado int
	,desc_apellido varchar(255)
	,desc_nombre varchar(255)
	,desc_tipo_doc nvarchar(5)
	,desc_dni int
	,desc_mail varchar(255)
	,desc_direccion varchar(255)
	,desc_telefono numeric(18,0)
	,desc_fecha_nac datetime
	,desc_sexo varchar(50)
	,desc_estado_civil int
	,desc_fecha_creacion datetime
	,id_familiar_principal int
	,id_usuario int
	,id_plan_medico int
	,desc_nro_consulta int
	,primary key (id_afiliado)
	,foreign key (id_familiar_principal) references GDD_GO.afiliado(id_afiliado)
	,foreign key (id_usuario)  references GDD_GO.usuario(id_usuario)
	,foreign key (id_plan_medico) references GDD_GO.plan_medico (id_plan_medico)
)

CREATE TABLE GDD_GO.funcion
(
	 id_funcion int identity(1,1)
	,desc_funcion nvarchar(50)
	,primary key (id_funcion)
)

CREATE TABLE GDD_GO.rol
(
	 id_rol int identity(1,1)
	,desc_nombre_rol nvarchar(50) unique not null
	,desc_estado_rol bit default 1
	,primary key (id_rol)
)

CREATE TABLE GDD_GO.funciones_por_rol
(
	 id_rol int
	,id_funcion int
	,foreign key (id_rol) references GDD_GO.rol(id_rol)
	,foreign key (id_funcion) references GDD_GO.funcion(id_funcion)
)

CREATE TABLE GDD_GO.roles_por_usuario
(
	 id_rol int
	,id_usuario int
	,foreign key (id_rol) references GDD_GO.rol(id_rol)
	,foreign key (id_usuario) references GDD_GO.usuario(id_usuario)
)

CREATE TABLE GDD_GO.hist_cambios_plan_afiliado
(
	 id_historial int identity(1,1)
	,desc_fecha_modificacion DATETIME
	,desc_motivo varchar(255)
	,id_afiliado int
	,id_plan_medico_anterior int
	,primary key (id_historial)
	,foreign key (id_afiliado) references GDD_GO.afiliado(id_afiliado)
	,foreign key (id_plan_medico_anterior) references GDD_GO.plan_medico(id_plan_medico)
)

CREATE TABLE GDD_GO.bono_comprado
(
	  id_bono_comprado int
	 ,id_afiliado int
	 ,id_plan_medico int
	 ,desc_estado bit /* 1:vigente 0:ya utilizado*/
	 ,desc_fecha_compra DATETIME
	 ,desc_fecha_impresion DATETIME
	 ,primary key (id_bono_comprado)
	 ,foreign key (id_afiliado) references GDD_GO.afiliado(id_afiliado)
	 ,foreign key (id_plan_medico) references GDD_GO.plan_medico(id_plan_medico)
)

CREATE TABLE GDD_GO.profesional
(
	 id_profesional int identity(1,1)
	,desc_apellido varchar(255)
	,desc_nombre varchar(255)
	,desc_tipo_doc nvarchar(5)
	,desc_dni int
	,desc_direccion varchar(255)
	,desc_telefono int
	,desc_mail varchar(255)
	,desc_fecha_creacion DATETIME
	,desc_fecha_nac DATETIME
	,desc_sexo varchar(50)
	,desc_matricula varchar(255)
	,id_usuario int
	,primary key (id_profesional)
	,foreign key (id_usuario)  references GDD_GO.usuario(id_usuario)
)

CREATE TABLE GDD_GO.tipo_especialidad
(
	 id_tipo_especialidad int
	,descripcion varchar(255)
	,primary key (id_tipo_especialidad)
)

CREATE TABLE GDD_GO.especialidad
(
	 id_especialidad int
	,descripcion varchar(255)
	,id_tipo_especialidad int
	,primary key (id_especialidad)
	,foreign key (id_tipo_especialidad) references GDD_GO.tipo_especialidad(id_tipo_especialidad)
)

CREATE TABLE GDD_GO.especialidades_por_profesional
(
	 id_profesional int
	,id_especialidad int
	,foreign key (id_profesional) references GDD_GO.profesional(id_profesional)
	,foreign key (id_especialidad) references GDD_GO.especialidad(id_especialidad)	 
)

CREATE TABLE GDD_GO.agenda
(
	 id_agenda int identity(1,1)
	,fecha_desde DATETIME
	,fecha_hasta DATETIME
	,duracion_consulta int
	,estado int
	,id_profesional int
	,id_especialidad int
	,primary key (id_agenda)
	,foreign key (id_profesional) references GDD_GO.profesional(id_profesional)
	,foreign key (id_especialidad) references GDD_GO.especialidad(id_especialidad)
)

CREATE TABLE GDD_GO.dia_laboral
(
	 id_dia_laboral Char
	,horario_desde DATETIME
	,horario_hasta DATETIME
	,estado int
	,id_agenda int 
	,primary key (id_dia_laboral,id_agenda)
	,foreign key (id_agenda) references GDD_GO.agenda
)

CREATE TABLE GDD_GO.turno
(
	 id_turno int
	,desc_estado BIT		/*1=CANCELADO*/
	,id_afiliado int
	,id_profesional int
	,id_especialidad int
	,primary key (id_turno)
	,foreign key (id_afiliado) references GDD_GO.afiliado(id_afiliado)
	,foreign key (id_profesional) references GDD_GO.profesional(id_profesional)
	,foreign key (id_especialidad) references GDD_GO.especialidad(id_especialidad)
)

CREATE TABLE GDD_GO.horario
(
	id_horario int identity(1,1)
   ,desc_hora_desde DATETIME
   ,id_agenda int
   ,id_turno int
   ,primary key (id_horario)
   ,foreign key (id_agenda) references GDD_GO.agenda
   ,foreign key (id_turno) references GDD_GO.turno
)

CREATE TABLE GDD_GO.consulta
(
	 id_consulta int identity(1,1)
	,id_turno int
	,id_bono int
	,desc_sintomas VARCHAR(255)
	,desc_enfermedades VARCHAR (255)
	,desc_hora_llegada DATETIME
	,desc_hora_consulta DATETIME
	,primary key (id_consulta)
	,foreign key (id_turno) references GDD_GO.turno(id_turno)
	,foreign key (id_bono) references GDD_GO.bono_comprado(id_bono_comprado)
)

CREATE TABLE GDD_GO.tipo_cancelacion
(
	 id_tipo_cancelacion int identity(1,1)
	,descripcion varchar(255)
	,id_turno int
	,id_usuario int		/*ID de afiliado o de profesional*/
	,desc_usuario int	/*1=Afiliado,  2=Profesional*/
	,primary key (id_tipo_cancelacion)
	,foreign key (id_turno) references GDD_GO.turno(id_turno)
)


/*----------------------------	MIGRACION DE DATOS	-------------------------*/
Create Table #usuarios	(	 id int identity(1,1)
			,username nvarchar(255)
			,password varbinary(32)
			,entidad varchar(50)
			,id_entidad varchar(75)	)

Insert Into #usuarios 	(	 username
							,password
							,entidad
							,id_entidad	)
Select	 Distinct
		SUBSTRING(m.Paciente_Mail,1 ,CHARINDEX('@',m.Paciente_Mail)-1) + '_' + CONVERT(varchar(4),YEAR(m.Paciente_Fecha_Nac))
		--,HASHBYTES('sha1',SUBSTRING(m.Paciente_Mail,1 ,CHARINDEX('_',m.Paciente_Mail)-1))--cambiar a sha2_256 para la entrega
		,HASHBYTES('sha1','1234')--cambiar a sha2_256 para la entrega
		,'Afiliado'
		,Paciente_Dni
From gd_esquema.Maestra m
Where m.Paciente_Dni is not null

Insert Into #usuarios 	(	 username
							,password
							,entidad
							,id_entidad	)
Select	 Distinct
		SUBSTRING(Medico_Mail,1 ,CHARINDEX('@',Medico_Mail)-1)+ '_' + CONVERT(varchar(4),YEAR(Medico_Fecha_Nac))
		--,HASHBYTES('sha1',SUBSTRING(Medico_Mail,1 ,CHARINDEX('_',Medico_Mail)-1))--cambiar a sha2_256 para la entrega
		,HASHBYTES('sha1','1234')--cambiar a sha2_256 para la entrega
		,'Profesional'
		,Medico_Dni
From gd_esquema.Maestra
Where Medico_Dni is not null

/*USUARIO*/

Insert into GDD_GO.usuario	(	desc_username
							   ,desc_password
							   ,desc_estado
							   ,intentos_login		)
Select us.username
	  ,us.password
	  ,1
	  ,0
From #usuarios us
where us.entidad = 'Afiliado'
Go

Insert into GDD_GO.usuario	(	desc_username
							   ,desc_password
							   ,desc_estado	)
Select us.username
	  ,us.password
	  ,1
From #usuarios us
where us.entidad = 'Profesional'
Go

/*PROFESIONAL*/
Insert into GDD_GO.profesional	(	 id_usuario
									,desc_apellido
									,desc_nombre
									,desc_sexo
									,desc_tipo_doc
									,desc_dni
									,desc_direccion
									,desc_telefono
									,desc_mail
									,desc_fecha_nac
									,desc_matricula
									,desc_fecha_creacion		)
Select Distinct
	   us.id
	  ,ma.Medico_Apellido
	  ,ma.Medico_Nombre
	  ,'consultar'
	  ,'DNI'
	  ,ma.Medico_Dni
	  ,ma.Medico_Direccion
	  ,ma.Medico_Telefono
	  ,ma.Medico_Mail
	  ,ma.Medico_Fecha_Nac
	  ,'INCOMPLETO'
	  ,'2016-11-10 00:00:00.000'
From gd_esquema.Maestra ma
Join #usuarios us
	 on us.id_entidad = ma.Medico_Dni And
	 Medico_Dni is not null
Go

/*Planes Medicos*/
Insert into GDD_GO.plan_medico(
	id_plan_medico
	,descripcion
)
Select	distinct m.Plan_Med_Codigo,
		m.Plan_Med_Descripcion
From gd_esquema.Maestra m

Go

/*AFILIADO*/
Insert into GDD_GO.afiliado(  id_afiliado
							 ,desc_nombre
		   					 ,desc_apellido
							 ,desc_sexo
							 ,desc_tipo_doc
							 ,desc_dni
							 ,desc_mail
							 ,desc_direccion
							 ,desc_telefono
							 ,desc_estado_civil
							 ,desc_fecha_creacion
							 ,desc_fecha_nac
							 ,id_usuario		
							 ,id_plan_medico
							 ,desc_nro_consulta)
Select	 Distinct      
		 id*100+1
		,ma.Paciente_Nombre
		,ma.Paciente_Apellido
		,'consultar'
		,'DNI'
		,ma.Paciente_Dni
		,ma.Paciente_Mail
		,ma.Paciente_Direccion
		,ma.Paciente_Telefono
		,0
		,GETDATE()
		,ma.Paciente_Fecha_Nac
		,us.id
		,ma.Plan_Med_Codigo
		,0
From gd_esquema.Maestra ma
Join #usuarios us
	 on us.id_entidad = ma.Paciente_Dni And
	 Paciente_Dni is not null
Order by id
Go



Drop Table #usuarios

/*TIPO ESPECIALIDAD*/
Insert into GDD_GO.tipo_especialidad	(	id_tipo_especialidad
										   ,descripcion		)
Select Distinct 
	   Tipo_Especialidad_Codigo
	  ,Tipo_Especialidad_Descripcion
From gd_esquema.Maestra
Where Tipo_Especialidad_Codigo is not null
Go

/*ESPECIALIDAD*/
Insert into GDD_GO.especialidad		(	id_especialidad
									   ,descripcion
									   ,id_tipo_especialidad		)
Select Distinct
	   Especialidad_Codigo
	  ,Especialidad_Descripcion
	  ,Tipo_Especialidad_Codigo
From gd_esquema.Maestra
Where Especialidad_Codigo is not null
Go

/*ESPECIALIDADES POR PROFESIONAL*/
Insert into GDD_GO.especialidades_por_profesional	(	id_profesional
													   ,id_especialidad	)
Select Distinct pr.id_profesional
			   ,Especialidad_Codigo
From gd_esquema.Maestra ma
Join GDD_GO.profesional pr
On ma.Medico_Dni = pr.desc_dni

Go
/*Agenda*/
Insert into GDD_GO.agenda(
	id_profesional,
	id_especialidad,
	fecha_desde,
	fecha_hasta,
	duracion_consulta,
	estado
)
Select	distinct p.id_profesional,
		x.id_especialidad,
		null,null,30,1
From GDD_GO.profesional p
join GDD_GO.especialidades_por_profesional x on p.id_profesional = x.id_profesional

/*Dias_Laborales*/
Insert into GDD_GO.dia_laboral(
	id_dia_laboral,
	id_agenda,
	horario_desde,
	horario_hasta,
	estado
)
Select	distinct 'z',
		ag.id_agenda,
		null,null,1
From GDD_GO.agenda ag

Go
/*TURNO*/
Insert into GDD_GO.turno	(	id_turno
							   ,id_afiliado
							   ,id_profesional
							   ,desc_estado
							   ,id_especialidad	)
Select Turno_Numero, af.id_afiliado, pr.id_profesional, 0, Especialidad_Codigo
From gd_esquema.Maestra
join GDD_GO.afiliado af
	 On Paciente_Dni = af.desc_dni
join GDD_GO.profesional pr
 	 On Medico_Dni = pr.desc_dni	 
Where Turno_Numero is not null And Consulta_Sintomas is null

Go
/*Horario*/
Insert into GDD_GO.horario(
	id_turno,
	desc_hora_desde,
	id_agenda
)
Select m.Turno_Numero, m.Turno_Fecha, ag.id_agenda
From gd_esquema.Maestra m
join GDD_GO.afiliado af
	On m.Paciente_Dni = af.desc_dni
join GDD_GO.profesional pr
	On m.Medico_Dni = pr.desc_dni
join GDD_GO.agenda ag
	On	ag.id_profesional = pr.id_profesional
		and ag.id_especialidad = m.Especialidad_Codigo
Where Turno_Numero is not null And Consulta_Sintomas is not null

Go
/*Seteo Agenda*/
Update GDD_GO.agenda
Set fecha_desde = (
	select TOP(1) h.desc_hora_desde from GDD_GO.horario h
	where GDD_GO.agenda.id_agenda = h.id_agenda
	Order by h.desc_hora_desde ASC
),	fecha_hasta = (	
	select TOP(1) h.desc_hora_desde from GDD_GO.horario h
	where GDD_GO.agenda.id_agenda = h.id_agenda
	Order by h.desc_hora_desde DESC)


Go

/*Bonos Comprado*/
Insert into GDD_GO.bono_comprado(	id_bono_comprado
								   ,id_afiliado
								   ,id_plan_medico
								   ,desc_fecha_compra
								   ,desc_fecha_impresion
								   ,desc_estado			)
Select
	   m.Bono_Consulta_Numero
	  ,a.id_afiliado
	  ,m.Plan_Med_Codigo
	  ,m.Compra_Bono_Fecha
	  ,m.Bono_Consulta_Fecha_Impresion
	  ,1
From gd_esquema.Maestra m
Join GDD_GO.afiliado a
	 On a.desc_dni = m.Paciente_Dni
Where m.Compra_Bono_Fecha is not null AND m.Bono_Consulta_Numero Is not null

/*Consultas*/
Insert into GDD_GO.consulta(
	 desc_sintomas
	,desc_enfermedades
	,desc_hora_llegada
	,desc_hora_consulta	
	,id_turno
	,id_bono
)
select	m.Consulta_Sintomas,
		m.Consulta_Enfermedades,
		null,
		h.desc_hora_desde,
		t.id_turno,
		m.Bono_Consulta_Numero
from gd_esquema.Maestra m
join GDD_GO.afiliado a				ON a.desc_dni = m.Paciente_Dni
join GDD_GO.turno t					ON a.id_afiliado = t.id_afiliado and t.id_turno = m.Turno_Numero
join GDD_GO.horario h				ON h.id_turno = t.id_turno
where	m.Consulta_Enfermedades is not null
and		m.Consulta_Sintomas is not null
and		m.Compra_Bono_Fecha is null


/*----------------------------	FIN DE MIGRACION DE DATOS	-------------------------*/

--Genero usuario de sistema por script
Insert into GDD_GO.usuario	(	 desc_username
				
								,desc_password
								,desc_estado
								,intentos_login		)
Values	 ('admin', HASHBYTES('sha1', 'w23e'), 1,0)--cambiar a sha2_256 para la entrega
Go

--Inserto Roles existentes
Insert into GDD_GO.rol (	desc_nombre_rol)
Values	('Administrador'),
		('Afiliado'),
		('Profesional')
Go

--Inserto Funciones existentes
Insert into GDD_GO.funcion	(desc_funcion)
Values	('ABM de Rol'),
		('ABM de Usuarios'),
		('ABM de Afiliados'),
		('ABM de Profesional'),
		('ABM de Especialidades Medicas'),
		('ABM de Plan'),
		('Registrar Agenda Profesional'),
		('Compra de Bonos'),
		('Pedido de Turno'),
		('Registro de llegada para atencion medica'),
		('Registro de resultado para atencion medica'),
		('Cancelar atencion medica'),
		('Listado Estadístico')
Go		
					
--Establezco los vinculos FuncionesPorRol
Insert into GDD_GO.funciones_por_rol (id_rol, id_funcion)
Values	(1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7),(1,8),(1,9),(1,10),(1,11),(1,12),(1,13), 
		(2,8), (2,9), (2,12),
		(3,7), (3,11), (3,12)
		
Go

--Asignacion de los roles en base a tipo de usuario
Insert Into GDD_GO.roles_por_usuario	(	 id_usuario, id_rol	)
Select	 id_usuario, 2
	From GDD_GO.afiliado
Union
select id_usuario, 3 
	From GDD_GO.profesional
Union
select id_usuario , 1
	From GDD_GO.usuario
	where desc_username = 'admin'
go



/*-----------------------------------------------------------------------------------------------------------------------------------*/
/*----------------------------	BORRADO DE STORED PROCEDURES	----------------------------*/
If exists (select'existe' From INFORMATION_SCHEMA.ROUTINES where SPECIFIC_NAME = 'inicializar_modelo')
	Drop procedure GDD_GO.inicializar_modelo
Go

If exists (select'existe' From INFORMATION_SCHEMA.ROUTINES where SPECIFIC_NAME = 'logearse')
	Drop procedure GDD_GO.logearse
Go

If exists (select'existe' From INFORMATION_SCHEMA.ROUTINES where SPECIFIC_NAME = 'calcular_id_afiliado')
	Drop procedure GDD_GO.calcular_id_afiliado
Go

If exists (select'existe' From INFORMATION_SCHEMA.ROUTINES where SPECIFIC_NAME = 'sp_cambiar_plan_medico')
	Drop procedure  GDD_GO.sp_cambiar_plan_medico
Go

If exists (select'existe' From INFORMATION_SCHEMA.ROUTINES where SPECIFIC_NAME = 'sp_Agregar_Agenda')
	Drop procedure GDD_GO.sp_Agregar_Agenda
Go


/*----------------------------	CREACION DE STORE PROCEDURES	----------------------------*/
--Iniciar Aplicacion
Create procedure GDD_GO.inicializar_modelo (@fechasys varchar(10))
as
Declare @fecha date = convert(date, substring(@fechasys, 7, 4) + substring(@fechasys, 4, 2) + substring(@fechasys, 1, 2));

Go

--Logeo y seguridad
Create Procedure GDD_GO.logearse	(	 @user varchar(150)
										,@pass varchar(150)	)
As
Declare @usuario int = 0;
Declare @estado int = 0;
Declare @intentos int = 0;

Select	@usuario = us.id_usuario,
		@estado = us.desc_estado,
		@intentos = us.intentos_login
From GDD_GO.usuario us
Where us.desc_username = @user

if (@usuario = 0)
	Select 'invalido' as mensaje
else
	if (@estado = 2 OR @intentos = 3)
		Select 'inhabilitado' as mensaje
	else
	Begin
		if not exists (Select 'existe' from GDD_GO.usuario us
					   where us.id_usuario = @usuario and 
							 us.desc_password = HASHBYTES('sha1', @pass)	)--cambiar a sha2_256 para la entrega
		Begin
			Select 'incorrecto' as mensaje
			Update GDD_GO.usuario set intentos_login = @intentos+1 where id_usuario=@usuario
		End
		else
		Begin
			Select 'correcto' as mensaje
			Update GDD_GO.usuario set intentos_login = 0 where id_usuario=@usuario
		End
	End
Go


--CAMBIAR PLAN MEDICO
Create Procedure  GDD_GO.sp_cambiar_plan_medico	(	 @afiliado int
													,@plan_medico int
													,@motivo varchar(255)	)
As
Declare @plan_medico_anterior int;
Begin
	Set @plan_medico_anterior = (select id_plan_medico from GDD_GO.afiliado where id_afiliado=@afiliado)

	Update GDD_GO.afiliado set id_plan_medico = @plan_medico where id_afiliado=@afiliado

	Insert into GDD_GO.hist_cambios_plan_afiliado (id_afiliado, desc_fecha_modificacion,id_plan_medico_anterior, desc_motivo)
	Values
	(@afiliado, GETDATE(), @plan_medico_anterior, @motivo)
End
GO

--Nueva Agenda
Create Procedure  GDD_GO.sp_Agregar_Agenda(
		@profesional int,
		@especialidad int,
		@fecha_desde Datetime,
		@fecha_hasta Datetime,	
		@consulta int)
As
Declare @agenda int;
Begin
	INSERT INTO GDD_GO.agenda(
			id_profesional, id_especialidad,
            fecha_desde, fecha_hasta,duracion_consulta, estado)
            VALUES (
			@profesional,
			@especialidad,
			@fecha_desde,
			@fecha_hasta,
			@consulta, 0)

	set @agenda = (select TOP(1) id_agenda from GDD_GO.agenda order by id_agenda desc)

	select @agenda as mensaje
	end
GO


/*----------------------------	BORRADO DE VISTAS	-------------------------*/

If exists (select * FROM sys.views where name = 'vista_rol_usuario')
Drop view GDD_GO.vista_rol_usuario
Go

If exists (select * FROM sys.views where name = 'vista_rol_funciones')
Drop view GDD_GO.vista_rol_funciones
Go

If exists (select * FROM sys.views where name = 'vista_especialidad_profesional')
Drop view GDD_GO.vista_especialidad_profesional
Go

/*----------------------------	CREACION DE VISTAS	-------------------------*/

Create view GDD_GO.vista_rol_usuario
As
Select rxu.*, r.desc_nombre_rol, r.desc_estado_rol 
from GDD_GO.roles_por_usuario rxu
left join GDD_GO.rol r
	on rxu.id_rol = r.id_rol
Go

Create view GDD_GO.vista_rol_funciones
As
Select r.desc_nombre_rol, f.desc_funcion
From GDD_GO.funciones_por_rol fxr
left join GDD_GO.rol r
	on fxr.id_rol = r.id_rol
left join GDD_GO.funcion f
	on fxr.id_funcion = f.id_funcion
Go

Create view GDD_GO.vista_especialidad_profesional
As
Select (p.desc_apellido+' '+p.desc_nombre)as nombre, e.descripcion
From GDD_GO.especialidades_por_profesional exf
left join GDD_GO.profesional p
	on exf.id_profesional = p.id_profesional
left join GDD_GO.especialidad e
	on exf.id_especialidad = e.id_especialidad
Go




/*----------------------------	BORRADO DE TRIGGERS	-------------------------*/
If exists (select 'existe' From sys.objects where type = 'TR' AND name = 'tr_insertar_afiliado')
	Drop trigger GDD_GO.tr_insertar_afiliado
Go

If exists (select 'existe' From sys.objects where type = 'TR' AND name = 'tr_baja_afiliado')
	Drop trigger GDD_GO.tr_baja_afiliado
Go

If exists (select 'existe' From sys.objects where type = 'TR' AND name = 'tr_cancelar_turno')
	Drop trigger GDD_GO.tr_cancelar_turno
Go

If exists (select 'existe' From sys.objects where type = 'TR' AND name = 'tr_baja_rol')
	Drop trigger GDD_GO.tr_baja_rol
Go

If exists (select 'existe' From sys.objects where type = 'TR' AND name = 'tr_baja_rol_por_usuario')
	Drop trigger GDD_GO.tr_baja_rol_por_usuario
Go

If exists (select 'existe' From sys.objects where type = 'TR' AND name = 'tr_sumar_nro_consulta_afiliado')
	Drop trigger GDD_GO.tr_sumar_nro_consulta_afiliado
Go


/*----------------------------	CREACION DE TRIGGERS	-------------------------*/

Create Trigger GDD_GO.tr_insertar_afiliado
On GDD_GO.afiliado
Instead of Insert
As
Begin
	Declare @id_afiliado int
	Declare @nombre varchar(255)
	Declare @apellido varchar(255)
	Declare @sexo varchar(50)
	Declare @tipo_doc nvarchar(5)
	Declare @dni numeric(18,0)
	Declare @mail varchar(255)
	Declare @direccion varchar(255)
	Declare @telefono numeric(18,0)
	Declare @estado_civil int
	Declare @fecha_nac datetime
	Declare @id_familiar_ppal int
	Declare @id_usuario int
	Declare @id_plan_medico int

	Select @nombre = desc_nombre, @apellido = desc_apellido, @sexo = desc_sexo, @tipo_doc = desc_tipo_doc, @dni=desc_dni, @mail=desc_mail, @direccion = desc_direccion, @telefono=desc_telefono, @estado_civil = desc_estado_civil, @fecha_nac = desc_fecha_nac, @id_familiar_ppal=id_familiar_principal, @id_plan_medico = id_plan_medico, @id_usuario=id_usuario
	From inserted;
	
	If (@id_familiar_ppal is null)
	Begin
		Set @id_afiliado = ISNULL((Select (MAX(id_afiliado)+100) from GDD_GO.afiliado),@id_usuario*100+1)
	End
	Else
	Begin
		Set @id_afiliado = ISNULL((Select (MAX(af.id_afiliado)+1) from GDD_GO.afiliado af where af.id_familiar_principal = @id_familiar_ppal),@id_familiar_ppal+1)
	End
		Insert into GDD_GO.afiliado(  id_afiliado
									 ,desc_nombre
		   							 ,desc_apellido
									 ,desc_sexo
									 ,desc_tipo_doc
									 ,desc_dni
									 ,desc_mail
									 ,desc_direccion
									 ,desc_telefono
									 ,desc_estado_civil
									 ,desc_fecha_nac
									 ,desc_fecha_creacion	
									 ,id_familiar_principal
									 ,id_usuario
									 ,id_plan_medico	)
		Values (    @id_afiliado
				   ,@nombre
				   ,@apellido
				   ,@sexo
				   ,@tipo_doc
				   ,@dni
				   ,@mail
				   ,@direccion
				   ,@telefono
				   ,@estado_civil
				   ,@fecha_nac
				   ,GETDATE()	
				   ,@id_familiar_ppal
				   ,@id_usuario	
				   ,@id_plan_medico	)
		
		Insert into GDD_GO.roles_por_usuario (id_usuario, id_rol)
		Values (	@id_usuario, 2)

End
Go




Create Trigger GDD_GO.tr_baja_afiliado
On GDD_GO.usuario
Instead of Delete
As
Begin
	Declare @id_usuario int
	Declare @id_turno numeric(18,0)
	Declare @id_afiliado int
	Declare @desc_usuario int
	Select @id_usuario = id_usuario
	From deleted;
	
	Update GDD_GO.usuario Set desc_estado=2, desc_fecha_inhabilitado=GETDATE() where id_usuario = @id_usuario;

	DECLARE my_Cursor CURSOR FOR Select tu.id_turno
										,af.id_afiliado
										,1
								  From GDD_GO.afiliado af
									   Join GDD_GO.turno tu
									   On tu.id_afiliado = af.id_afiliado
								  Where af.id_usuario=@id_usuario;

	OPEN my_Cursor 
	FETCH NEXT FROM my_Cursor into @id_turno, @id_afiliado, @desc_usuario

	WHILE @@FETCH_STATUS = 0 
	BEGIN 
		 Insert into GDD_GO.tipo_cancelacion (	descripcion
											   ,id_turno
											   ,id_usuario
											   ,desc_usuario	)
		values( 'Afiliado dado de baja'
			   ,@id_turno
			   ,@id_afiliado
			   ,@desc_usuario)
	FETCH NEXT FROM my_Cursor into @id_turno, @id_afiliado, @desc_usuario  
	END

	CLOSE my_Cursor
	DEALLOCATE my_Cursor
End
Go

Create Trigger  GDD_GO.tr_cancelar_turno
On GDD_GO.tipo_cancelacion
FOR insert
As
Declare @id_turno int

Set @id_turno = (Select id_turno from inserted)
Update GDD_GO.turno set desc_estado=1 where id_turno = @id_turno;
Go

-- TRIGGERs DE BAJA LOGICA DE ROL 
Create Trigger  GDD_GO.tr_baja_rol
On GDD_GO.rol
Instead of delete
AS
Begin
	Declare @id_rol int
	
	Select @id_rol = id_rol
	From deleted
	Update GDD_GO.rol 
	Set desc_estado_rol = 0
	where id_rol = @id_rol
End
Go

Create Trigger  GDD_GO.tr_baja_rol_por_usuario
On GDD_GO.rol
After update
As
Declare @estado bit
Declare @id_rol int

Set @estado = (Select desc_estado_rol from inserted)
Set @id_rol = (Select id_rol from inserted)

if @estado = 0
begin
	Delete from GDD_GO.roles_por_usuario
	where id_rol = @id_rol
end
Go

Create Trigger  GDD_GO.tr_sumar_nro_consulta_afiliado
On GDD_GO.consulta
After update
As
Begin
	Declare @id_turno int

	Set @id_turno = (Select id_turno from inserted)

	UPDATE GDD_GO.afiliado SET desc_nro_consulta = desc_nro_consulta +1 where id_afiliado = (	SELECT tu.id_afiliado
																								From  GDD_GO.turno tu
																								Where tu.id_turno = @id_turno AND
																									  tu.id_afiliado = id_afiliado	)
end
Go