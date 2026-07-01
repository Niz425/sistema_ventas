-- modifico el default y le agrego el not null a MEMBRESIA en CLIENTES
alter table CLIENTES drop constraint df_clientes_m;
alter table CLIENTES add constraint df_clientas_m default 0 for MEMBRESIA;
alter table CLIENTES alter column MEMBRESIA int not null;

-- modifico el default y le agrego el not null a STOCK en PRODUCTOS
alter table PRODUCTOS drop constraint df_productos_s;
alter table PRODUCTOS add constraint df_productos_s default 0 for STOCK;
alter table PRODUCTOS alter column STOCK int not null;
