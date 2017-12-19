use BDChatApplication
go

if OBJECT_ID('spAgregarEmpleado') is not null
drop proc spAgregarEmpleado
go

create proc spAgregarEmpleado
@APaterno varchar(50),@AMaterno varchar(50),@Nombres varchar(50)
as
begin
INSERT INTO TEmpleado VALUES(@APaterno,@AMaterno,@Nombres)
end
go

exec spAgregarEmpleado 'Puchuri','Mamani','Eduardo'


if OBJECT_ID('spLoginUser') is not null
drop proc spLoginUser
go

create proc spLoginUser
@UserName varchar(50),@Contrasena varchar(50)
as
begin
		if exists(select UserName from TUsuario
					where UserName=@UserName and Contrasena=@Contrasena)
					select CodError=0,Mensaje = 'Usuario Logeado correctamente'
	
	else select CodError=1,Mensaje='No se encuentra el usuario y/o es invalido'
end
go	

exec spLoginUser 'esalinas','06190185'



if OBJECT_ID('spAgregarUsuario') is not null
drop proc spAgregarUsuario
go
create proc spAgregarUsuario
@APaterno varchar(50),@AMaterno varchar(50),@Nombres varchar(50),
@UserName varchar(50),@Contrasena varchar(50)
as 
begin
	if exists(select APaterno,AMaterno, Nombres, EmpleadoID from TEmpleado
				where  APaterno=@APaterno and AMaterno=@AMaterno and Nombres=@Nombres)
			
	begin 
		insert into TUsuario values (@UserName,@Contrasena,( select EmpleadoID from TEmpleado
		where APaterno=@APaterno and AMaterno=@AMaterno ))
		select CodError=0, Mensaje='Usuario Agregado Correctamente'
		end
		else
			select CodError=1,Mensaje='Empleado no existe'
	end
go



