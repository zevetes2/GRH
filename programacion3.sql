create database proyectoFinal

use proyectoFinal
use proyecto



create table departamentos(
codigoDepartamento varchar(20),
nombre varchar(20),
encargado varchar (20),
constraint pk_Dep primary key (codigoDepartamento)


)

ALTER TABLE departamentos ADD PRIMARY KEY (ID)


insert into departamentos values ('MP', 'materia prima', 'Jose miguel')
insert into departamentos values ('IT', 'Tecnologia', 'Pedro Henrique')
insert into departamentos values ('Venta', 'Ventas', 'Juan Alfonzo')

create table cargos(

codigoCargo varchar(20),
cargo varchar(40),
constraint pk_C primary key (codigoCargo)

)

ALTER TABLE cargos ADD PRIMARY KEY (ID)

ALTER TABLE cargos ALTER COLUMN cargo VARCHAR (40)

insert into cargos values ('GMP', 'Gerente materia prima')
insert into cargos values ('GIT', 'Gerente tecnologia')
insert into cargos values ('GV', 'Gerente ventas')


create table empleados(

codigoEmpleado varchar(15),
nombre varchar(20),
apellido varchar(20),
telefono varchar(20),
departamento varchar(20),
cargo varchar(20),
fechaIngreso date,
salario decimal(10,2),
estatus bit,
constraint pk_empl primary key (codigoEmpleado),
constraint fk_CD foreign key (departamento) references departamentos(codigoDepartamento),
constraint fk_CC foreign key (cargo) references cargos(codigoCargo)
)

ALTER TABLE empleados ADD PRIMARY KEY (ID)


insert into empleados values ('001', 'Jose', 'Miguel', '8091234789', 'MP', 'GMP', '02-22-1984', 100000.00, 1)
insert into empleados values ('002', 'Pedro', 'Henrique', '8091234578', 'IT', 'GIT', '02-22-2010', 150000.00, 1)
insert into empleados values ('003', 'Juan', 'Alfonzo', '8091234896', 'Venta', 'GV', '02-22-2005', 70000.00, 1)

create unique index idx_CE on empleados(codigoEmpleado)
create unique index idx_CC on empleados(cargo)


select * from empleados

create table nomina(
id int identity,
año varchar(4),
mes varchar(2),
montoTotal decimal (10,2),
constraint pk_nomina primary key (id),
)

ALTER TABLE nomina ALTER COLUMN año VARCHAR (4)
ALTER TABLE nomina ALTER COLUMN mes VARCHAR (15)

ALTER TABLE nomina ADD PRIMARY KEY (ID)


create table empleadosSalida(
id int identity,
empleado varchar(15),
tipoSalida varchar(10),
motivo varchar(150),
fechaSalida date,
constraint pk_empSalida primary key (id),
constraint fk_CE foreign key (empleado) references empleados(codigoEmpleado)
)

ALTER TABLE empleadosSalida ADD PRIMARY KEY (ID)


create table vacaciones(
id int identity,
empleado varchar(15),
desde date,
hasta date,
año date,
comentario varchar(150),
constraint pk_vacaciones primary key (id),
constraint fk_CEV foreign key (empleado) references empleados(codigoEmpleado)

)

ALTER TABLE vacaciones ALTER COLUMN año VARCHAR (4)

ALTER TABLE vacaciones ADD PRIMARY KEY (ID)

create table permisos(
id int identity,
empleado varchar(15),
desde date,
hasta date,
comentarios varchar(150),
constraint pk_permisos primary key (id),
constraint fk_CEP foreign key (empleado) references empleados(codigoEmpleado)
)



ALTER TABLE permisos ADD PRIMARY KEY (ID)

create table licencias(
id int identity,
empleado varchar(15),
desde date,
hasta date,
motivo varchar(150),
comentarios varchar(150),
constraint pk_licencias primary key (id),
constraint fk_CEL foreign key (empleado) references empleados(codigoEmpleado)
)

ALTER TABLE licencias ADD PRIMARY KEY (ID)

select empleados.nombre, departamentos.nombre from empleados
inner join departamentos on empleados.departamento = departamentos.codigoDepartamento

select empleados.nombre, empleados.apellido, departamentos.nombre as departamento, cargos.cargo from ((empleados 
INNER JOIN departamentos ON empleados.departamento = departamentos.codigoDepartamento)
INNER JOIN cargos ON empleados.cargo = cargos.codigoCargo); 

select SUM(salario) from empleados where estatus = 1

select * from cargos

update empleados set estatus = 0 where codigoEmpleado = 001

select * from empleadosSalida

insert into empleadosSalida values ('001', 'Renuncia', 'Mejor vida por ahi', '04-15-2000')

select * from empleados

insert into nomina values ('2019', 'Agosto', 600000)

alter table empleados alter column estatus varchar(1)

update  empleados set estatus = 'A' where codigoEmpleado = 004



select count(estatus) from empleados where estatus = 'I'
             and fechaIngreso between '1984/01/01' and '2005/06/01'

alter trigger salida on empleadossalida 
after insert  as
begin 
update empleados  set estatus='I'
where (select top 1 empleado from empleadosSalida order by id desc)=empleados.codigoEmpleado;
		--(select (empleado) from empleadosSalida  where id= (Select max(id) from empleadosSalida)
		--(select from empleadosSalida where id ) ident_current('empleadosSalida'))
end 


select * from empleados where codigoEmpleado = IDENT_CURRENT('empleados')

select * from empleadosSalida where id = IDENT_CURRENT('empleadosSalida')

select * from empleados

insert into empleados values ('005', 'Estephan', 'Rosario', '8294781254', 'IT', 'GIT', '2005-05-01', '150000', 'A')

select * from nomina

