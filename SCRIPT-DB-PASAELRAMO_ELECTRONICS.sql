create database pasaelramo_electronics
go
use pasaelramo_electronics
go
--==========================================================================--
--LOGIN
--==========================================================================--

create table login (id int,
					usuario varchar (100), --PK
					clave varchar (100),
					primary key (usuario))
go

--==========================================================================--
--CLIENTE
--==========================================================================--
create table cliente (	id_cli int identity (1,1), -- PK
						rut varchar(12),
						giro varchar(100),
						ciudad varchar(100),
						comuna varchar(100),
						direccion varchar(100),
						telefono varchar(100),
						email varchar(100),
						referencia varchar(100),
						primary key (id_cli))

go
--==========================================================================--
--EMPRESA
--==========================================================================--
create table empresa (	id_empresa int identity (1,1), -- PK
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
--==========================================================================--
--PRODUCTO
--==========================================================================--
create table producto ( id_prod int identity (1,1), --PK
						nombre_prod varchar(12),
						precio_uni varchar(100),
						primary key (id_prod))

go
--==========================================================================--
--DETALLE
--==========================================================================--
create table detalle (	id_det int identity (1,1), -- PK
						id_prod int , --FK -- PRODUCTO
						cantidad varchar(100),
						id_doc int , --FK -- DOCUMENTO
						primary key (id_det),
						FOREIGN KEY (id_prod) references producto(id_prod))


go

--==========================================================================--
--DOCUMENTO
--==========================================================================--
create table documento (	id_doc int identity (1,1) not null, -- PK
							id_empresa int  not null, -- Fk -- EMPRESA
							id_cli int not null, -- FK -- CLIENTE
							id_det int not null, -- FK -- DETALLE
							total_neto numeric (10),
							total_iva numeric(10),
							total_bruto numeric (10),
							anulada char (1),
							emitida char (1),
							fecha datetime,
							primary key (id_doc),
							foreign key(id_det) references detalle(id_det),
							foreign key(id_empresa) references empresa(id_empresa),
							foreign key(id_cli) references cliente(id_cli))


go

--==========================================================================--
--
--==========================================================================--

alter table detalle add FOREIGN KEY (id_doc) references documento(id_doc)