-- agrego campo MEMBRESIA para clientes VIP
alter table CLIENTES add MEMBRESIA int;
alter table CLIENTES add constraint df_clientes_m default null for MEMBRESIA;

-- agrego campo STOCK para productos
alter table PRODUCTOS add STOCK int;
alter table PRODUCTOS add constraint df_productos_s default 1 for STOCK;