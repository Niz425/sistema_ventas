create database sistema_ventas;
use sistema_ventas;

create table CLIENTES(
ID_CLIENTE int identity(1,1),
NOMBRE varchar(100),
DIRECCION varchar(250),
TELEFONO varchar(15),
constraint pk_clientes primary key (ID_CLIENTE)
);

/*
identity es el auto increment
identity(A,B) empieza en A y va incrementando B cada nuevo registro
*/

create table FACTURAS(
ID_FACTURA int identity(1,1),
FECHA date,
ID_CLIENTE int,
constraint pk_facturas primary key (ID_FACTURA),
constraint fk_facturas foreign key (ID_CLIENTE) references CLIENTES (ID_CLIENTE)
);

create table PROVEEDORES(
ID_PROVEEDOR int identity(1,1),
NOMBRE varchar(100),
DIRECCION varchar(250),
TELEFONO varchar(15),
constraint pk_proveedores primary key (ID_PROVEEDOR)
);

create table CATEGORIAS(
ID_CATEGORIA int identity(1,1),
DESCRIPCION varchar(100),
constraint pk_categorias primary key (ID_CATEGORIA)
);

create table PRODUCTOS(
ID_PRODUCTO int identity(1,1),
DESCRIPCION varchar(150),
PRECIO decimal(9,2),
ID_CATEGORIA int,
ID_PROVEEDOR int,
constraint pk_productos primary key (ID_PRODUCTO),
constraint fk_productos_c foreign key (ID_CATEGORIA) references CATEGORIAS (ID_CATEGORIA),
constraint fk_productos_p foreign key (ID_PROVEEDOR) references PROVEEDORES (ID_PROVEEDOR)
);

/*
Cómo optimiza SQL Server el tipo decimal
El espacio físico que ocupa el tipo decimal depende del número total de dígitos
(precisión) que declare, según la siguiente regla oficial de SQL Server:
- 1 a 9 dígitos totales: Ocupa 5 bytes (hasta 10 Millones)
- 10 a 19 dígitos totales: Ocupa 9 bytes (hasta 10 Billones)
- 20 a 28 dígitos totales: Ocupa 13 bytes
- 29 a 38 dígitos totales: Ocupa 17 bytes
*/

create table VENTAS(
ID_VENTA int identity(1,1),
ID_FACTURA int,
ID_PRODUCTO int,
CANTIDAD int,
constraint pk_ventas primary key (ID_VENTA),
constraint fk_ventas_f foreign key (ID_FACTURA) references FACTURAS (ID_FACTURA),
constraint fk_ventas_p foreign key (ID_PRODUCTO) references PRODUCTOS (ID_PRODUCTO)
);

-- al parecer, varchar(30) es muy corto para nombre, direccion y descripcion