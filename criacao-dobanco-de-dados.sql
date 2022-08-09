/* BANCO UTILIZADO: 
BANCO UTILIZADO: ORACLE  11G EXPRESS EDITION
LINK: https://www.oracle.com/database/technologies/xe-prior-release-downloads.html
*/

/* CRIAÇÃO DAS TABELAS */

CREATE TABLE Cooperativa (
 Id int NOT NULL,
 Descricao varchar(50) NOT NULL,
 
 PRIMARY KEY (Id)
);

CREATE TABLE ContaCorrente (
 Id int NOT NULL,
 Cooperativa_Id int NOT NULL,
 Numero varchar(50) NOT NULL,
 NomeCooperado varchar(50) NOT NULL,
 
 CONSTRAINT FK_ContaCorrente_Cooperativa 
 FOREIGN KEY (Cooperativa_Id) 
 REFERENCES Cooperativa (Id),
 
 CONSTRAINT UK_Cooperativa_Numero 
 UNIQUE (Cooperativa_Id,Numero),
 
 PRIMARY KEY(Id)
);

CREATE TABLE ContatoFavorito (
 Id int NOT NULL,
 ContaCorrente_id int NOT NULL,
 Nome varchar(50) NOT NULL,
 TipoChavePix int NOT NULL,
 ChavePix varchar(100) NOT NULL,
 
 CONSTRAINT FK_ContatoFavorito_CC
 FOREIGN KEY (ContaCorrente_id) 
 REFERENCES ContaCorrente (Id),

 CONSTRAINT UK_CC_ChavePix 
 UNIQUE (ContaCorrente_Id,ChavePix),

 PRIMARY KEY(Id)
);

/* INSERÇÃO DE DADOS */

/* COOPERATIVAS */
INSERT INTO Cooperativa (Id, Descricao) values (1, 'Cooperativa A');
INSERT INTO Cooperativa (Id, Descricao) values (2, 'Cooperativa A');
INSERT INTO Cooperativa (Id, Descricao) values (3, 'Cooperativa A');

/* CONTAS CORRENTES */
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (1, 1, '123456', 'João');
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (2, 1, '456789', 'Maria');
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (3, 1, '012348', 'Pedro');
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (4, 2, '129', 'Luana');
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (5, 2, '328', 'Júlia');
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (6, 3, '129', 'Guimarães');
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (7, 3, '456789', 'Fonseca');
INSERT INTO ContaCorrente (Id, Cooperativa_Id, Numero, NomeCooperado) values (8, 3, '885544', 'Carol');

/* CRIAÇÃO SEQUENCES */
CREATE SEQUENCE Cooperativa_Seq;
CREATE SEQUENCE ContatoFavorito_Seq;
CREATE SEQUENCE ContaCorrente_Seq;






