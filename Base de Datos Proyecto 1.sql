USE [Proyecto]

----------------------------------------------------------- CREACION DE TABLAS -----------------------------------------------------------

----------------------------- TABLAS ENTIDADES FUERTES -------------------------------

--1. TABLA POKEMOM--
create table pokemon (
	id int identity(1,1) NOT NULL unique, --AUTOINCREMENTO--
	nombre varchar(50) NOT NULL unique,
	id_tipo varchar(30),
	cod_tipo varchar(30),
	total int NOT NULL,
	salud int NOT NULL,
	ataque int NOT NULL,
	defensa int NOT NULL,
	ataque_especial int NOT NULL,
	defensa_especial int NOT NULL,
	velocidad int,
	generacion int,
	legendario Varchar(20) NOT NULL CHECK(Legendario = 'True' or Legendario = 'False'),
	foto image,
	primary key (id),
)



-- 2. TABLA MOVIMIENTOS--
create table movimiento(
	cod_movimiento varchar(10),
	descripcion varchar(100),
	nombre varchar(50),
	tipo varchar(50),

	primary key (cod_movimiento), 
)


-- 3. TABLA USUARIOS--
CREATE TABLE usuario(
	Nombre_Usuario varchar (30) NOT NULL unique,
	contraseña varbinary (max) NOT NULL,
	llave varchar(max) NOT NULL,
	rol varchar (20) NOT NULL check(rol = 'Administrador' or rol = 'Cliente' or rol = 'Entrenador'),
	
	primary key(Nombre_Usuario)
	)



-- 3.1 TABLA ENTRENADOR --
create table entrenador(
	id_entrenador varchar(10) NOT NULL unique,
	nombre_entrenador varchar (30) NOT NULL,
	calificacion int NOT NULL check (calificacion >= 0 and calificacion <= 100),
	telefono_entrenador int NOT NULL,
	correo_electrónico varchar(30) NOT NULL check(correo_electrónico like '%@%'),
	sitio_web varchar(50) check(sitio_web like '%.com%'),
	provincia varchar(30) NOT NULL,
	cantón varchar(30) NOT NULL,
	distrito varchar (30) NOT NULL,
	ubicación varchar(30),
	nombre_usuario varchar (30),

	primary key (id_entrenador),
	foreign key (nombre_usuario) references usuario(nombre_usuario) on delete cascade on update cascade,
)

-- 3.2 TABLA CLIENTE --
create table cliente(
	id_cliente varchar(10) NOT NULL unique,
	nombre_cliente varchar(30) NOT NULL,
	telefono_cliente int NOT NULL,
	correo_electrónico varchar(30) NOT NULL check(correo_electrónico like '%@%'),
	sitio_web varchar(50)check(sitio_web like '%.com%'),
	provincia varchar(30) NOT NULL,
	cantón varchar(30) NOT NULL,
	distrito varchar (30) NOT NULL,
	ubicación varchar(30),
	nombre_usuario varchar (30),

	primary key (id_cliente),
	foreign key (nombre_usuario) references usuario(nombre_usuario) on delete cascade on update cascade,
)




----------------------------- TABLAS ENTIDADES DEBILES ENTRENADOR -------------------------------

-- TABLA BITACORA --
create table bitacora(
	fecha date NOT NULL,  
	descripcion nvarchar(max) NOT NULL,
	id_entrenador varchar(10) NOT NULL,
	foreign key (id_entrenador) references entrenador(id_entrenador) on delete cascade on update cascade,
)
SET dateformat dmy;


-- TABLA REDES SOCIALES --
create table red_social(
	red_social varchar(20) NOT NULL check(red_social = 'Facebook' or red_social = 'Instagram' or red_social = 'Twitter'),
	nombre_usuario varchar(20) NOT NULL,
	id_entrenador varchar(10) NOT NULL,
	foreign key (id_entrenador) references entrenador(id_entrenador) on delete cascade on update cascade,
)



-------------------------------------- TABLAS INTERMEDIAS --------------------------------------


---GMAPS EN USUARIOS---

Create table Registrar_GMaps(
	Nombre_Usuario varchar (30) NOT NULL unique,
	Ubicacion nvarchar(MAX) NOT NULL,
	Latitud nvarchar(500) NOT NULL,
	Logintud nvarchar(50) NOT NULL,
	foreign key (Nombre_usuario) references usuario(Nombre_usuario) on delete cascade on update cascade,
)
-- TABLA INTERMEDIA ENTRE MOVIMIENTO Y POKEMON--
create table intermedia_MovimientoPokemon(
	id_pokemon int NOT NULL,
	cod_movimiento varchar(10) NOT NULL,

	foreign key (id_pokemon) references pokemon (id) on delete cascade on update cascade,
	foreign key (cod_movimiento) references  movimiento (cod_movimiento) on delete cascade on update cascade,
)



-- TABLA INTERMEDIA ENTRE ENTRENADOR Y POKEMON--
create table intermedia_EntrenadorPokemon(
	id_entrenador varchar(10) NOT NULL,
	id_pokemon int NOT NULL,
	estado varchar(30) NOT NULL check(estado = 'En equipo' or estado = 'En reserva' or estado = 'Liberado'),

	foreign key(id_entrenador) references entrenador(id_entrenador) on delete cascade on update cascade,
	foreign key(id_pokemon) references pokemon (id) on delete cascade on update cascade,
)


-- TABLA INTERMEDIA ENTRE MOVIMIENTO, ENTRENADOR Y POKEMON--
create table intermedia_PokemonMovimientoEntrenador(
	id_entrenador varchar(10) NOT NULL,
	id_pokemon int NOT NULL,
	cod_movimiento varchar(10) NOT NULL,
	
	foreign key (id_entrenador) references Entrenador(id_entrenador) on delete cascade on update cascade,
	foreign key (id_pokemon) references pokemon (id) on delete cascade on update cascade,
	foreign key (cod_movimiento) references Movimiento (cod_movimiento) on delete cascade on update cascade,
)

---------------------------------------ENCRIPTAR/ DESENCRIPTAR CONTRASEÑA ---------------------------------------------
--3.0.1 ENCRIPTAR CONTRASEÑAR

CREATE PROC InsertUs_clave
	@nombre_usuario varchar(30),
	@pss varchar(max),
	@llave varchar(max),
	@rol varchar (20)
	
AS
	declare
	@pssb varbinary(max)
BEGIN
	set @pssb = (ENCRYPTBYPASSPHRASE(@llave, @pss));
	INSERT INTO usuario values (@nombre_usuario, @pssb, @llave, @rol )
END

-------------------------------------------------- INSERCIONES EN LA BASE DE DATOS --------------------------------------------------
--------------------------- INSERCIONES DE ENTIDADES FUERTES ---------------------------

--INSERTAR POKEMON A LA BASE DE DATOS (700)
INSERT INTO pokemon([nombre],[id_tipo],[cod_tipo],[total],[salud],[ataque],[defensa],[ataque_especial],[defensa_especial],[velocidad],[generacion],[legendario],[foto]) VALUES ('Bulbasaur','T-010','T-014',318,45,49,49,65,65,45,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\001.png'), ('Ivysaur','T-010','T-014',405,60,62,63,80,80,60,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\002.png'),('Venusaur','T-010','T-014',525,80,82,83,100,100,80,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\003.png'),('Charmander','T-007','T-010',39,52,43,60,50,65,1,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\004.png'),('Charmeleon','T-007','T-007',405,58,64,58,80,65,80,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\005.png'),('Charizard','T-007','T-008',534,78,84,78,109,85,100,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\006.png'),('Squirtle','T-018','T-018',314,44,48,65,50,64,43,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\007.png'),('Wartortle','T-018','T-018',405,59,63,80,65,80,58,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\008.png'),('Blastoise','T-018','T-018',530,79,83,100,85,105,78,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\009.png'),('Caterpie','T-001','T-001',195,45,30,35,20,20,45,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\010.png'),('Metapod','T-001','T-001',205,50,20,55,25,25,30,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\INSERTE.png'),('Butterfree','T-001','T-008',395,60,45,50,90,80,70,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\INSERTE.png'),('Weedle','T-001','T-014',195,40,35,30,20,20,50,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\INSERTE.png'),('Kakuna','T-001','T-014',205,45,25,50,25,25,35,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\INSERTE.png'),('Beedrill','T-001','T-014',395,65,90,40,45,80,75,1,'False','D:\Documentos\GitHub\PROYECTO1\pokemon\INSERTE.png');
SELECT * FROM pokemon

--INSERTAR MOVIMIENTOS A LA BASE DE DATOS
 BULK INSERT movimiento from 'D:\Documentos\GitHub\PROYECTO1\Carga_Pokemon_Movimientos.txt' with (firstrow = 1, fieldterminator = ',', rowterminator = '\n');
 SELECT * FROM movimiento



--INSERTAR USUARIOS ADMINISTRADORES
EXEC InsertUs_clave 'fabyAdmi', 'faby1234', '123', 'Administrador'
EXEC InsertUs_clave 'fioAdmi', 'fio1234', '456', 'Administrador'
EXEC InsertUs_clave 'ranAdmi', 'ran1234', '789','Administrador'
EXEC InsertUs_clave 'pedroAdmi', 'pedro1234','1011', 'Administrador'
--INSERTAR USUARIOS ENTRENADORES
EXEC InsertUs_clave 'anaEntrenador', 'ana1234','1213', 'Entrenador'
EXEC InsertUs_clave 'joseEntrenador', 'jose1234','0908','Entrenador'
EXEC InsertUs_clave 'marioEntrenador', 'mario1234','1238', 'Entrenador'
EXEC InsertUs_clave 'isabelEntrenador', 'isabel1234','0905','Entrenador'
EXEC InsertUs_clave 'juanEntrenador', 'juan1234', '113','Entrenador'
EXEC InsertUs_clave 'marcoEntrenador', 'marco1234', '173','Entrenador'
EXEC InsertUs_clave 'carlosEntrenador', 'carlos1234','111', 'Entrenador'
EXEC InsertUs_clave 'gabrielEntrenador', 'gabriel1234','333', 'Entrenador'
--INSERTAR USUARIOS CLIENTE
EXEC InsertUs_clave 'paolaCliente', 'paola1234','443', 'Cliente'
EXEC InsertUs_clave 'franciscoCliente', 'francisco1234','000', 'Cliente'
EXEC InsertUs_clave 'marcelaCliente', 'marcela1234','130', 'Cliente'
EXEC InsertUs_clave 'manuelCliente', 'manuel1234','109', 'Cliente'
SELECT * FROM usuario;


--INSERTAR ENTRENADORES A LA BASE DE DATOS
INSERT INTO entrenador VALUES (1, 'Ana', 60, 88127687, 'ana@gmail.com','anaEntrenador.com', 'Cartago', 'Paraiso', 'Birrisito',null, 'anaEntrenador');
INSERT INTO entrenador VALUES (2, 'Jose', 80, 76238798, 'jose@gmail.com','joseEntrenador.com', 'Cartago', 'Turrialba', 'Pavones',null, 'joseEntrenador');
INSERT INTO entrenador VALUES (3, 'Mario', 12, 87126409,  'mario@gmail.com','marioEntrenador.com', 'Cartago', 'Oreamuno', 'Cot',null, 'marioEntrenador');
INSERT INTO entrenador VALUES (4, 'isabel', 65, 67349823, 'isabel@gmail.com','isabelEntrenador.com', 'San Jose', 'Goicoechea', 'Guadalupe',null, 'isabelEntrenador');
INSERT INTO entrenador VALUES (5, 'Juan', 22, 76239812, 'juan@gmail.com','juanEntrenador.com', 'San Jose', 'Dota', 'Copey',null, 'juanEntrenador');
INSERT INTO entrenador VALUES (6, 'Marco', 39, 67340923, 'marco@gmail.com','marcoEntrenador.com', 'Heredia', 'Flores', 'Llorente',null, 'marcoEntrenador');
INSERT INTO entrenador VALUES (7, 'Carlos', 67, 87230945, 'carlos@gmail.com','carlosEntrenador.com', 'Heredia', 'Barva', 'Barva',null, 'carlosEntrenador');
INSERT INTO entrenador VALUES (8, 'Gabriel', 48, 81903746, 'gabriel@gmail.com','gabrielEntrenador.com', 'Alajuela', 'Atenas', 'Mercedes',null, 'gabrielEntrenador');
select * from entrenador


--INSERTAR CLIENTES A LA BASE DE DATOS
INSERT INTO cliente VALUES (1, 'Paola', 87126547, 'paola@gmail.com','paolaCliente.com', 'Guanacaste', 'Abangares', 'Colorado',null, 'paolaCliente');
INSERT INTO cliente VALUES (2, 'Francisco', 87129037, 'francisco@gmail.com','franciscoCliente.com', 'Puntarenas', 'Osa', 'Palmar',null, 'franciscoCliente');
INSERT INTO cliente VALUES (3, 'Marcela', 76235698, 'marcela@gmail.com','marcelaCliente.com', 'Alajuela', 'Palmares', 'Santiago',null, 'marcelaCliente');
INSERT INTO cliente VALUES (4, 'Manuel', 67980912, 'manuel@gmail.com','manuelCliente.com', 'Cartago', 'Alvarado', 'Pacayas',null, 'manuelCliente');
select * from cliente




--------------------------- INSERCIONES DE ENTIDADES DEBILES ---------------------------

--INSERTAR BITACORAS DE ENTRENADORES A LA BASE DE DATOS
INSERT INTO bitacora VALUES ('17-05-21', 'Empieza como entrenador', 1);
INSERT INTO bitacora VALUES ('19-05-21', 'Libera uno de sus pokemones', 6);
INSERT INTO bitacora VALUES ('18-05-21', 'Caza un nuevo pokemon', 3);
select * from bitacora


--INSERTAR REDES SOCIALES DE ENTRENADORES A LA BASE DE DATOS
INSERT INTO red_social VALUES ('Instagram', 'anaInstragram', 1);
INSERT INTO red_social VALUES ('Facebook', 'anaFacebook', 1);
INSERT INTO red_social VALUES ('Facebook', 'marcoFacebook', 6);
INSERT INTO red_social VALUES ('Twitter', 'marioTwitter', 3);
select * from red_social



--------------------------- INSERCIONES DE TABLAS INTERMEDIAS ---------------------------

--INSERTAR RELACION POKEMON-MOVIMIENTO A LA BASE DE DATOS
INSERT INTO intermedia_MovimientoPokemon VALUES (1, 'M-001');
INSERT INTO intermedia_MovimientoPokemon VALUES (5, 'M-010');
INSERT INTO intermedia_MovimientoPokemon VALUES (4, 'M-015');
INSERT INTO intermedia_MovimientoPokemon VALUES (3, 'M-003');
INSERT INTO intermedia_MovimientoPokemon VALUES (6, 'M-003');
INSERT INTO intermedia_MovimientoPokemon VALUES (2, 'M-004');
INSERT INTO intermedia_MovimientoPokemon VALUES (7, 'M-009');
INSERT INTO intermedia_MovimientoPokemon VALUES (8, 'M-019');
INSERT INTO intermedia_MovimientoPokemon VALUES (9, 'M-016');
INSERT INTO intermedia_MovimientoPokemon VALUES (10, 'M-011');
INSERT INTO intermedia_MovimientoPokemon VALUES (11, 'M-016');
INSERT INTO intermedia_MovimientoPokemon VALUES (12, 'M-010');
INSERT INTO intermedia_MovimientoPokemon VALUES (13, 'M-006');
INSERT INTO intermedia_MovimientoPokemon VALUES (14, 'M-001');
INSERT INTO intermedia_MovimientoPokemon VALUES (15, 'M-002');
SELECT * FROM intermedia_MovimientoPokemon



--INSERTAR RELACION POKEMON-ENTRENADOR EN EQUIPO
INSERT INTO intermedia_EntrenadorPokemon VALUES (1, 1, 'En equipo');
INSERT INTO intermedia_EntrenadorPokemon VALUES (1, 4, 'En equipo');
INSERT INTO intermedia_EntrenadorPokemon VALUES (4, 3, 'En equipo');
INSERT INTO intermedia_EntrenadorPokemon VALUES (8, 5, 'En equipo');
INSERT INTO intermedia_EntrenadorPokemon VALUES (8, 9, 'En equipo');
--INSERTAR RELACION POKEMON-ENTRENADOR EN RESERVA
INSERT INTO intermedia_EntrenadorPokemon VALUES (5, 7, 'En reserva');
INSERT INTO intermedia_EntrenadorPokemon VALUES (5, 2, 'En reserva');
INSERT INTO intermedia_EntrenadorPokemon VALUES (4, 11, 'En reserva');
INSERT INTO intermedia_EntrenadorPokemon VALUES (4, 12, 'En reserva');
INSERT INTO intermedia_EntrenadorPokemon VALUES (3, 13, 'En reserva');
--INSERTAR RELACION POKEMON-ENTRENADOR LIBERADO
INSERT INTO intermedia_EntrenadorPokemon VALUES (2, 6, 'Liberado');
INSERT INTO intermedia_EntrenadorPokemon VALUES (7, 8, 'Liberado');
INSERT INTO intermedia_EntrenadorPokemon VALUES (2, 14, 'Liberado');
INSERT INTO intermedia_EntrenadorPokemon VALUES (3, 15, 'Liberado');
INSERT INTO intermedia_EntrenadorPokemon VALUES (6, 10, 'Liberado');
SELECT * FROM intermedia_EntrenadorPokemon



--INSERTAR RELACION POKEMON-MOVIMIENTO-ENTRENADOR A LA BASE DE DATOS
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (1, 1, 'M-001');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (8, 5, 'M-010');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (5, 7, 'M-009');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (5, 2, 'M-004');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (2, 6, 'M-003');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (7, 8, 'M-019');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (1, 4, 'M-015');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (4, 3, 'M-003');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (8, 9, 'M-016');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (4, 11, 'M-016');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (4, 12, 'M-010');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (3, 13, 'M-006');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (2, 14, 'M-001');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (3, 15, 'M-002');
INSERT INTO intermedia_PokemonMovimientoEntrenador VALUES (6, 10, 'M-011');
SELECT * FROM intermedia_PokemonMovimientoEntrenador

-----AUTENTICAR USUARIO ----
CREATE PROCEDURE [LoginUsuario] 
	@username VARCHAR(30),
	@rol VARCHAR(30),
   @contraseña NVARCHAR(max)
AS
BEGIN
    SELECT Nombre_Usuario FROM usuario WHERE Nombre_Usuario = @username AND rol = @rol AND CONVERT(VARCHAR(max), DECRYPTBYPASSPHRASE(Llave,contraseña)) = @contraseña
		
END
GO
--EXEC [LoginUsuario] 'anaEntrenador', 'Entrenador', 'ana1234'
SELECT * FROM usuario