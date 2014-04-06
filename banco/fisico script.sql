

CREATE TABLE Cliente (
Nome varchar(100) not null,
CPF varchar(20) not null,
Telefone varchar(20) not null,
Telefone2 varchar(20) null,
Endereco varchar(100) not null,
idCliente Integer() PRIMARY KEY,
DataDeNasc varchar(20) not null,
Email varchar (100) not null
)

CREATE TABLE Funcionario (
Nome varchar (100) not null,
Endereco varchar (100) not null,
idFuncionario Integer() PRIMARY KEY,
Telefone varchar (20) not null,
Telefone2 varchar (20) not null,
DataDeNasc varchar (20) not null,
CPF varchar (20) not null,
Porcentagem Integer not null,
)

CREATE TABLE Servico (
Descricao Texto(1),
Valor Decimal(),
idServico Integer() PRIMARY KEY,
Login Texto(1)
)

CREATE TABLE Produto (
Valor Decimal(),
Descricao Texto(1),
idProduto Integer() PRIMARY KEY,
qtdEstoque Integer(),
Login Texto(1)
)

CREATE TABLE Usuario (
Senha Texto(1),
Login Texto(1) PRIMARY KEY,
Nome Texto(1),
Nivel Boolean(),
possui_Login Texto(1)
)

CREATE TABLE RealizaServico (
idServico Integer(),
idFuncionario Integer(),
FOREIGN KEY(idServico) REFERENCES Servico (idServico),
FOREIGN KEY(idFuncionario) REFERENCES Funcionario (idFuncionario)
)

ALTER TABLE Cliente ADD FOREIGN KEY(Login) REFERENCES Usuario (Login)
ALTER TABLE Funcionario ADD FOREIGN KEY(Login) REFERENCES Usuario (Login)
ALTER TABLE Servico ADD FOREIGN KEY(Login) REFERENCES Usuario (Login)
ALTER TABLE Produto ADD FOREIGN KEY(Login) REFERENCES Usuario (Login)
