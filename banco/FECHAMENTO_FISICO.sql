CREATE DATABASE Projeto4

GO

USE Projeto4

CREATE TABLE Funcionario (
CPF nvarchar(30) PRIMARY KEY,
Nome nvarchar(100) NOT NULL,
DataNascimento nvarchar(30) NOT NULL,
Telefone nvarchar(30) NOT NULL,
Endereco nvarchar(200) NOT NULL,
Porcentagem float NOT NULL,
Ativo bit
)

CREATE TABLE Servico (
IdServico int PRIMARY KEY IDENTITY(1,1),
Descricao nvarchar(100),
Valor decimal(12,2) NOT NULL,
Ativo bit
)

CREATE TABLE Produto (
IdProduto int PRIMARY KEY IDENTITY(1,1),
Quantidade int NOT NULL,
Descricao nvarchar(100),
Valor decimal(12,2) NOT NULL,
Ativo bit
)

CREATE TABLE Cliente (
CPF nvarchar(30) PRIMARY KEY,
Nome nvarchar(100),
DataNascimento nvarchar(30),
Email nvarchar(100),
Endereco nvarchar(200),
Telefone nvarchar(30),
Ativo bit
)

CREATE TABLE Venda (
IdVenda int PRIMARY KEY IDENTITY(1,1),
CPFFuncionario nvarchar(30),
CPFCliente nvarchar(30),
Data nvarchar(30) NOT NULL,
Valor decimal(12,2) NOT NULL,
FOREIGN KEY(CPFFuncionario) REFERENCES Funcionario (CPF),
FOREIGN KEY(CPFCliente) REFERENCES Cliente (CPF)
)

CREATE TABLE VendaProdutoServico (
IdVenda int,
IdProduto int,
IdServico int,
FOREIGN KEY(IdVenda) REFERENCES Venda (IdVenda),
FOREIGN KEY(IdProduto) REFERENCES Produto (IdProduto),
FOREIGN KEY(IdServico) REFERENCES Servico (IdServico)
)

CREATE TABLE Usuario (
IdUsuario int PRIMARY KEY IDENTITY(1,1),
Nome nvarchar(100),
Login nvarchar(100) UNIQUE,
Senha nvarchar(100),
tipoUsuario int,
Ativo bit
)


INSERT INTO Usuario VALUES('ADMINISTRADOR', 'ADMINISTRADOR', 'ADMINISTRADOR', 0, 0)

SELECT * FROM Usuario