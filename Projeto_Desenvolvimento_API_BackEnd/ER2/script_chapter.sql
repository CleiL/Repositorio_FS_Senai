create database Chapter;

use Chapter;

create table Livros
(
	Id int primary key identity,
	Titulo varchar (150) not null,
	QuantidadedePaginas int,
	Disponivel bit
);

insert into Livros (Titulo, QuantidadedePaginas, Disponivel)
values ('Titulo A', 120, 1);

insert into Livros (Titulo, QuantidadedePaginas, Disponivel)
values ('Titulo B', 220, 0);

select * from Livros;