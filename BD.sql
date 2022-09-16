create database Practica
go
use Practica

create table Productos 
(
Id_producto int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Precio float,
Preciocosto float,
Stock int,
Id_categoria int 
)
create table Categoria 
(
Id_categoria int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
)
create table Cliente 
(
Id_cliente int identity (1,1) primary key,
Nombre nvarchar (100),
DNI nvarchar (100),
Telefono nvarchar (100),
Direccion nvarchar(100),
Id_estado int
)
create table Estado
(
Id_estado int identity (1,1) primary key,
Estado nvarchar (100),
Deuda nvarchar (100),
saldo float,
)
create table Factura 
(
Id_factura int identity (1,1) primary key,
Numero_factura int,
fecha nvarchar (100),
Id_clente int,
Id_proveedor int,
)
create table Proveedor 
(
Id_proveedor int identity (1,1) primary key,
Nombre nvarchar (100),
ciut int,
Direccion nvarchar (100),
telefono int,
)
create table Detalle 
(
Id_detalle int identity (1,1) primary key,
cantidad nvarchar (100),
precio nvarchar (100),
Id_factura nvarchar (100),
Id_producto int,
)
create table Caja 
(
Id_caja int identity (1,1) primary key,
fecha nvarchar (100),
cajainicial nvarchar (100),
entrada nvarchar (100),
salida float, 
)
create table UnidadMedida
(
Id_unidad int identity (1,1) primary key,
unidadmedida nvarchar (100),
Id_producto int,
)
insert into 
values
('Gaseosa','3 litros','marcacola',8.3,7.5,24),
('Chocolate','Tableta 100 gramos','iberica',13.0,12.5,36)

---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
create proc MostrarProductos
as
select *from Productos
go
create proc MostrarCliente
as
select *from Cliente
go
create proc MostrarProveedor
as
select *from Proveedor
go
create proc MostrarFactura
as
select *from Factura
gocreate proc MostrarEstado
as
select *from Estado
gocreate proc MostrarCaja
as
select *from Caja
go
--------------------------INSERTAR 
create proc InsetarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@preciocosto float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@precio,@preciocosto,@stock)
go

create proc InsetarCliente
@nombre nvarchar (100),
@DNI nvarchar (100),
@Telefono nvarchar (100),
@Direccion nvarchar (100),
@Id_Estado nvarchar(100)
as
insert into Cliente values (@nombre,@DNI,@Telefono,@Direccion,@Id_Estado)
go
--------------------ELIMINAR------------------
create proc EliminarProducto
@id_producto int
as
delete from Productos where Id_producto=@id_producto
go

create proc EliminarCliente
@id_cliente int
as
delete from Productos where Id_producto=@id_cliente
go
------------------EDITAR---------------

create proc EditarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@preciocosto float,
@stock int,
@id_producto int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio,Preciocosto=@preciocosto, Stock=@stock where Id_producto=@id_producto
go

create proc EditarCliente
@nombre nvarchar (100),
@DNI nvarchar (100),
@Telefono nvarchar (100),
@Direccion nvarchar (100),
@ID_estado int,
@id_cliente int
as
update Productos set Nombre=@nombre, DNI=@dni, Telefono=@telefono, Direccion=@direccion, Id_estado=@id_estado where Id_cliente=@id_cliente
go
