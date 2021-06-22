USE Roman;
GO

SELECT * FROM TiposDeUsuario;
GO

SELECT idUsuario, titulo AS tipo, email FROM Usuario
LEFT JOIN TiposDeUsuario
ON Usuario.idTipoUsuario = TiposDeUsuario.idTipoUsuario;
GO

SELECT * FROM Especialidade
GO

SELECT idProfessor, nome, Usuario.email, dataNascimento AS Nascimento, especialidade FROM Professor
LEFT JOIN Especialidade
ON Professor.idEspecialidade = Especialidade.idEspecialidade
LEFT JOIN Usuario
ON Professor.idUsuario = Usuario.idUsuario
GO

SELECT * FROM Situacao;
GO

SELECT idTema, situacao, titulo FROM Tema
LEFT JOIN Situacao
ON Tema.idSituacao = Situacao.idSituacao
GO

SELECT idProjeto, nome, Tema.titulo AS Tema, Projeto.titulo, descricao FROM Projeto
LEFT JOIN Professor
ON Projeto.idProfessor = Professor.idProfessor
LEFT JOIN Tema
ON Projeto.idTema = Tema.idTema
GO

SELECT idEquipe, nome, equipe FROM Equipe
LEFT JOIN Professor
ON Equipe.idProfessor = Professor.idProfessor
GO
