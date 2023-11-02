CREATE DATABASE ForestalDB;
USE ForestalDB;

DROP TABLE IF EXISTS dbo.CUATRIMESTRE;
CREATE TABLE dbo.CUATRIMESTRE (
	idCuatrimestre int NOT NULL IDENTITY(1,1),
	nombreCuatrimestre varchar(25) NOT NULL,
	PRIMARY KEY (idCuatrimestre)
);

DROP TABLE IF EXISTS dbo.CAMBIOSOL;
CREATE TABLE dbo.CAMBIOSOL (
    idCambioSol int NOT NULL IDENTITY(1,1),
    nombreCambio varchar(55) NOT NULL,
    PRIMARY KEY (idCambioSol)
);

DROP TABLE IF EXISTS dbo.ARBOL;
CREATE TABLE dbo.ARBOL (
    idArbol int NOT NULL IDENTITY(1,1),
    nombreCicloArbol varchar(35) NOT NULL,
    PRIMARY KEY (idArbol)
);

DROP TABLE IF EXISTS dbo.TIEMPO;
CREATE TABLE dbo.TIEMPO (
    idTiempo int NOT NULL IDENTITY(1,1),
    nombreTiempo varchar(13) NOT NULL,
    PRIMARY KEY (idTiempo)
);

DROP TABLE IF EXISTS dbo.EPOCA;
CREATE TABLE dbo.EPOCA (
    idEpoca int NOT NULL IDENTITY(1,1),
    nombreEpoca varchar(8) NOT NULL,
    PRIMARY KEY (idEpoca)
);

DROP TABLE IF EXISTS dbo.FASELUNAR;
CREATE TABLE dbo.FASELUNAR (
    idFaseLunar int NOT NULL IDENTITY(1,1),
    nombreFaseLunar varchar(20) NOT NULL,
    PRIMARY KEY (idFaseLunar)
);

DROP TABLE IF EXISTS dbo.ACTIVIDAD;
CREATE TABLE dbo.ACTIVIDAD(
    idActividad int NOT NULL IDENTITY(1,1),
    nombreActividad varchar(120) NOT NULL,
	descripcion varchar(2000) NOT NULL,
	PRIMARY KEY (idActividad)
);

DROP TABLE IF EXISTS dbo.REGISTRO;
CREATE TABLE REGISTRO (
    idRegistro int NOT NULL IDENTITY(1,1),
    fecha datetime NOT NULL,
    idFaseLunar int NOT NULL,
    idEpoca int NOT NULL,
    idTiempo int NOT NULL,
    idArbol int NOT NULL,
    idCambioSol int NOT NULL,
    idCuatrimestre int NOT NULL,
    PRIMARY KEY (idRegistro),
    FOREIGN KEY (idFaseLunar) REFERENCES dbo.FASELUNAR (idFaseLunar),
    FOREIGN KEY (idEpoca) REFERENCES dbo.EPOCA (idEpoca),
    FOREIGN KEY (idTiempo) REFERENCES dbo.TIEMPO (idTiempo),
    FOREIGN KEY (idArbol) REFERENCES dbo.ARBOL (idArbol),
    FOREIGN KEY (idCambioSol) REFERENCES dbo.CAMBIOSOL (idCambioSol),
    FOREIGN KEY (idCuatrimestre) REFERENCES dbo.CUATRIMESTRE (idCuatrimestre)
);

DROP TABLE IF EXISTS dbo.LISTACTIVIDAD;
CREATE TABLE dbo.LISTACTIVIDAD(	
	idListaActividad int NOT NULL IDENTITY(1,1),
    idRegistro int NOT NULL,
    idActividad int NOT NULL,
	PRIMARY KEY (idListaActividad),
	FOREIGN KEY (idRegistro) REFERENCES dbo.REGISTRO (idRegistro),
    FOREIGN KEY (idActividad) REFERENCES dbo.ACTIVIDAD (idActividad),
);
