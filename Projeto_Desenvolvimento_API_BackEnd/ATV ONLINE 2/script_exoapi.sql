create database dbExoAPI;

use dbExoAPI;

create table Projetos
(
	Id int primary key identity,
	Titulo varchar(150) not null,
	Status varchar(150) not null,
	Data_de_inicio varchar(10) not null,
	Area varchar(150) not null
);

insert into Projetos(Titulo, Status, Data_de_inicio, Area)
values ('Projeto A', 'Em Planejamento', '10/04/2022', 'T.I');

insert into Projetos(Titulo, Status, Data_de_inicio, Area)
values ('Projeto B', 'Iniciado', '19/02/2022', 'RH');

select * from Projetos;

create table Usuarios(
id int primary key identity,
Email varchar(255) not null unique,
Senha varchar(120) not null,
Tipo char(1) not null
);

insert into Usuarios values ('teste@email.com.br','1234','0');
select * from Usuarios;
select * from Usuarios where email = 'teste@email.com.br' and senha = '1234';