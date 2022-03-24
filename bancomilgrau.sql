
create database bdLivrariaNoite;
use bdLivrariaNoite;

# criando as tabelas
create table tbStatus(
codStatus int primary key auto_increment,
sta varchar(50)
);
create table tbAutor (
codAutor int primary key auto_increment,
nomeAutor varchar(50),
codStatus int,
foreign key(codStatus) references tbStatus(codStatus)
);

insert into tbStatus values(default, 'Disponível'), (default, 'Indisponível');
select * from tbstatus;
drop table tbLivro;	
drop table tbAutor;
create table tbLivro (
codLivro int primary key auto_increment,
nomeLivro varchar(50),
codAutor int,
foreign key (codAutor) references tbAutor(codAutor)
);
insert into tbAutor (nomeAutor, codStatus) values ('Machado de Assis',1);
insert into tbAutor (nomeAutor, codStatus) values ('Érico Verísimo',1);
insert into tbAutor (nomeAutor, codStatus) values ('Guimarã£es Rosa',1);
insert into tbAutor (nomeAutor, codStatus) values ('Carlos Drummond de Andrade',2);
insert into tbAutor (nomeAutor, codStatus) values ('Clarice Lispector',1);
insert into tbAutor (nomeAutor, codStatus) values ('Paulo Coelho',1);
insert into tbAutor (nomeAutor, codStatus) values ('Manuel Bandeira',2);
insert into tbAutor (nomeAutor, codStatus) values ('Vinicius de Moraes',2);
insert into tbAutor (nomeAutor, codStatus) values ('Monteiro Lobato',2);
select *from tbAutor;
select *from tbLivro;

