-- Script per creazione tabella

CREATE TABLE [dbo].[tbl_Utenti]
(
[Id] INT IDENTITY(1, 1) NOT NULL,
[NomeUtente] NVARCHAR(40) UNIQUE NOT NULL,
[Password] NVARCHAR(20) NOT NULL,
[Nome] NVARCHAR(20) NOT NULL,
[Cognome] NVARCHAR(20) NOT NULL,
[Reparto] NVARCHAR(20) NOT NULL,
[Livello] INT NOT NULL,
CONSTRAINT [PK_Utenti] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE INDEX [I_Id_Utenti] ON [dbo].[tbl_Utenti](Id);