-- renombre el campo MEMBRESIA en la tabla CLIENTES
exec sp_rename 'CLIENTES.MEMBRESIA', 'ID_MEMBRESIA', 'COLUMN';

-- creo tabla MEMBRESIA
create table MEMBRESIA (
ID_MEMBRESIA int identity(0,1),
DESCRIPCION varchar(50) NOT NULL,
constraint pk_membresia primary key (ID_MEMBRESIA)
);

-- renombro el default de ID_MEMBRESIA en CLIENTES
alter table CLIENTES drop constraint df_clientas_m;
alter table CLIENTES add constraint df_clientes_m default 0 for ID_MEMBRESIA;

-- agrego la foreign key ID_MEMBRESIA en CLIENTES
alter table CLIENTES add constraint fk_clientes_m foreign key (ID_MEMBRESIA) references MEMBRESIA(ID_MEMBRESIA);

-- renombro la tabla MEMBRESIA y su primary key
exec sp_rename 'MEMBRESIA', 'MEMBRESIAS';
exec sp_rename 'pk_membresia', 'pk_membresias';
