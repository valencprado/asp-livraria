create database bdLivrariaNoite;
use bdLivrariaNoite;

# criando as tabelas
create table tbAutor (
codAutor int primary key auto_increment,
nomeAutor varchar(50),
sta varchar(15)
);

create table tbLivro (
codLivro int primary key auto_increment,
nomeLivro varchar(50),
codAutor int,
foreign key (codAutor) references tbAutor(codAutor)
);
insert into tbAutor (nomeAutor, sta) values ('Machado de Assis','Disponível');
insert into tbAutor (nomeAutor, sta) values ('Érico Veríssimo','Disponível');
insert into tbAutor (nomeAutor, sta) values ('Guimarães Rosa','Disponível');
insert into tbAutor (nomeAutor, sta) values ('Carlos Drumond de Andrade','Indisponível');
insert into tbAutor (nomeAutor, sta) values ('Clarice Lispector','Disponível');
insert into tbAutor (nomeAutor, sta) values ('Paulo Coelho','Disponível');
insert into tbAutor (nomeAutor, sta) values ('Manuel Bandeira','Indisponível');
insert into tbAutor (nomeAutor, sta) values ('Vinícius de Moraes','Indisponível');
insert into tbAutor (nomeAutor, sta) values ('Monteiro Lobato','Indisponível');

select *from tbAutor;
select *from tbLivro;