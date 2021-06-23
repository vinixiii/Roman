USE Roman;
GO

INSERT INTO TiposDeUsuario (titulo)
VALUES ('Administrador'), ('Professor');
GO

INSERT INTO Usuario (idTipoUsuario, email, senha)
VALUES (2, 'figueiroa@email.com', 'senha123'), (2, 'lordelo@email.com', 'senha456'),
	   (2, 'taila@email.com', 'senha123'), (2, 'rafael@email.com', 'senha456'),
	   (1, 'admin@email.com', 'senha123');
GO

INSERT INTO Equipe(equipe)
VALUES ( 'Desenvolvimento'), ('Redes'),
       ( 'Multim�dia');
GO

INSERT INTO Professor(idUsuario, idEquipe, nome, dataNascimento)
VALUES (1, 1, 'Vin�cius Figueiroa', '13/07/1999'), (2, 2, 'Vin�cius Lordelo', '19/10/2002'),
	   (3, 2, 'Taila Franco', '17/10/1995'), (2, 3, 'Rafael Cecatto', '05/05/2000'); 
GO

INSERT INTO Situacao (situacao)
VALUES ('Ativo'), ('Inativo');
GO

INSERT INTO Tema (titulo)
VALUES ('Gest�o'), ('HQs');
GO

INSERT INTO Projeto (idProfessor, idTema, titulo, descricao)
VALUES (1, 2, 'Listagem de Personagens', 'Projeto Final'), 
       (2, 1, 'Controle de Estoque', 'Projeto para os alunos desenvolverem capacidades administrativas');
GO


