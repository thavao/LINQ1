CREATE DATABASE Detran;
GO
use Detran;
GO

CREATE TABLE Penalidades_Aplicadas(
	Id int IDENTITY(1,1),
	RazaoSocial VARCHAR(40),
	CNPJ VARCHAR(17),
	NomeMotorista VARCHAR(40),
	CPF CHAR(14),
	VigenciaDoCadastro DATE,
	CONSTRAINT PK_Penalidades_Aplicadas PRIMARY KEY (Id)
)
GO

CREATE PROCEDURE InserirPenalidade
	@RazaoSocial VARCHAR(40),
	@CNPJ VARCHAR(17),
	@NomeMotorista VARCHAR(40),
	@CPF CHAR(14),
	@VigenciaDoCadastro DATE
	AS
	BEGIN
		INSERT INTO Penalidades_Aplicadas
		VALUES (@RazaoSocial, @CNPJ, @NomeMotorista, @CPF, @VigenciaDoCadastro)
	END
GO

