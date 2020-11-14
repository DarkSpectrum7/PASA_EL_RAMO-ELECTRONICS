create database pasaelramo_electronics

use pasaelramo_electronics
--==========================================================================--
--LOGIN
--==========================================================================--

create table login (id int,
					usuario varchar (100), --PK
					clave varchar (100),
					primary key (usuario))
go
--==========================================================================--
--Documento
--==========================================================================--
create table Documento (	
							id_doc int identity (1,1) not null, -- PK
							id_empresa int  not null, -- Fk
							id_det int, -- FK -- detalle
							total_neto numeric,
							total_iva numeric,
							total_bruto numeric,
							anulada numeric,
							emitida numeric,
							fecha varchar(100),
							primary key (id_doc),
							foreign key(id_det) references detalle(id_det),
							foreign key(id_empresa) references empresa(id_empresa))


go
----==========================================================================--
----Tipo_documento
----==========================================================================--
--create table Tipo_documento (	id int,
--								id_doc int identity (1,1), ---pk
--								tipo char,
--								primary key (id_doc));

--==========================================================================--
--DETALLE
--==========================================================================--
create table detalle (	id int,
						id_det int identity (1,1), -- PK
						id_prod int , --FK -- producto
						cantidad varchar(100),
						id_doc int , --FK -- factura
						primary key (id_det),
						FOREIGN KEY (id_prod) references producto(id_prod))


go
--==========================================================================--
--PRODUCTO
--==========================================================================--
create table producto ( id int,
						id_prod int identity (1,1), --PK
						nombre_prod varchar(12),
						precio_uni varchar(100),
						primary key (id_prod))

go
--==========================================================================--
--Empresa
--==========================================================================--
create table empresa ( id int,
						id_empresa int identity (1,1), -- PK
						rut varchar(12),
						giro varchar(100),
						ciudad varchar(100),
						comuna varchar(100),
						direccion varchar(100),
						telefono varchar(100),
						email varchar(100),
						referencia varchar(100),
						primary key (id_empresa))

go

alter table detalle add FOREIGN KEY (id_doc) references documento(id_doc)