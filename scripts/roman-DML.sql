USE Roman;
GO

INSERT INTO TiposDeUsuario (titulo)
VALUES ('Administrador'), ('Professor');
GO

INSERT INTO Usuario (idTipoUsuario, email, senha, nomeUsuario)
VALUES (2, 'figueiroa@email.com', 'senha123', 'Vinícius Figueiroa'), (2, 'lordelo@email.com', 'senha456', 'Vinícius Lordelo' ),
	   (2, 'taila@email.com', 'senha123', 'Taila Franco' ), (2, 'rafael@email.com', 'senha456', 'Rafael Cecatto'),
	   (1, 'admin@email.com', 'senha123', 'Caique');
GO

INSERT INTO Equipe(nomeEquipe)
VALUES ( 'Desenvolvimento'), ('Redes'),
       ( 'Multimídia');
GO

INSERT INTO Professor(idUsuario, idEquipe, dataNascimento)
VALUES (1, 1,'13/07/1999'), (2, 2,'19/10/2002'),
	   (3, 2,'17/10/1995'), (2, 3, '05/05/2000'); 
GO

INSERT INTO Situacao (estado)
VALUES ('Ativo'), ('Inativo');
GO

INSERT INTO Tema (titulo)
VALUES ('API'), ('React Js');
GO

INSERT INTO Projeto (idProfessor, idTema, titulo, descricao)
VALUES (1, 2, 'SP Medical Group', 'Criar uma aplicação de gerenciamento para as clínicas médicas SP Medical Group'), 
       (3, 1, 'Gufi', 'Criar uma API de gerenciamento de eventos');
GO


