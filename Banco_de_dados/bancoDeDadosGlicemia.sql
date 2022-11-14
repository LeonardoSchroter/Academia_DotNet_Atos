-- script para o banco de dados glicemia_db

--criando base de dados
create database glicemia_db;

go

--mostrando todas as tabelas da base de dados
SELECT name
FROM sys.databases;  

go

--usando a base de dados empresa_db
use [glicemia_db];

-- criando a tabela Paciente
CREATE TABLE Paciente (
  idPaciente INT identity,
  nome VARCHAR(45) NOT NULL,
  email VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (idPaciente)
);

-- inserindo pacientes
INSERT INTO Paciente VALUES('Alexandre Zamberlan','alexz@ufn.edu.br');
INSERT INTO Paciente VALUES('Eduardo Palharini','eduardo@ufn.edu.br');
INSERT INTO Paciente VALUES('Flavia Falotico','flavinha@ufn.edu.br');

-- exibindo pacientes
select * 
from Paciente;


-- criando a tabela MedidaGlicemia
CREATE TABLE MedidaGlicemia (
  idMedidaGlicemia INT identity,
  valorGlicemia INT NOT NULL,
  dataMedida DATE NOT NULL,
  idPaciente INT NOT NULL,
  
  PRIMARY KEY (idMedidaGlicemia),
  INDEX fk_Paciente_MedidaGlicemia_idx (idPaciente ASC),
  
  CONSTRAINT fk_Paciente_MedidaGlicemia
    FOREIGN KEY (idPaciente)
    REFERENCES Paciente (idPaciente)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);


-- inserindo medidas de glicemia
INSERT INTO MedidaGlicemia VALUES('159','2022-06-10','1');
INSERT INTO MedidaGlicemia VALUES('121','2022-06-11','1');
INSERT INTO MedidaGlicemia VALUES('98','2022-06-12','1');
INSERT INTO MedidaGlicemia VALUES('119','2022-06-13','1');
INSERT INTO MedidaGlicemia VALUES('109','2022-06-14','1');

INSERT INTO MedidaGlicemia VALUES('89','2022-06-10','2');
INSERT INTO MedidaGlicemia VALUES('91','2022-06-11','2');
INSERT INTO MedidaGlicemia VALUES('98','2022-06-12','2');
INSERT INTO MedidaGlicemia VALUES('83','2022-06-13','2');
INSERT INTO MedidaGlicemia VALUES('100','2022-06-14','2');



-- exibindo medidas
select *
from [MedidaGlicemia];