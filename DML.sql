--Cuatrimestre
INSERT INTO Cuatrimestre VALUES ('Primer Cuatrimestre');
INSERT INTO Cuatrimestre VALUES ('Segundo Cuatrimestre');
INSERT INTO Cuatrimestre VALUES ('Tercer Cuatrimestre');

--Cambio de Sol--
INSERT INTO CambioSol VALUES ('Solsticio');
INSERT INTO CambioSol VALUES ('Equinoccio');

--Ciclo de Vida de ARBOL--
INSERT INTO ARBOL VALUES ('1er Ciclo Masculino del Árbol');
INSERT INTO ARBOL VALUES ('2do Ciclo Masculino del Árbol');
INSERT INTO ARBOL VALUES ('1er Ciclo Femenino del Árbol');
INSERT INTO ARBOL VALUES ('2do Ciclo Femenino del Árbol');	

--TIEMPO--
INSERT INTO TIEMPO VALUES ('Sequía');
INSERT INTO TIEMPO VALUES ('Lluvioso');

-- EPOCA
INSERT INTO EPOCA VALUES ('Frío');
INSERT INTO EPOCA VALUES ('Calor');
INSERT INTO EPOCA VALUES ('Húmedo');
INSERT INTO EPOCA VALUES ('Viento');

-- Fase Lunar
INSERT INTO FASELUNAR VALUES ('Cuarto Creciente');
INSERT INTO FASELUNAR VALUES ('Luna Llena');
INSERT INTO FASELUNAR VALUES ('Cuarto Menguante');
INSERT INTO FASELUNAR VALUES ('Luna Nueva');

--Actividades
INSERT INTO ACTIVIDAD VALUES ('Colecta de semillas');
INSERT INTO ACTIVIDAD VALUES ('Colecta de material vegetativo');
INSERT INTO ACTIVIDAD VALUES ('Secado de semillas');
INSERT INTO ACTIVIDAD VALUES ('Siembra de semillas');
INSERT INTO ACTIVIDAD VALUES ('Manejo de germinación de semillas en viveros');
INSERT INTO ACTIVIDAD VALUES ('Trasplante de la plántula del semillero al vivero');
INSERT INTO ACTIVIDAD VALUES ('Limpieza del terreno definitivo');
INSERT INTO ACTIVIDAD VALUES ('Trazado y ahoyado');
INSERT INTO ACTIVIDAD VALUES ('Plantación o trasplante definitivo');
INSERT INTO ACTIVIDAD VALUES ('Plateo en plantación');
INSERT INTO ACTIVIDAD VALUES ('Replante por bajo prendimiento');
INSERT INTO ACTIVIDAD VALUES ('Construcción y mantenimiento de rondas corta fuego');
INSERT INTO ACTIVIDAD VALUES ('Manejo de plagas');
INSERT INTO ACTIVIDAD VALUES ('Limpia de árboles de plantas parásitas');
INSERT INTO ACTIVIDAD VALUES ('Chapias y/o chapear - limpia de la plantación y terreno');
INSERT INTO ACTIVIDAD VALUES ('Injertos en árboles frutales');
INSERT INTO ACTIVIDAD VALUES ('Podas de limpieza de árboles enfermos');
INSERT INTO ACTIVIDAD VALUES ('Podas de formación');
INSERT INTO ACTIVIDAD VALUES ('Podas de estimulo');
INSERT INTO ACTIVIDAD VALUES ('Raleo');
INSERT INTO ACTIVIDAD VALUES ('Aprovechamiento para leña y madera');
INSERT INTO ACTIVIDAD VALUES ('Primera Canícula');
INSERT INTO ACTIVIDAD VALUES ('Segunda Canícula');

--id, fecha (yyyy-dd-mm), idfaselunar, idepoca, idtiempo, idarbol, idcambiosol, idcuatrimestre
-- 2023

INSERT INTO REGISTRO VALUES ('2023-06-01',2,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-14-01',3,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-21-01',4,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-28-01',1,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-05-02',2,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-13-02',3,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-20-02',4,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-27-02',1,1,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-07-03',2,2,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-14-03',3,2,1,2,1,1);
INSERT INTO REGISTRO VALUES ('2023-21-03',4,2,1,2,2,1);
INSERT INTO REGISTRO VALUES ('2023-28-03',1,2,1,3,2,1);
INSERT INTO REGISTRO VALUES ('2023-05-04',2,2,1,3,2,1);
INSERT INTO REGISTRO VALUES ('2023-13-04',3,2,1,3,2,1);
INSERT INTO REGISTRO VALUES ('2023-19-04',4,2,1,3,2,1);
INSERT INTO REGISTRO VALUES ('2023-27-04',1,3,2,3,2,1);
INSERT INTO REGISTRO VALUES ('2023-05-05',2,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-12-05',3,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-19-05',4,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-27-05',1,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-03-06',2,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-10-06',3,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-17-06',4,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-26-06',1,3,2,3,2,2);
INSERT INTO REGISTRO VALUES ('2023-03-07',2,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-09-07',3,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-17-07',4,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-25-07',1,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-01-08',2,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-08-08',3,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-16-08',4,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-24-08',1,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-30-08',2,3,2,4,1,2);
INSERT INTO REGISTRO VALUES ('2023-06-09',3,3,2,4,1,3);
INSERT INTO REGISTRO VALUES ('2023-14-09',4,4,1,4,1,3);
INSERT INTO REGISTRO VALUES ('2023-22-09',1,4,1,4,2,3);
INSERT INTO REGISTRO VALUES ('2023-29-09',2,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-06-10',3,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-14-10',4,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-21-10',1,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-28-10',2,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-05-11',3,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-13-11',4,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-20-11',1,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-27-11',2,4,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-04-12',3,1,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-12-12',4,1,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-19-12',1,1,1,1,2,3);
INSERT INTO REGISTRO VALUES ('2023-26-12',2,1,1,1,2,3);

INSERT INTO LISTACTIVIDAD VALUES (1,1),(1,4),(1,5),(1,19),(1,20),(1,21);
INSERT INTO LISTACTIVIDAD VALUES (2,3),(2,5),(2,7),(2,10),(2,12),(2,14),(2,15),(2,17);
INSERT INTO LISTACTIVIDAD VALUES (3,6),(3,13),(3,18);
INSERT INTO LISTACTIVIDAD VALUES (4,2),(4,5),(4,6),(4,13),(4,16),(4,18),(4,19);
INSERT INTO LISTACTIVIDAD VALUES (5,1),(5,4),(5,5),(5,19),(5,20),(5,21);
INSERT INTO LISTACTIVIDAD VALUES (6,3),(6,5),(6,7),(6,10),(6,12),(6,14),(6,15),(6,17);
INSERT INTO LISTACTIVIDAD VALUES (7,6),(7,13),(7,18);
INSERT INTO LISTACTIVIDAD VALUES (8,2),(8,5),(8,6),(8,13),(8,16),(8,18),(8,19);
INSERT INTO LISTACTIVIDAD VALUES (9,1),(9,5),(9,19),(9,20),(9,21);
INSERT INTO LISTACTIVIDAD VALUES (10,3),(10,5),(10,7),(10,8),(10,10),(10,12),(10,14),(10,15),(10,17);
INSERT INTO LISTACTIVIDAD VALUES (11,13),(11,18);
INSERT INTO LISTACTIVIDAD VALUES (12,5),(12,13),(12,16),(12,18),(12,19);
INSERT INTO LISTACTIVIDAD VALUES (13,5),(13,19);
INSERT INTO LISTACTIVIDAD VALUES (14,3),(14,5),(14,7),(14,8),(14,10),(14,12),(14,14),(14,15),(14,17);
INSERT INTO LISTACTIVIDAD VALUES (15,13),(15,18);
INSERT INTO LISTACTIVIDAD VALUES (16,5),(16,13),(16,18),(16,19);
INSERT INTO LISTACTIVIDAD VALUES (17,5),(17,19);
INSERT INTO LISTACTIVIDAD VALUES (18,5),(18,12),(18,14),(18,15),(18,17);
INSERT INTO LISTACTIVIDAD VALUES (19,9),(19,11),(19,13),(19,18);
INSERT INTO LISTACTIVIDAD VALUES (20,9),(20,11),(20,13),(20,18),(20,19);
INSERT INTO LISTACTIVIDAD VALUES (21,19);
INSERT INTO LISTACTIVIDAD VALUES (22,12),(22,14),(22,15),(22,17);
INSERT INTO LISTACTIVIDAD VALUES (23,9),(23,11),(23,13),(23,18);
INSERT INTO LISTACTIVIDAD VALUES (24,9),(24,11),(24,13),(24,18),(24,19);
INSERT INTO LISTACTIVIDAD VALUES (25,19);
INSERT INTO LISTACTIVIDAD VALUES (26,12),(26,14),(26,15),(26,17),(26,21);
INSERT INTO LISTACTIVIDAD VALUES (27,9),(27,11),(27,13),(27,18),(27,21);
INSERT INTO LISTACTIVIDAD VALUES (28,9),(28,11),(28,13),(28,18),(28,19);
INSERT INTO LISTACTIVIDAD VALUES (29,19);
INSERT INTO LISTACTIVIDAD VALUES (30,12),(30,14),(30,15),(30,17),(30,22);
INSERT INTO LISTACTIVIDAD VALUES (31,9),(31,11),(31,13),(31,18),(31,22);
INSERT INTO LISTACTIVIDAD VALUES (32,9),(32,11),(32,13),(32,18),(32,19);
INSERT INTO LISTACTIVIDAD VALUES (33,19);
INSERT INTO LISTACTIVIDAD VALUES (34,12),(34,14),(34,15),(34,17);
INSERT INTO LISTACTIVIDAD VALUES (35,6),(35,9),(35,11),(35,13),(35,18);
INSERT INTO LISTACTIVIDAD VALUES (36,6),(36,9),(36,11),(36,13),(36,18),(36,19);
INSERT INTO LISTACTIVIDAD VALUES (37,19);
INSERT INTO LISTACTIVIDAD VALUES (38,12),(38,14),(38,15),(38,17);
INSERT INTO LISTACTIVIDAD VALUES (39,6),(39,9),(39,11),(39,13),(39,18);
INSERT INTO LISTACTIVIDAD VALUES (40,6),(40,9),(40,11),(40,13),(40,18),(40,19);
INSERT INTO LISTACTIVIDAD VALUES (41,19);
INSERT INTO LISTACTIVIDAD VALUES (42,12),(42,14),(42,15),(42,17);
INSERT INTO LISTACTIVIDAD VALUES (43,6),(43,13),(43,18);
INSERT INTO LISTACTIVIDAD VALUES (44,2),(44,6),(44,13),(44,16),(44,18),(44,19);
INSERT INTO LISTACTIVIDAD VALUES (45,1),(45,19),(45,21);
INSERT INTO LISTACTIVIDAD VALUES (46,3),(46,12),(46,14),(46,15),(46,17);
INSERT INTO LISTACTIVIDAD VALUES (47,6),(47,13),(47,18);
INSERT INTO LISTACTIVIDAD VALUES (48,2),(48,6),(48,13),(48,16),(48,18),(48,19);
INSERT INTO LISTACTIVIDAD VALUES (49,1),(49,4),(49,19),(49,21);

Select r.idRegistro,r.fecha, fl.nombreFaseLunar, e.nombreEpoca, 
t.nombreTiempo, ar.nombreCicloArbol, c.nombreCambio, ct.nombreCuatrimestre, a.nombreActividad
from LISTACTIVIDAD as l
JOIN Actividad as a ON a.idActividad = l.idActividad
JOIN Registro as r ON r.idRegistro = l.idRegistro
JOIN faselunar as fl ON fl.idFaseLunar = r.idFaseLunar
JOIN epoca as e ON e.idEpoca = r.idEpoca
JOIN tiempo as t ON t.idTiempo = r.idTiempo
JOIN arbol as ar ON ar.idArbol = r.idArbol
JOIN cambiosol as c ON c.idCambioSol = r.idCambioSol
JOIN cuatrimestre as ct ON ct.idCuatrimestre = r.idCuatrimestre;
