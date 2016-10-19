Use GD2C2016
Go

/*	--------------------------	CREACION DEL SCHEMA	-------------------------*/
If NOT EXISTS (Select schema_id from sys.schemas where name = 'GDD_GO')
	Execute ('CREATE SCHEMA GDD_GO AUTHORIZATION gd;');
Go

/*----------------------------	BORRADO DE TABLAS	-------------------------*/

/*-----------------------------------------------------------------------------------------------------------------------------------*/
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'funciones_por_rol')
	DROP TABLE GDD_GO.funciones_por_rol

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'roles_por_usuario')
	DROP TABLE GDD_GO.roles_por_usuario

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'planes_por_afiliado')
	DROP TABLE GDD_GO.planes_por_afiliado

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'consulta')
	DROP TABLE GDD_GO.consulta

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'bonos_por_afiliado')
	DROP TABLE GDD_GO.bono

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'hist_cambios_plan_afiliado')
	DROP TABLE GDD_GO.hist_cambios_plan_afiliado
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'tipo_cancelacion')
	DROP TABLE GDD_GO.tipo_cancelacion

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'especialidades_por_profesional')
	DROP TABLE GDD_GO.especialidades_por_profesional

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'horario')
	DROP TABLE GDD_GO.horario
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'turno')
	DROP TABLE GDD_GO.turno
	
IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'funcion')
	DROP TABLE GDD_GO.funcion

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'bono')
	DROP TABLE GDD_GO.tipo_bono

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'plan_medico')
	DROP TABLE GDD_GO.plan_medico

IF EXISTS (SELECT 'existe' FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GDD_GO' AND TABLE_NAME = 'rol')
	DROP TABLE GDD_GO.rol

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
/*-----------------------------------------------------------------------------------------------------------------------------------*/



/*----------------------------	CREACION DE TABLAS	-------------------------*/
Create Table GDD_GO.usuario
(	 
	 id_usuario int identity(1,1)
	,desc_username nvarchar(250)
	,desc_password varbinary(32)
	,desc_estado int
	,desc_fecha_inhabilitado datetime
	,primary key (id_usuario)
)

Create Table GDD_GO.afiliado
(	 
	 id_afiliado int
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
	,id_usuario int
	,primary key (id_afiliado)
	,foreign key (id_familiar_principal) references GDD_GO.afiliado(id_afiliado)
	,foreign key (id_usuario)  references GDD_GO.usuario(id_usuario)
)

/*-----------------------------------------------------------------------------------------------------------------------------------*/
CREATE TABLE GDD_GO.funcion
(
	 id_funcion int identity(1,1)
	,desc_funcion int
	,primary key (id_funcion)
)

CREATE TABLE GDD_GO.rol
(
	 id_rol int
	,desc_rol nvarchar(50)
	,desc_estado_rol nvarchar(2)
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

CREATE TABLE GDD_GO.plan_medico
(
	 id_plan_medico int
	,descripcion varchar(255)
	,primary key (id_plan_medico)
)

CREATE TABLE GDD_GO.planes_por_afiliado
(
	 id_plan_medico int
	,id_afiliado int
	,foreign key (id_plan_medico) references GDD_GO.plan_medico
	,foreign key (id_afiliado) references GDD_GO.afiliado
)

CREATE TABLE GDD_GO.hist_cambios_plan_afiliado
(
	 id_historial int identity(1,1)
	,desc_fecha_modificacion DATETIME
	,desc_motivo varchar(255)
	,id_afiliado int
	,id_plan_medico int
	,primary key (id_historial)
	,foreign key (id_afiliado) references GDD_GO.afiliado(id_afiliado)
	,foreign key (id_plan_medico) references GDD_GO.plan_medico(id_plan_medico)
)

CREATE TABLE GDD_GO.tipo_bono
(
	 id_tipo_bono int identity(1,1)
	,id_plan_medico int
	,desc_precio_bono_consulta numeric(18,0)
	,desc_precio_bono_farmacia numeric(18,0)
	,primary key (id_tipo_bono)
	,foreign key (id_plan_medico) references GDD_GO.plan_medico
)

CREATE TABLE GDD_GO.bono
(
	 id_bono int
	 ,id_tipo_bono int
	 ,id_afiliado int
	 ,desc_cantidad int
	 ,fecha_compra DATETIME
	 ,fecha_impresion DATETIME
	 ,primary key (id_bono)
	 ,foreign key (id_tipo_bono) references GDD_GO.tipo_bono
	 ,foreign key (id_afiliado) references GDD_GO.afiliado
)

CREATE TABLE GDD_GO.profesional
(
	 id_profesional int identity(1,1)
	,desc_apellido varchar(255)
	,desc_nombre varchar(255)
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
	,foreign key (id_usuario)  references GDD_GO.usuario(id_usuario)
)

CREATE TABLE GDD_GO.tipo_especialidad
(
	 id_tipo_especialidad numeric(18,0)
	,descripcion varchar(255)
	,primary key (id_tipo_especialidad)
)

CREATE TABLE GDD_GO.especialidad
(
	 id_especialidad numeric(18,0)
	,descripcion varchar(255)
	,id_tipo_especialidad numeric(18,0)
	,primary key (id_especialidad)
	,foreign key (id_tipo_especialidad) references GDD_GO.tipo_especialidad(id_tipo_especialidad)
)

CREATE TABLE GDD_GO.especialidades_por_profesional
(
	 id_profesional int
	,id_especialidad numeric(18,0)
	,foreign key (id_profesional) references GDD_GO.profesional(id_profesional)
	,foreign key (id_especialidad) references GDD_GO.especialidad(id_especialidad)	 
)

CREATE TABLE GDD_GO.agenda
(
	 id_dia_agenda int identity(1,1)
	,desc_dia int
	,desc_hora_desde TIME
	,desc_hora_hasta TIME
	,id_profesional int
	,id_especialidad numeric(18,0)
	,primary key (id_dia_agenda)
	,foreign key (id_profesional) references GDD_GO.profesional(id_profesional)
	,foreign key (id_especialidad) references GDD_GO.especialidad(id_especialidad)
)

CREATE TABLE GDD_GO.turno
(
	 id_turno numeric(18,0)
	,desc_estado BIT
	,id_afiliado int
	,id_profesional int
	,primary key (id_turno)
	,foreign key (id_afiliado) references GDD_GO.afiliado(id_afiliado)
	,foreign key (id_profesional) references GDD_GO.profesional(id_profesional)
)

CREATE TABLE GDD_GO.horario
(
	id_horario int identity(1,1)
	,desc_hora_desde DATETIME
	,id_dia_agenda int
	,id_turno numeric(18,0)
	,primary key (id_horario)
	,foreign key (id_dia_agenda) references GDD_GO.agenda(id_dia_agenda)
	,foreign key (id_turno) references GDD_GO.turno(id_turno)
)

CREATE TABLE GDD_GO.consulta
(
	 id_consulta int identity(1,1)
	,id_turno numeric(18,0)
	,id_bono int
	,desc_sintomas VARCHAR(255)
	,desc_enfermedades VARCHAR (255)
	,desc_hora_llegada DATETIME
	,desc_hora_consulta DATETIME
	,primary key (id_consulta)
	,foreign key (id_turno) references GDD_GO.turno
	,foreign key (id_bono) references GDD_GO.bono
)

CREATE TABLE GDD_GO.tipo_cancelacion
(
	 id_tipo_cancelacion int identity(1,1)
	,descripcion varchar(255)
	,id_turno numeric(18,0)
	,primary key (id_tipo_cancelacion)
	,foreign key (id_turno) references GDD_GO.turno(id_turno)
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

If exists (select 'existe' From sys.objects where type = 'TR' AND name = 'insertar_afiliado')
	Drop trigger GDD_GO.insertar_afiliado
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
		@estado = us.desc_estado
From GDD_GO.usuario us
Where us.desc_username = @user

if (@usuario = 0)
	Select 'invalido' as mensaje
else
	if (@estado = 2)
		Select 'inhabilitado' as mensaje
	else
	Begin
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
	End
Go


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
		 SUBSTRING(Paciente_Mail,1 ,CHARINDEX('@',Paciente_Mail)-1)
		,HASHBYTES('sha2_256',SUBSTRING(Paciente_Mail,1 ,CHARINDEX('_',Paciente_Mail)-1))
		,'Afiliado'
		,Paciente_Dni
From gd_esquema.Maestra
Where Paciente_Dni is not null

Insert Into #usuarios 	(	 username
							,password
							,entidad
							,id_entidad	)
Select	 Distinct
		 SUBSTRING(Medico_Mail,1 ,CHARINDEX('@',Medico_Mail)-1)
		,HASHBYTES('sha2_256',SUBSTRING(Medico_Mail,1 ,CHARINDEX('_',Medico_Mail)-1))
		,'Profesional'
		,Medico_Dni
From gd_esquema.Maestra
Where Medico_Dni is not null

/*USUARIO*/

Insert into GDD_GO.usuario	(	desc_username
							   ,desc_password
							   ,desc_estado	)
Select us.username
	  ,us.password
	  ,1
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
									,desc_tipo_doc
									,desc_dni
									,desc_direccion
									,desc_telefono
									,desc_mail
									,desc_fecha_nac		)
Select Distinct
	   us.id
	  ,ma.Medico_Apellido
	  ,ma.Medico_Nombre
	  ,'DNI'
	  ,ma.Medico_Dni
	  ,ma.Medico_Direccion
	  ,ma.Medico_Telefono
	  ,ma.Medico_Mail
	  ,ma.Medico_Fecha_Nac
From gd_esquema.Maestra ma
Join #usuarios us
	 on us.id_entidad = ma.Medico_Dni And
	 Medico_Dni is not null
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
							 ,id_usuario		)
Select	 Distinct      
		 id*100+1
		,ma.Paciente_Nombre
		,ma.Paciente_Apellido
		,1
		,'DNI'
		,ma.Paciente_Dni
		,ma.Paciente_Mail
		,ma.Paciente_Direccion
		,ma.Paciente_Telefono
		,0
		,GETDATE()
		,ma.Paciente_Fecha_Nac
		,us.id
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
/*TURNO*/
Insert into GDD_GO.turno	(	id_turno
							   ,id_afiliado
							   ,id_profesional	)
Select Turno_Numero, af.id_afiliado, pr.id_profesional
From gd_esquema.Maestra
join GDD_GO.afiliado af
	 On Paciente_Dni = af.desc_dni
join GDD_GO.profesional pr
	 On Medico_Dni = pr.desc_dni
Where Turno_Numero is not null And Consulta_Sintomas is null

Go
/*Horario*/
Insert into GDD_GO.horario(
	id_turno
	,desc_hora_desde
)
Select Turno_Numero, Turno_Fecha
From gd_esquema.Maestra
join GDD_GO.afiliado af
	 On Paciente_Dni = af.desc_dni
join GDD_GO.profesional pr
	 On Medico_Dni = pr.desc_dni
Where Turno_Numero is not null And Consulta_Sintomas is not null

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
/*Tipo_Bono*/
Insert into GDD_GO.tipo_bono(
	id_plan_medico
	,desc_precio_bono_consulta
	,desc_precio_bono_farmacia
)
Select distinct 
	p.id_plan_medico,
	m.Plan_Med_Precio_Bono_Consulta,
	m.Plan_Med_Precio_Bono_Farmacia
From GDD_GO.plan_medico p
join gd_esquema.Maestra m	on m.Plan_Med_Codigo = p.id_plan_medico
where m.Bono_Consulta_Numero is not null

Go
/*Planes x Afiliados*/
Insert into GDD_GO.planes_por_afiliado(
	id_plan_medico,
	id_afiliado
)
Select	m.Plan_Med_Codigo, a.id_afiliado
From gd_esquema.Maestra m
join GDD_GO.afiliado a
	On  a.desc_dni = m.Paciente_Dni

Go
/*Bonos*/
Insert into GDD_GO.bono(
	id_bono,
	id_afiliado,
	id_tipo_bono,
	desc_cantidad,
	fecha_compra,
	fecha_impresion
)
Select	m.Bono_Consulta_Numero, a.id_afiliado,t.id_tipo_bono,1,m.Compra_Bono_Fecha,m.Bono_Consulta_Fecha_Impresion
From gd_esquema.Maestra m 
join GDD_GO.afiliado a
	On  a.desc_dni = m.Paciente_Dni
join GDD_GO.tipo_bono t
	On	t.id_plan_medico = m.Plan_Med_Codigo
Where	m.Bono_Consulta_Numero is not NULL 
and		m.Compra_Bono_Fecha is not NULL 

Go
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
		h.desc_hora_desde,
		h.desc_hora_desde,
		t.id_turno,
		m.Bono_Consulta_Numero
from gd_esquema.Maestra m
join GDD_GO.afiliado a				ON a.desc_dni = m.Paciente_Dni
join GDD_GO.turno t					ON a.id_afiliado = t.id_afiliado and t.id_turno = m.Turno_Numero
join GDD_GO.horario h				ON h.id_turno = t.id_turno
where	m.Consulta_Enfermedades is not null
and		m.Consulta_Sintomas is not null

--Genero usuario de sistema por script
Insert into GDD_GO.usuario	(	 desc_username
				
								,desc_password
								,desc_estado	)
Values	 ('admin', HASHBYTES('sha2_256', 'w23e'), 1)
Go

Create Trigger GDD_GO.insertar_afiliado
On GDD_GO.afiliado
Instead of Insert
As
Begin
	Declare @id_afiliado int
	Declare @nombre varchar(255)
	Declare @apellido varchar(255)
	Declare @sexo bit
	Declare @tipo_doc nvarchar(5)
	Declare @dni numeric(18,0)
	Declare @mail varchar(255)
	Declare @direccion varchar(255)
	Declare @telefono numeric(18,0)
	Declare @estado_civil int
	Declare @fecha_nac datetime
	Declare @id_familiar_ppal int
	Declare @id_usuario int

	Select @nombre = desc_nombre, @apellido = desc_apellido, @sexo = desc_sexo, @tipo_doc = desc_tipo_doc, @dni=desc_dni, @mail=desc_mail, @direccion = desc_direccion, @telefono=desc_telefono, @estado_civil = desc_estado_civil, @fecha_nac = desc_fecha_nac, @id_familiar_ppal=id_familiar_principal, @id_usuario = id_usuario
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
									 ,id_usuario		)
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
				   ,@id_usuario			)


End
Go
