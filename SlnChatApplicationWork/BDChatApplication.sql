
use master
go
if db_id('BDChatApplication') is not null
	drop database BDChatApplication
go
create database BDChatApplication
go
use BDChatApplication
go

if OBJECT_ID('TEmpleado')is not null
	drop table TEmpleado
go
create table TEmpleado
(
	EmpleadoID int identity primary key,
	APaterno varchar(50)not null,
	AMaterno varchar(50)not null,
	Nombres varchar(50)not null,
)
go


if OBJECT_ID('TUsuario')is not null
	drop table TUsuario
go
create table TUsuario
(
	UserID int identity primary key,
	UserName varchar(50) unique not null,
	Contrasena varchar(50)not null,
	EmpleadoID int not null,
	foreign key (EmpleadoID) references TEmpleado
)
go


if OBJECT_ID('TMensaje')is not null
drop table TMensaje
go
create table TMensaje
(
MensajeID int primary key,
Fecha datetime,
ReceptorID int,
UserID int,
	foreign key (UserID) references TUsuario
)
go 






