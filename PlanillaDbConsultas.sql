-- Crear empleado --
INSERT INTO 
empleados(
	nombre,
	apellido,
	edad,
	genero,
	fecha_nacimiento,
	estado_civil,
	nivel_academico,
	dui,
	nit,
	nup,
	isss,
	telefono,
	area_laboral ,
	sueldo_nominal,
	estado)
VALUES(
    'Jerundio Getsemani',
    'Ruanda Lopez',
    '26',
    'M',
    '19-12-1991',
    'Casado',
    'Universitario - Psicologo',
    '050708520',
    '14526743895163',
    '8978978798',
    'ugu877y87y8',
    11112222,
    'Limpieza',
    275.32,
    2
)

---Crear Descuento y tipo--

INSERT INTO 
descuentos_barios_tipos(
    nombre_descuento
)
VALUES(
    'Danio a infraestructura'
)



INSERT INTO 
descuentos_barios(
    id_empleado,
	id_decuento_tipo,
	monto_descuento,
	fecha_aplicacion
)
VALUES(
    1,
    1,
    20.50,
    '12-12-12'
)

--- Crear otros Ingresos y tipo ---

INSERT INTO 
otros_ingresos_tipo(
    nombre
)
VALUES(
    'Horas Extras'
)


INSERT INTO 
otros_ingresos(
    id_empleado,
	id_tipo_ingreso,
	monto,
	fecha_aplicacion
)
VALUES(
    1,
    1,
    60.75,
    '15-12-12'
)

-- Crear planilla --

INSERT INTO 
planilla_mensual(
    fecha_planilla
)
VALUES(
    '1-12-12'
)

INSERT INTO
planilla_mensual_detalle(
    id_planilla_mensual,
	id_empleado,
	otros_ingresos_total,
	descuento_isss_total,
	descuento_afp_total,
	descuento_barios_total,
	descuento_renta_total,
	sueldo_liquido
)
VALUES(
    1,
    1,
    60.75,
    12.32,
    6.25,
    20.50,
    40.56,
    200.00
)

-- Crear roles y usuarios --

INSERT INTO
rol(
    nombre
)
VALUES(
    'Administrador'
)

INSERT INTO
usuarios(
    id_empleado,
	id_rol,
	nombre_usuario,
	password_usuario
)
VALUES(
    1,
    1,
    'masterball',
    '12345678'
)