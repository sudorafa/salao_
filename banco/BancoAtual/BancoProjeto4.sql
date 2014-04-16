CREATE TABLE Relatorio (
IdRelatorio Int PRIMARY KEY,
ValorTotal money,
Data nvarchar(100),
CodServ nvarchar(100),
CodProd nvarchar(100),
FuncCPF nvarchar(100),
ClienCPF nvarchar(100)
)

CREATE TABLE Usuario (
IdUsuario Int PRIMARY KEY,
isGestor Int,
Login nvarchar(100),
Senha nvarchar(100),
Nome nvarchar(100),
Excluido bit
)

CREATE TABLE Servicos (
IdServicos Int PRIMARY KEY,
Descricao nvarchar(100),
Valor money
)

CREATE TABLE Funcionario (
CPF nvarchar(100) PRIMARY KEY,
Nome nvarchar(100),
Telefone nvarchar(100),
Endereco nvarchar(100),
Porcentagem Double,
Data_Nascimento nvarchar(100),
Excluido bit
)

CREATE TABLE ManterFuncionario (
FuncCPF nvarchar(100),
IdUsuarioF Int,
FOREIGN KEY(FuncCPF) REFERENCES Funcionario (CPF),
FOREIGN KEY(IdUsuarioF) REFERENCES Usuario (IdUsuario)
)

CREATE TABLE Cliente (
CPF nvarchar(100) PRIMARY KEY,
Endereco nvarchar(100),
Telefone nvarchar(100),
Telefone2 nvarchar(100),
Data_Nascimento nvarchar(100),
Email nvarchar(100),
Nome nvarchar(100),
Excluido bit
)

CREATE TABLE ManterUsuario (
IdUsuario Int,
ClienCPF nvarchar(100),
FOREIGN KEY(IdUsuario) REFERENCES Usuario (IdUsuario),
FOREIGN KEY(ClienCPF) REFERENCES Cliente (CPF)
)

CREATE TABLE Produtos (
IdProduto Int PRIMARY KEY,
Codigo varchar(100),
Descricao nvarchar(100),
Valor Money,
Quantidade_Estoque Int,
Excluido bit
)

CREATE TABLE ManterProdutos (
CodProdt nvarchar(100),
IdUsuarioP Int,
FOREIGN KEY(CodProdt) REFERENCES Produtos (CodProd),
FOREIGN KEY(IdUsuarioP) REFERENCES Usuario (IdUsuario)
)

CREATE TABLE ManterServico (
CodServc nvarchar(100),
IdUsuarioS Int,
FOREIGN KEY(CodServc) REFERENCES Servicos (CodServ),
FOREIGN KEY(IdUsuarioS) REFERENCES Usuario (IdUsuario)
)

ALTER TABLE Relatorio ADD FOREIGN KEY(CodServc) REFERENCES Servicos (CodServ)
ALTER TABLE Relatorio ADD FOREIGN KEY(CodProdt) REFERENCES Produtos (CodProd)
ALTER TABLE Relatorio ADD FOREIGN KEY(FuncCPF) REFERENCES Funcionario (CPF)
ALTER TABLE Relatorio ADD FOREIGN KEY(ClienCPF) REFERENCES Cliente (CPF)
