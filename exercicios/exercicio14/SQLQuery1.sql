create database empresa_db

drop database empresa_db

create table departamento(
	idDepartamento int primary key IDENTITY,
	nome varchar(50) not null,
	localizacao varchar(50) not null,
	orcamento float not null,

);

create table empregado(
idEmpregado int primary key IDENTITY,
nome varchar(20),
idGerente int null,
funcao varchar(50),
idDepartamento int,
dataAdmissao date ,
salario float,
comissao float,

 foreign key(idDepartamento) references departamento(idDepartamento), 

 constraint pk_empregado foreign key(idGerente) references empregado(idEmpregado) 
 
);
drop table empregado;

INSERT INTO Departamento VALUES('1','Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('2','Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('3','Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('4','Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('5','Redes','Taquara','12122');

INSERT INTO empregado VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO empregado VALUES('2','Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO empregado VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO empregado VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO empregado VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO empregado VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO empregado VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO empregado VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO empregado VALUES('9','Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('10','Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('12','Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');



select *
from departamento;

select *
from empregado;

select nome,(orcamento*12)
from departamento
where (orcamento*12)>10000;

select nome,orcamento
from departamento
where (orcamento*12)>10000;

select distinct funcao
from empregado; 

select nome,funcao
from empregado
order by empregado.nome;

select nome,funcao
from empregado
order by empregado.nome desc;

select nome
from empregado
where salario between 1000 and 3500;

select nome
from empregado
where salario between 3400 and 4000 and funcao ='balconista';

select lower(nome) 
from empregado;

select substring(nome,0,6)
from empregado;

SELECT SUM(salario) as total, min(salario) as minimo, max(salario) as maximo  
FROM empregado;

SELECT idDepartamento, AVG(comissao) as media
FROM empregado
GROUP BY idDepartamento;


SELECT idDepartamento, AVG(comissao) as media
FROM empregado
GROUP BY idDepartamento having count(*) > 2;

SELECT A.nome, A.funcao, B.nome
FROM Empregado as A, Departamento as B
WHERE B.idDepartamento = A.idDepartamento;

SELECT  A.idEmpregado, A.nome, A.funcao, B.nome 'CHEFE'
FROM  Empregado A, Empregado B
WHERE  A.idGerente  = B.idEmpregado;

INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');

UPDATE Empregado 
SET Empregado.salario = Empregado.salario* 1.2 
WHERE Empregado.salario< 1000;

DELETE FROM Empregado
WHERE Empregado.salario > 5000;

SELECT  A.nome, A.funcao
FROM Empregado A
WHERE  10000 IN (SELECT Departamento.orcamento
                  FROM Departamento
                  WHERE Departamento.idDepartamento = A.idDepartamento);


SELECT A.nome
FROM Departamento A
WHERE EXISTS (SELECT * FROM Empregado
              WHERE Empregado.salario > 3000 AND Empregado.idDepartamento = A.idDepartamento);


