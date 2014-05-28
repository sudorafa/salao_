
CREATE DATABASE Projeto4
GO
USE [Projeto4]
GO

CREATE procedure [dbo].[RelatorioBalacoDiario]

as
declare @valorTotalServico decimal(12,2),
@descricaoProduto varchar(50), 
@entradaProduto int,
@saidaProduto int, 
@valorUnitario decimal(12,2),
@valorTotalProduto decimal(12,2),
@valorTotalServicoProduto decimal(12,2)




select @descricaoProduto = p.Descricao, @entradaProduto = p.Quantidade , 
@saidaProduto = count(vps.idProduto), 
@valorUnitario = p.Valor, @valorTotalProduto = sum(p.Valor)
from VendaProdutoServico as vps
inner join Produto as p on p.IdProduto = vps.IdProduto
inner join Venda as v on vps.IdVenda = v.IdVenda
where datediff(DD, v.DataHoje ,getdate()) <= 24

GROUP BY p.Descricao, p.Quantidade, p.Valor, v.DataHoje

select @valorTotalServico = sum(s.Valor) from VendaProdutoServico as vps
inner join Servico as s on s.IdServico = vps.IdServico
inner join Venda as v on vps.IdVenda = v.IdVenda
where datediff(DD, v.DataHoje ,getdate()) <= 24
GROUP BY  s.Valor , v.DataHoje

select @descricaoProduto as Produto, @entradaProduto as EntradaProduto,
 @saidaProduto as SaidaProdutro, 
 @valorUnitario as ValorUnitarioProduto, @valorTotalProduto as TotalSaidaProduto,
 s.Descricao as Servico, s.Valor as ValorUnitarioServico,
count(vps.IdServico) as QuantidadeTotalServico,
sum(s.Valor) as TotalSaidaServico, ( @valorTotalServico +  @valorTotalProduto) as ValorTotalServicoProduto
from VendaProdutoServico as vps
inner join Servico as s on s.IdServico = vps.IdServico
inner join Venda as v on vps.IdVenda = v.IdVenda
where datediff(HH, v.DataHoje ,getdate()) <= 24
GROUP BY s.Descricao, s.Valor, v.DataHoje



		


GO
/****** Object:  StoredProcedure [dbo].[RelatorioFuncionario]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[RelatorioFuncionario]
as

SELECT f.Nome as Nome, count(vps.IdServico) as Quantidade, sum(s.valor) as Valor
from dbo.Funcionario as f

inner join Venda as v on v.CPFFuncionario = f.CPF
inner join VendaProdutoServico as vps on vps.IdVenda = v.IdVenda 
inner join Servico as s on s.IdServico = vps.IdServico

GROUP BY  f.Nome


GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[CPF] [nvarchar](30) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[DataNascimento] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Endereco] [nvarchar](200) NOT NULL,
	[Telefone] [nvarchar](30) NOT NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[CPF] [nvarchar](30) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[DataNascimento] [nvarchar](30) NOT NULL,
	[Telefone] [nvarchar](30) NOT NULL,
	[Endereco] [nvarchar](200) NOT NULL,
	[Porcentagem] [float] NOT NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produto]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[IdProduto] [int] IDENTITY(1,1) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Descricao] [nvarchar](100) NULL,
	[Valor] [decimal](12, 2) NOT NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Servico]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[IdServico] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](100) NULL,
	[Valor] [decimal](12, 2) NOT NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NULL,
	[Login] [nvarchar](100) NULL,
	[Senha] [nvarchar](100) NULL,
	[tipoUsuario] [int] NULL,
	[Ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venda]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[IdVenda] [int] IDENTITY(1,1) NOT NULL,
	[CPFFuncionario] [nvarchar](30) NULL,
	[CPFCliente] [nvarchar](30) NULL,
	[Valor] [decimal](12, 2) NOT NULL,
	[DataHoje] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendaProdutoServico]    Script Date: 23/05/2014 10:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendaProdutoServico](
	[IdVenda] [int] NULL,
	[IdProduto] [int] NULL,
	[IdServico] [int] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD FOREIGN KEY([CPFCliente])
REFERENCES [dbo].[Cliente] ([CPF])
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD FOREIGN KEY([CPFFuncionario])
REFERENCES [dbo].[Funcionario] ([CPF])
GO
ALTER TABLE [dbo].[VendaProdutoServico]  WITH CHECK ADD FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[VendaProdutoServico]  WITH CHECK ADD FOREIGN KEY([IdServico])
REFERENCES [dbo].[Servico] ([IdServico])
GO
ALTER TABLE [dbo].[VendaProdutoServico]  WITH CHECK ADD FOREIGN KEY([IdVenda])
REFERENCES [dbo].[Venda] ([IdVenda])
GO
