--------------------------------------CREACION DE LAS TABLAS---------------------------
Create Table ABCC (
Sku int not null,
Articulo varchar(15) not null,
Marca varchar(15) not null,
Modelo varchar(20) not null,
Departamento int not null,
Clase int not null,
Familia varchar(2) not null,
Fecha_Alta Date not null,
Stock int not null,
Cantidad int not null,
Descontinuado varchar(1) not null,
Fecha_Baja Date

Primary key(Sku)
)


SELECT * FROM abc.dbo.ABCC

Create Table Departamento (
IdDepartamento numeric primary key not null,
NombreDepartamento varchar(30)not null,	
)

Create Table Clase(
IdClase numeric not null,
NombreClase varchar(30)not null,
IdDepartamento numeric not null
Constraint fk_IdDepartamento_Clase Foreign Key(IdDepartamento) References Departamento(IdDepartamento)
)


Create Table Familia (
IdFamilia varchar(2) not null,
NombreFamilia varchar(30)not null,
IdClase numeric not null,
IdDepartamento numeric not null,
Constraint fk_IdDepartamento_Familia Foreign Key(IdDepartamento) References Departamento(IdDepartamento),
)
----------------------------------------------------------INSERTS-----------------------------------

--iNSERTS DE LA TABLA DEPARTAMENTO
Insert into Departamento values (1, 'DOMESTICOS' );
Insert into Departamento values (2, 'ELECTRONICA' );
Insert into Departamento values (3, 'MUEBLE SUELTO' );
Insert into Departamento values (4, 'SALAS, RECAMARAS, COMEDORES' );


-- iNSERTS DE LA TABLA CLASE
Insert into Clase values(1, 'COMESTIBLES',1);
Insert into Clase values(2, 'LICUADORAS',1);
Insert into Clase values(3, 'BATIDORAS',1);
Insert into Clase values(4, 'CAFETERAS',1);

Insert into Clase values(1, 'AMPLIFICADORES CAR AUDIO',2);
Insert into Clase values(2, 'AUTOESTEREOS',2);

Insert into Clase values(1, 'COLCHON',3);
Insert into Clase values(2, 'JUEGO BOX',3);

Insert into Clase values(1, 'SALAS',4);
Insert into Clase values(2, 'COMPLEMENTOS PARA SALA',4);
Insert into Clase values(3, 'SOFAS CAMA',4);


--INSERTS DE LA TABLA FAMILIA 
insert into Familia values('00', 'SIN NOMBRE',1,1)
insert into Familia values('01', 'LICUADORAS',2,1)
insert into Familia values('02', 'EXCLUSIVO COPPEL.COM',2,1)
insert into Familia values('01', 'BATIDORA MANUAL',3,1)
insert into Familia values('02', 'PROCESADOR',3,1)
insert into Familia values('03', 'PICADORA',3,1)
insert into Familia values('04', 'BATIDORA PEDESTAL',3,1)
insert into Familia values('05', 'BATIDORA FUENTE DE SODAS',3,1)
insert into Familia values('06', 'MULTIPRACTICOS',3,1)
insert into Familia values('07', 'EXCLUSIVOS COPPEL.COM',3,1)
insert into Familia values('01', 'CAFETERAS',4,1)
insert into Familia values('02', 'PERCOLADORAS',4,1)*/
insert into Familia values('01', 'AMPLIFICADOR/RECEPTOR',1,2)
insert into Familia values('02', 'KIT DE INSTALACION',1,2)
insert into Familia values('03', 'AMPLIFICADORES COPPEL.COM',1,2)
insert into Familia values('01', 'AUTOESTEREOS CD C/BOCINAS',2,2)
insert into Familia values('02', 'ACCESORIOS CAR AUDIO',2,2)
insert into Familia values('03', 'AMPLIFICADOR',2,2)
insert into Familia values('04', 'ALARMA AUTO/CASA/OFICINA',2,2)
insert into Familia values('05', 'SIN MECANISMO',2,2)
insert into Familia values('06', 'CON CD',2,2)
insert into Familia values('07', 'MULTIMEDIA',2,2)
insert into Familia values('08', 'PAQUETE SIN MECANISMO',2,2)
insert into Familia values('09', 'PAQUETE CON CD',2,2)*/
insert into Familia values('01', 'PILLOW TOP KS',1,3)
insert into Familia values('02', 'PILLOW TOP DOBLE KS',1,3)
insert into Familia values('03', 'HULE ESPUMAKS',1,3)
insert into Familia values('01', 'ESTANDAR INDIVIDUAL',2,3)
insert into Familia values('02', 'PILLOW TOP INDIVIDUAL',2,3)
insert into Familia values('03', 'PILLOW TOP DOBLE INDIVIUDAL',2,3)
insert into Familia values('01', 'ESQUINERAS SUPERIORES',1,4)
insert into Familia values('02', 'TIPO L SECCIONAL',1,4)
insert into Familia values('01', 'SILLON OCASIONAL',2,4)
insert into Familia values('02', 'PUFF',2,4)
insert into Familia values('03', 'BAUL',2,4)
insert into Familia values('04', 'TABURETE',2,4)
insert into Familia values('01', 'SOFA CAMA TAPIZADO CONTEMP',3,4)
insert into Familia values('02', 'SOFACAMA CLASICO',3,4)
insert into Familia values('03', 'ESTUDIO',3,4)

--ESTE QUERY DEVUELVE LA TABLA QUE VENIA EN EL EJERCICIO
Select distinct Departamento.IdDepartamento,Departamento.NombreDepartamento, Clase.IdClase, NombreClase,Familia.IdFamilia,NombreFamilia From  Departamento , Clase, Familia
Where Clase.IdDepartamento = Departamento.IdDepartamento AND (Familia.IdClase = Clase.IdClase AND Familia.IdDepartamento = Departamento.IdDepartamento)





------------------------------------------------PROCEDIMIENTOS ALMACENADOS---------------------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Alter PROCEDURE spAlta

@Sku int,
@Articulo varchar(15),
@Marca varchar(15),
@Modelo Varchar(15),
@Departamento int,
@Clase int,
@Familia varchar(2),
@Stock int,
@Cantidad int,
@Fecha_Alta Date,
@Fecha_Baja Date,
@Descontinuado varchar
AS
BEGIN

Insert into ABCC(Sku, Articulo, Marca, Modelo, Departamento, Clase, Familia, Stock, Cantidad, Fecha_Alta,Fecha_Baja,Descontinuado) Values(@Sku,@Articulo,@Marca,@Modelo,@Departamento,@Clase,@Familia,
@Stock,@Cantidad,@Fecha_Alta,@Fecha_Baja,@Descontinuado
)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE spBaja

@Sku int

AS
BEGIN


Delete from abc.dbo.ABCC where Sku=@sku

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE spConsulta

@Sku int

AS
BEGIN


select * from abc.dbo.ABCC where Sku=@Sku

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE spCambio

@Sku int,
@Articulo varchar(15),
@Marca varchar(15),
@Modelo Varchar(15),
@Departamento int,
@Clase int,
@Familia varchar(2),
@Stock int,
@Cantidad int,
@Fecha_Alta Date,
@Fecha_Baja Date,
@Descontinuado varchar

AS
BEGIN


Update ABCC set  Articulo=@Articulo, Marca=@Marca,Modelo=@Modelo,Departamento=@Departamento,Clase=@Clase,Familia=@Familia,
Stock=@Stock, Cantidad=@Cantidad, Fecha_Alta=@Fecha_Alta, Fecha_Baja= @Fecha_Baja, Descontinuado=@Descontinuado where Sku=@Sku

END
GO