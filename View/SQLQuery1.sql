create table [dbo].[Cadastro](
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(0,1),
	[Email]  VARCHAR(100) NOT NULL,
	[UserLogin] VARCHAR(45) NOT NULL,
	[UserPassword] VARCHAR(45) NOt NULL
)

create table [dbo].[Produtos](
	[ID] INT NOT NULL PRIMARY KEY IDENTITY(0,1),
	[Nome] VARCHAR(45) NOT NULL,
	[Descricao] VARCHAR(MAX) NOT NULL,
	[Preco] FLOAT NOT NULL,
	[Categoria] INT NOT NULL

)

--alter table dbo.Cadastro add column [Email] VARCHAR(45) NOT NULL 