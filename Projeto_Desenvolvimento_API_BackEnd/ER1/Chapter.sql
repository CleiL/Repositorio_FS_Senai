create database Chapter;

 use Chapter;

 create table Livros
 (
	Id int primary key identity,
	Titulo varchar(150) not null,
	QuantidadePaginas INT,
	Disponivel BIT
 );

 insert into Livros (Titulo, QuantidadePaginas, Disponivel)
 values ('Titulo A', 120, 1);

  insert into Livros (Titulo, QuantidadePaginas, Disponivel)
 values ('Titulo B', 220, 0);

   insert into Livros (Titulo, QuantidadePaginas, Disponivel)
 values ('Titulo C', 420, 3);

 select * from Livros;