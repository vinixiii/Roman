USE Roman;
GO

SELECT * FROM TiposDeUsuario;
GO

SELECT idUsuario, titulo AS tipo, email FROM Usuario
LEFT JOIN TiposDeUsuario
ON Usuario.idTipoUsuario = TiposDeUsuario.idTipoUsuario;
GO


SELECT idProfessor, nomeUsuario as Nome, Usuario.email, dataNascimento AS Nascimento, nomeEquipe FROM Professor
LEFT JOIN Usuario
ON Professor.idUsuario = Usuario.idUsuario
LEFT JOIN Equipe
ON Professor.idEquipe = Equipe.idEquipe
GO

SELECT * FROM Situacao;
GO

SELECT idTema, estado, titulo FROM Tema
LEFT JOIN Situacao
ON Tema.idSituacao = Situacao.idSituacao
GO

SELECT idProjeto, nomeUsuario as Nome, Tema.titulo AS Tema, Projeto.titulo, descricao FROM Projeto
LEFT JOIN Professor
ON Projeto.idProfessor = Professor.idProfessor
LEFT JOIN Usuario
ON Professor.idUsuario = Usuario.idUsuario
LEFT JOIN Tema
ON Projeto.idTema = Tema.idTema
GO


