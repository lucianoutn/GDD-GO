Use GD2C2016
Go




/*	--------------------------	CREACION DEL SCHEMA	-------------------------*/
If NOT EXISTS (Select schema_id from sys.schemas where name = 'GDD_GO')
	Execute ('CREATE SCHEMA GDD_GO AUTHORIZATION gd;');
Go




/*----------------------------	BORRADO DE TABLAS	-------------------------*/
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GDD_GO' AND  TABLE_NAME = 'afiliado')
	Drop table GDD_GO.afiliado

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GDD_GO' AND  TABLE_NAME = 'usuario')
	Drop table GDD_GO.usuario

/*-----------------------------------------------------------------------------------------------------------------------------------*/
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'funcion_por_rol')
	DROP TABLE GDD_GO.funcion_por_rol

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'rol')
	DROP TABLE GDD_GO.rol

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'roles_por_usuario')
	DROP TABLE GDD_GO.roles_por_usuario

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'funcion')
	DROP TABLE GDD_GO.funcion

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'plan_medico')
	DROP TABLE GDD_GO.plan_medico

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'plan_por_afiliado')
	DROP TABLE GDD_GO.plan_por_afiliado

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'estado')
	DROP TABLE GDD_GO.estado

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'hist_cambios_plan_afiliado')
	DROP TABLE GDD_GO.hist_cambios_plan_afiliado

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'bono')
	DROP TABLE GDD_GO.bono
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'bono_por_afiliado')
	DROP TABLE GDD_GO.bono_por_afiliado

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'profesional')
	DROP TABLE GDD_GO.profesional

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'consulta')
	DROP TABLE GDD_GO.consulta

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'turno')
	DROP TABLE GDD_GO.turno

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'agenda')
	DROP TABLE GDD_GO.agenda

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'tipo_cancelacion')
	DROP TABLE GDD_GO.tipo_cancelacion

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'profesional_por_especialidad')
	DROP TABLE GDD_GO.profesional_por_especialidad

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'especialidad')
	DROP TABLE GDD_GO.especialidad

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'tipo_especialidad')
	DROP TABLE GDD_GO.tipo_especialidad

/*-----------------------------------------------------------------------------------------------------------------------------------*/



/*----------------------------	CREACION DE TABLAS	-------------------------*/
Create Table GDD_GO.usuario
(	 
	 id_usuario int identity(1,1)
	,desc_username nvarchar(250)
	,desc_password varbinary(32)
	,id_estado int
	,primary key (id_usuario)
)

Create Table GDD_GO.afiliado
(	 
	 id_afiliado int identity(100,100)
	,id_nro_familiar int
	,desc_apellido varchar(255)
	,desc_nombre varchar(255)
	,desc_tipo_doc nvarchar(5)
	,desc_dni numeric(18,0)
	,desc_mail varchar(255)
	,desc_direccion varchar(255)
	,desc_telefono numeric(18,0)
	,desc_fecha_nac datetime
	,desc_sexo bit
	,desc_estado_civil int
	,desc_fecha_creacion datetime
	,id_familiar_principal int
	,primary key (id_afiliado)
	,foreign key (id_familiar_principal) references GDD_GO.usuario(id_usuario)
)

/*-----------------------------------------------------------------------------------------------------------------------------------*/
CREATE TABLE GDD_GO.funcion_por_rol
(
	 id_rol int
	,id_funcion int
	,foreign key (id_rol) references GDD_GO.rol(id_rol)
	,foreign key (id_funcion) references GDD_GO.funcion(id_funcion)
)

CREATE TABLE GDD_GO.rol
(
	 id_rol int identity(1,1)
	,desc_rol nvarchar(50)
	,desc_estado_rol nvarchar(2)
	,primary key (id_rol)
)

CREATE TABLE GDD_GO.roles_por_usuario
(
	 id_rol int
	,id_usuario int
	,foreign key (id_rol) references GDD_GO.rol(id_rol)
	,foreign key (id_usuario) references GDD_GO.usuario(id_usuario)
)

CREATE TABLE GDD_GO.funcion
(
	 id_funcion int identity(1,1)
	,desc_funcion nvarchar(200)
	,primary key (id_funcion)
)

CREATE TABLE GDD_GO.plan_medico
(
	 id_plan_medico int identity(1,1)
	,descripcion varchar(255)
	,desc_precio_bono_consulta numeric(18,0)
	,desc_precio_bono_farmacia numeric(18,0)
	,primary key (id_plan_medico)
)

CREATE TABLE GDD_GO.plan_por_afiliado
(
	 id_plan_medico int
	,id_afiliado int
	,foreign key (id_plan_medico) references GDD_GO.plan_medico
	,foreign key (id_afiliado) references GDD_GO.afiliado
)

CREATE TABLE GDD_GO.estado
(
	 id_estado int identity(1,1)
	,desc_estado nvarchar(100)
	,primary key (id_estado)
)

CREATE TABLE GDD_GO.hist_cambios_plan_afiliado
(
	 id_historial int identity(1,1)
	,desc_fecha_modificacion DATETIME
	,desc_motivo varchar(255)
	,id_afiliado int
	,id_plan_medico int
	,primary key (id_historial)
	,foreign key (id_afiliado) references GDD_GO.afiliado
	,foreign key (id_plan_medico) references GDD_GO.plan_medico
)

CREATE TABLE GDD_GO.bono
(
	 id_bono int identity(1,1)
	,id_plan_medico int
	,primary key (id_bono)
	,foreign key (id_plan_medico) references GDD_GO.plan_medico
)

CREATE TABLE GDD_GO.bono_por_afiliado
(
	  id_bono int
	 ,id_afiliado int
	 ,desc_cantidad int
	 ,foreign key (id_bono) references GDD_GO.bono
	 ,foreign key (id_afiliado) references GDD_GO.afiliado
)

CREATE TABLE GDD_GO.profesional
(
	 id_profesional int identity(1,1)
	,desc_tipo_doc nvarchar(5)
	,desc_dni numeric(18,0)
	,desc_direccion varchar(255)
	,desc_telefono numeric(18)
	,desc_mail varchar(255)
	,desc_fecha_creacion DATETIME
	,desc_fecha_nac DATETIME
	,desc_sexo BIT
	,desc_matricula varchar(255)
	,id_usuario int
	,primary key (id_profesional)
	,foreign key (id_usuario) references GDD_DO.usuario 	 
)

CREATE TABLE GDD_GO.consulta
(
	 id_consulta int identity(1,1)
	,id_plan_medico int
	,primary key (id_consulta)
	,foreign key (id_plan_medico) references GDD_GO.plan_medico
)

CREATE TABLE GDD_GO.turno
(
	 id_turno int identity(1,1)
	,desc_fecha_hora DATETIME
	,desc_estado BIT
	,id_afiliado int
	,id_profesional int
	,primary key (id_turno)
	,foreign key (id_afiliado) references GDD_GO.afiliado
	,foreign key (id_profesional) references GDD_GO.profesional
)

CREATE TABLE GDD_GO.agenda
(
	 id_dia_agenda int identity(1,1)
	,desc_dia int
	,desc_hora_desde TIME
	,desc_hora_hasta TIME
	,id_profesional int
	,primary key (id_dia_agenda)
	,foreign key (id_profesional) references GDD_GO.profesional	
)

CREATE TABLE GDD_GO.tipo_cancelacion
(
	 id_tipo_cancelacion int identity(1,1)
	,descripcion varchar(255)
	,id_turno int
	,primary key (id_tipo_cancelacion)
	,foreign key (id_turno) references GDD_GO.turno
)

CREATE TABLE GDD_GO.profesional_por_especialidad
(
	 id_profesional int
	,id_especialidad int
	,foreign key (id_profesional) references GDD_GO.profesional
	,foreign key (id_especialidad) references GDD_GO.especialidad	 	 
)

CREATE TABLE GDD_GO.especialidad
(
	 id_especialidad int identity(1,1)
	,descripcion varchar(255)
	,id_tipo_especialidad numeric(18,0)
	,primary key (id_especialidad)
	,foreign key (id_tipo_especialidad) references GDD_GO.tipo_especialidad
)

CREATE TABLE GDD_GO.tipo_especialidad
(
	 id_tipo_especialidad int identity(1,1)
	,descripcion varchar(255)
	,primary key (id_tipo_especialidad)
)

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

Select	@usuario = us.id_usuario,
		@estado = us.id_estado
From GDD_GO.usuario us
Where us.desc_username = @user

if (@usuario = 0)
	Select 'invalido' as mensaje
else
	if not exists (Select 'existe' from GDD_GO.usuario us
				   where us.id_usuario = @usuario and 
					     us.desc_password = HASHBYTES('SHA2_256', @pass)	)
	Begin
		Select 'incorrecto' as mensaje
	End
	else
	Begin
		Select 'correcto' as mensaje
	End
Go





--Genero usuario de sistema por script
Insert into GDD_GO.usuario	(	 desc_username
								,desc_password
								,id_estado	)
Values	 ('admin', HASHBYTES('sha2_256', 'w23e'), 1)




/*----------------------------	MIGRACION DE DATOS	-------------------------*/
Insert Into GDD_GO.afiliado		(	desc_apellido
									,desc_nombre
									,desc_dni
									,desc_direccion
									,desc_telefono
									,desc_mail
									,desc_fecha_nac
									,id_nro_familiar	)
Select	 Distinct
		 Paciente_Apellido
		 ,Paciente_Nombre
		 ,Paciente_Dni
		 ,Paciente_Direccion
		 ,Paciente_Telefono
		 ,Paciente_Mail
		 ,Paciente_Fecha_Nac
		 ,1
From gd_esquema.Maestra

/*	***************************	CARGA DE DATOS	**************************** */
--Carga de las funciones
INSERT INTO GDD_GO.funciones (desc_funcion)
VALUES	 ('ABM de rol')
		,('ABM de afiliado')
		,('ABM profesional')
		,('ABM especialidades médicas')
		,('ABM planes')
		,('Registrar agenda del médico')
		,('Compra de bonos')
		,('Pedir turno')
		,('Registrar resultado para atención médica')
		,('Cancelar atención médica')
		,('Listado estadístico')
GO

--Carga de los estados

INSERT INTO GDD_GO.estado (desc_estado)
VALUES	('Habilitado'),
		('Bloqueado')
GO

--Carga de roles
INSERT INTO GDD_GO.rol (desc_rol, desc_estado_rol)
VALUES	 ('Afiliado', 'H')
		,('Administrativo', 'H')
		,('Profesional', 'H')
GO



/*	***************************	CARGA DE DATOS	**************************** */		
