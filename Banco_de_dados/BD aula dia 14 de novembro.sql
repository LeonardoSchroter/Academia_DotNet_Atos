create database aula

use aula

create table pessoas
(
	id integer primary key identity,
	nome varchar(50) not null,
	peso float 
);

create login usuario with password='admin123';
create user usuario from login usuario;

exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER','usuario';

select * from pessoas;
