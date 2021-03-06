IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Roman')
  BEGIN

    CREATE DATABASE Roman
	END
	GO

USE Roman;
GO

DROP TABLE IF EXISTS TiposDeUsuario;
GO

CREATE TABLE TiposDeUsuario (
  idTipoUsuario INT PRIMARY KEY IDENTITY NOT NULL,
  titulo VARCHAR(200) NOT NULL
);
GO

DROP TABLE IF EXISTS Usuario;
GO

CREATE TABLE Usuario (
  idUsuario INT PRIMARY KEY IDENTITY NOT NULL,
  idTipoUsuario INT FOREIGN KEY REFERENCES TiposDeUsuario (idTipoUsuario) NOT NULL,
  email VARCHAR(200) NOT NULL UNIQUE,
  senha VARCHAR(200) NOT NULL
);
GO

DROP TABLE IF EXISTS Equipe;
GO

CREATE TABLE Equipe(
  idEquipe INT PRIMARY KEY IDENTITY NOT NULL,	
  nomeEquipe VARCHAR(200) NOT NULL
);
GO

DROP TABLE IF EXISTS Professor;
GO

CREATE TABLE Professor (
  idProfessor INT PRIMARY KEY IDENTITY NOT NULL,
  idUsuario INT FOREIGN KEY REFERENCES Usuario (idUsuario) NOT NULL,
  idEquipe INT FOREIGN KEY REFERENCES Equipe (idEquipe) NOT NULL,
  nome VARCHAR(200) NOT NULL,
  dataNascimento VARCHAR(200) NOT NULL
);
GO

DROP TABLE IF EXISTS Situacao;
GO

CREATE TABLE Situacao (
  idSituacao INT PRIMARY KEY IDENTITY NOT NULL,
  estado VARCHAR(200) NOT NULL
);
GO

DROP TABLE IF EXISTS Tema;
GO

CREATE TABLE Tema(
  idTema INT PRIMARY KEY IDENTITY NOT NULL,
  idSituacao INT FOREIGN KEY REFERENCES Situacao (idSituacao) DEFAULT '1',
  titulo VARCHAR(200) NOT NULL
);
GO

DROP TABLE IF EXISTS Projeto;
GO

CREATE TABLE Projeto(
  idProjeto INT PRIMARY KEY IDENTITY NOT NULL,
  idProfessor INT FOREIGN KEY REFERENCES Professor (idProfessor) NOT NULL,
  idTema INT FOREIGN KEY REFERENCES Tema (idTema) NOT NULL,
  titulo VARCHAR(200) NOT NULL,
  descricao VARCHAR(200) NOT NULL
);
GO



