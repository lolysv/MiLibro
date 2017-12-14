CREATE DATABASE db_planilla

USE db_planilla

---------------------------------------------------
---- Tabla empleados-------------------------------
---------------------------------------------------
CREATE TABLE empleados
(
	id INT identity (1,1) PRIMARY KEY,
	nombre VARCHAR (30),
	apellido VARCHAR (30),
	edad INT,
	genero VARCHAR (10),
	fecha_nacimiento DATE,
	estado_civil VARCHAR (12),
	nivel_academico VARCHAR (80),
	dui VARCHAR(10),
	nit VARCHAR(30),
	nup VARCHAR(30),
	isss VARCHAR(30),
	telefono INT,
	area_laboral VARCHAR (80),
	sueldo_nominal DECIMAL(8, 3),
	estado INT,
	fecha_registro DATETIME default getdate()
)


----------------------------------------------------------
---- Tipo de descuento bario y tabla donde se aplican ----
----------------------------------------------------------

CREATE TABLE descuentos_barios_tipos
(
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre_descuento VARCHAR(50)
)

CREATE TABLE descuentos_barios(
	id INT IDENTITY (1,1) PRIMARY KEY ,
	id_empleado INT,
	id_decuento_tipo INT,
	monto_descuento FLOAT,
	fecha_aplicacion DATE,
	CONSTRAINT fk_descuentos_barios 
	FOREIGN KEY (id_decuento_tipo) 
	REFERENCES descuentos_barios_tipos(id)
	ON DELETE CASCADE,
	CONSTRAINT fk_descuentos_empleado
	FOREIGN KEY (id_empleado)
	REFERENCES empleados(id)
	ON DELETE CASCADE
)

----------------------------------------------------
----- Otros Ingresos -------------------------------
----------------------------------------------------

CREATE TABLE otros_ingresos_tipo
(
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (50)
)

CREATE TABLE otros_ingresos
(
	id INT IDENTITY (1,1) PRIMARY KEY,
	id_empleado INT,
	id_tipo_ingreso INT,
	monto FLOAT,
	fecha_aplicacion DATE,
	CONSTRAINT fk_otros_ingresos_tipo 
	FOREIGN KEY (id_tipo_ingreso) 
	REFERENCES otros_ingresos_tipo(id)
	ON DELETE CASCADE,
	CONSTRAINT fk_otros_ingresos_usuario
	FOREIGN KEY (id_empleado)
	REFERENCES empleados(id)
	ON DELETE CASCADE

)

------------------------------------------------------
---------- Planilla General --------------------------
------------------------------------------------------

CREATE TABLE planilla_mensual(
	id INT IDENTITY (1,1) PRIMARY KEY,
	fecha_planilla DATE
)


CREATE TABLE planilla_mensual_detalle(
	id INT IDENTITY (1,1) PRIMARY KEY,
	id_planilla_mensual INT,
	id_empleado INT,
	otros_ingresos_total FLOAT,
	descuento_isss_total  FLOAT,
	descuento_afp_total FLOAT,
	descuento_barios_total FLOAT,
	descuento_renta_total FLOAT,
	sueldo_liquido FLOAT,
	CONSTRAINT fk_planilla_mensual_detalle
	FOREIGN KEY (id_planilla_mensual)
	REFERENCES planilla_mensual(id)
	ON DELETE CASCADE,
	CONSTRAINT fk_planilla_mensual_detalle_empleado
	FOREIGN KEY (id_empleado)
	REFERENCES empleados(id)
	ON DELETE CASCADE
)

------------------------------------------
---	Usuarios y roles ---------------------
------------------------------------------

CREATE TABLE rol (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR(50)
)

CREATE TABLE usuarios(
	id INT IDENTITY (1,1) PRIMARY KEY,
	id_empleado INT,
	id_rol INT,
	nombre_usuario VARCHAR(50),
	password_usuario VARCHAR(32)
	CONSTRAINT fk_usuario_empleado
	FOREIGN KEY (id_empleado)
	REFERENCES empleados(id)
	ON DELETE CASCADE,
	CONSTRAINT fk_usuario_rol
	FOREIGN KEY (id_rol)
	REFERENCES rol(id)
	ON DELETE CASCADE
)


