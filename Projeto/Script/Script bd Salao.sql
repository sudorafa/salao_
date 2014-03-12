create database Salao

use Salao

create table Pessoa (
idPessoa integer primary key,
cpf varchar (100),
rg varchar (100),
nome varchar (100),
dataDeNascimento varchar(100),
email varchar(100),
);

create table Cliente(
idCliente integer primary key,
idPessoa integer references Pessoa(idPessoa)
);
create table Servico(
idServico integer primary key,
valor decimal,
tipo varchar (100)
);

create table ServicoRealizado(
idServico integer references Servico (idServico),
idCliente integer references Cliente (idCliente)
);

create table Funcionario(
idFuncionario integer primary key,
idPessoa integer references Pessoa(idPessoa),
idCliente integer references Cliente (idCliente),
idServico integer references Servico (idServico)
);

create table Estoque(
idProduto integer primary key,
produto varchar (100),
quantidade integer,
valor decimal
);

create table FuncionarioUtilizou (
idFuncionario integer references Funcionario (idFuncionario),
idProduto integer references Estoque (idProduto)
);

create table ServicoUtilizou(
idServico integer references Servico (idServico),
idProduto integer references Estoque (idProduto)
);
