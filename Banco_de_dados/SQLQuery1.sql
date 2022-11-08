--criar  um banco de dados

--DML e DDL

--DDL - Data Definition Language

CREATE DATABASE atosUfn

--CRIANDO UMA TABELA
CREATE TABLE ALUNOS
(
	MATRICULA VARCHAR(12) PRIMARY KEY,
	NOME VARCHAR(50) NOT NULL,
	CURSO VARCHAR(20) NOT NULL,
	TURNO VARCHAR(25),
	IDADE INTEGER,
	ESTADO VARCHAR(2) -- VARCHAR É A STRING NO BANCO DE DADOS
	
)

DROP TABLE ALUNOS

ALTER TABLE ALUNOS ADD ALTURA INTEGER
ALTER TABLE ALUNOS DROP COLUMN IDADE

CREATE TABLE autores
(
	id integer primary key identity,
	nome varchar(50) not null,
	nacionalidade varchar(30)
)

create table livros 
(
	id integer primary key identity,
	titulo varchar(100) not null,
	paginas integer,
	fk_autor integer,
	foreign key (fk_autor) references autores (id)
)