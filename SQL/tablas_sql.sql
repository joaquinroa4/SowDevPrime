create database SowDevPrime

use SowDevPrime

create table Categoria
(
ID_Categoria int identity primary key,
categoria varchar(50)
)

create table Usuario_Tipo
(
ID_Usuario_Tipo int identity primary key,
Usuario_Desc varchar(50)
)

create table Usuarios
(
ID_Usuario int identity primary key,
Dni_Usuario int,
Nombre_Usuario varchar(25),
Apellido_Usuario varchar(25),
Telf_Usuario varchar(15),
Mail_Usuario varchar(50),
Direccion_Usuario varchar(50),
User_Usuario varchar(30),
Contrasenia_Usuario varchar(30),
ID_Tipo int
foreign key (ID_Tipo) references Usuario_Tipo (ID_Usuario_Tipo)
)


create table SubCategorias
(
ID_SubCateg int identity primary key,
Subcategoria varchar(50),
ID_Categorias int
foreign key (ID_Categorias) references Categoria (ID_Categoria)
)

create table Proovedores
(
ID_Proovedor int identity primary key,
Cuit_Proovedor int,
Nombre_Proovedor varchar(50),
Telf_Proovedor varchar(15),
Email_Proovedor varchar(50),
Direc_Proovedor varchar(30),
Estado_Proovedor varchar(2)
)


create table Ingreso_Egreso
(
ID_Movimiento int identity primary key,
Cod_Usuario int,
Tipo varchar(50),
Detalle varchar(50),
Monto int,
Fecha datetime
foreign key (Cod_Usuario) references Usuarios (ID_Usuario)
)

create table Clientes
(
ID_Cliente int identity primary key,
CUIT_Cliente int,
Nombre_Cliente varchar(50),
Entidad_Cliente varchar(50),
Telf_Cliente varchar(15),
Mail_Cliente varchar(50),
Direc_Cliente varchar(30),
Estado_Cliente varchar(2)
)

create table Hist_Compras
(
ID_Remito_Compra int identity primary key,
Cod_Usuario int,
Fecha_hora datetime,
ID_Proovedores int,
Subtotal varchar(20),
Descuento varchar(20),
Total varchar(20)
foreign key (Cod_Usuario) references Usuarios (ID_Usuario),
foreign key (ID_Proovedores) references Proovedores (ID_Proovedor)
)

create table Hist_Compras_Detalle
(
ID_Remito_Detalle int identity primary key,
ID_Remito int,
Cod_Art varchar(20),
Descripcion varchar(30),
Precio_Unit varchar(20),
Cantidad int,
Precio_Total varchar(20),
Tipo_Compra varchar(20)
foreign key (ID_Remito) references Hist_Compras (ID_Remito_Compra)
)

create table Hist_Ventas
(
ID_Remito int identity primary key,
Cod_Usuario int,
Fecha_Hora datetime,
ID_Cliente int,
Cuit_Cliente_Inex int,
Subtotal varchar(20),
Descuento varchar(20),
Total varchar(20)
foreign key (Cod_Usuario) references Usuarios (ID_Usuario),
foreign key (ID_Cliente) references Clientes (ID_Cliente)
)

create table Hist_Ventas_Detalle
(
ID_Remito_Detalle int identity primary key,
ID_Remito int,
Cod_Art varchar(20),
Descripcion varchar(30),
Cantidad int,
Precio_Total varchar(20), 
Precio_Unit varchar(20)
foreign key (ID_Remito) references Hist_Ventas (ID_Remito),
)

create table Articulos
(
ID_Articulo int identity primary key,
Cod_Articulo varchar(20),
Art_Descrip varchar(50),
Cod_Categorias int ,
Cod_SubCateg int,
Stock_Articulo int,
Costo_Articulo varchar(20),
PrecioVenta bigint,
ID_Proovedor int,
foreign key (Cod_Categorias) references Categoria (ID_Categoria),
foreign key (Cod_SubCateg) references SubCategorias (ID_SubCateg),
foreign key (ID_Proovedor) references Proovedores (ID_Proovedor)
)
