CREATE TABLE Usuario (
IdUsuario Int PRIMARY KEY identity,
tipoUsuario Int,
Login nvarchar(100) unique,
Senha nvarchar(100),
Nome nvarchar(20),
Ativo bit
)

CREATE TABLE Cliente (
CPF nvarchar(20) PRIMARY KEY,
Nome nvarchar(20),
Endereco nvarchar(200),
Telefone nvarchar(30),
DataNascimento nvarchar(20),
Email nvarchar(20),
Ativo bit
)

CREATE TABLE Funcionario (
CPF nvarchar(20) PRIMARY KEY,
Nome nvarchar(100),
Telefone nvarchar(30),
Endereco nvarchar(200),
Porcentagem float,
DataNascimento nvarchar(20),
Ativo bit
)


CREATE TABLE Servico (
IdServico int PRIMARY KEY identity,
Descricao nvarchar(100),
Valor decimal(12,2),
Ativo bit
)

CREATE TABLE Produto (
IdProduto int PRIMARY KEY identity,
Descricao nvarchar(20),
Valor decimal(12,2),
Quantidade Int,
Ativo bit
)

CREATE TABLE Venda (
IdVenda Int PRIMARY KEY identity,
ValorTotal decimal(12,2),
Data nvarchar(20),
CPFFuncionario nvarchar(20),
CPFCliente nvarchar(20),
FOREIGN KEY (CPFFuncionario) REFERENCES Funcionario (CPF),
FOREIGN KEY (CPFCliente) REFERENCES Cliente (CPF)
)

CREATE TABLE VendaProdutoServico(
IdVenda int not null,
IdProduto int, 
IdServico int,
FOREIGN KEY (IdVenda) REFERENCES Venda (IdVenda),
FOREIGN KEY (IdProduto) REFERENCES Produto (IdProduto),
FOREIGN KEY (IdServico) REFERENCES Servico (IdServico)
)
