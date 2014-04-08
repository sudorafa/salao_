CREATE TABLE Relatorio (
IdRelatorio Int PRIMARY KEY,
ValorTotal money,
Data nvarchar(20),
CodServ nvarchar(20),
CodProd nvarchar(20),
FuncCPF nvarchar(20),
ClienCPF nvarchar(20)
)

CREATE TABLE Usuario (
IdUsuario Int PRIMARY KEY,
TipoUsar Int,
Login nvarchar(20),
Senha nvarchar(20),
Nome nvarchar(20)
)

CREATE TABLE Servicos (
CodServ nvarchar(20) PRIMARY KEY,
Descricao nvarchar(20),
Valor money
)

CREATE TABLE Funcionario (
CPF nvarchar(20) PRIMARY KEY,
Nome nvarchar(20),
Telefone nvarchar(20),
Endereco nvarchar(20),
Porcentagem Int,
DatNascimento nvarchar(20)
)

CREATE TABLE ManterFuncionario (
FuncCPF nvarchar(20),
IdUsuarioF Int,
FOREIGN KEY(FuncCPF) REFERENCES Funcionario (CPF),
FOREIGN KEY(IdUsuarioF) REFERENCES Usuario (IdUsuario)
)

CREATE TABLE Cliente (
CPF nvarchar(20) PRIMARY KEY,
Endereco nvarchar(20),
Telefone nvarchar(20),
Telefone2 nvarchar(20),
DatNascimento nvarchar(20),
Email nvarchar(20),
Nome nvarchar(20)
)

CREATE TABLE ManterUsuario (
IdUsuario Int,
ClienCPF nvarchar(20),
FOREIGN KEY(IdUsuario) REFERENCES Usuario (IdUsuario),
FOREIGN KEY(ClienCPF) REFERENCES Cliente (CPF)
)

CREATE TABLE Produtos (
CodProd nvarchar(20) PRIMARY KEY,
Descricao nvarchar(20),
Valor Money,
QntProd Int
)

CREATE TABLE ManterProdutos (
CodProdt nvarchar(20),
IdUsuarioP Int,
FOREIGN KEY(CodProdt) REFERENCES Produtos (CodProd),
FOREIGN KEY(IdUsuarioP) REFERENCES Usuario (IdUsuario)
)

CREATE TABLE ManterServico (
CodServc nvarchar(20),
IdUsuarioS Int,
FOREIGN KEY(CodServc) REFERENCES Servicos (CodServ),
FOREIGN KEY(IdUsuarioS) REFERENCES Usuario (IdUsuario)
)

ALTER TABLE Relatorio ADD FOREIGN KEY(CodServc) REFERENCES Servicos (CodServ)
ALTER TABLE Relatorio ADD FOREIGN KEY(CodProdt) REFERENCES Produtos (CodProd)
ALTER TABLE Relatorio ADD FOREIGN KEY(FuncCPF) REFERENCES Funcionario (CPF)
ALTER TABLE Relatorio ADD FOREIGN KEY(ClienCPF) REFERENCES Cliente (CPF)
