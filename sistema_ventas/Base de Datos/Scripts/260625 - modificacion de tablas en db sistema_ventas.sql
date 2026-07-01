-- agrego NOT NULL, modifico el tipo de dato de FECHA en FACTURAS y agrego default de CANTIDAD en VENTAS
alter table CLIENTES alter column NOMBRE varchar(100) NOT NULL;
alter table PROVEEDORES alter column NOMBRE varchar(100) NOT NULL;
alter table FACTURAS alter column FECHA datetime2 NOT NULL;
alter table FACTURAS alter column ID_CLIENTE int NOT NULL;
alter table CATEGORIAS alter column DESCRIPCION varchar(100) NOT NULL;
alter table PRODUCTOS alter column DESCRIPCION varchar(150) NOT NULL;
alter table PRODUCTOS alter column PRECIO decimal(9,2) NOT NULL;
alter table PRODUCTOS alter column ID_CATEGORIA int NOT NULL;
alter table PRODUCTOS alter column ID_PROVEEDOR int NOT NULL;
alter table VENTAS alter column ID_FACTURA int NOT NULL;
alter table VENTAS alter column ID_PRODUCTO int NOT NULL;
alter table VENTAS alter column CANTIDAD int NOT NULL;
alter table VENTAS add constraint df_ventas_c default 1 for CANTIDAD;
