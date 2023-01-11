--CREATE TABLE Funcionario (
 -- IdFunc int identity (1,1),
 -- nomeFunc  varchar(50) not null,
 -- cpf  char(11) unique not null,
 -- celular  char (11),
 -- login  varchar(45) unique not null,
 -- senha varchar(15) not null,
 -- perfil  varchar(10) not null,
 -- constraint pk_funcionario PRIMARY KEY (IdFunc)
--)

-- insert into Funcionario (nomeFunc,cpf,celular,login,senha,perfil)
-- values ('Administrador','12345678910','13123456789','admin','admin','Gerente');

----------------------------------------------------------------------------------------------

-- select * from Funcionario

----------------------------------------------------------------------------------------------

--create procedure ps_Login
--Parâmetros
--@login varchar(45),
--@senha varchar(15)
--as
--Corpo
--select login,senha from Funcionario
--where login=@login and senha=@senha

----------------------------------------------------------------------------------------------

-- CREATE TABLE ProdutoFinal (
-- IdProduto int identity (1,1),
-- nomeProduto varchar(50) not null,
-- tipoProduto varchar(15) not null,
-- quantidade int not null,
-- valor numeric(5,2) not null,
-- constraint pk_produto PRIMARY KEY (IdProduto)
--)

----------------------------------------------------------------------------------------------

-- CREATE TABLE Pedido (
-- IdPedido int identity(1,1),
-- nomeCliente varchar (100),
-- telefoneCliente char(11),
-- IdProduto int not null,
-- IdFunc int not null,
-- constraint pk_pedido PRIMARY KEY (IdPedido),
-- constraint fk_pedido_produtofinal foreign key (IdProduto) references ProdutoFinal (IdProduto),
-- constraint fk_pedido_funcionario foreign key (IdFunc) references Funcionario (IdFunc)
--)

----------------------------------------------------------------------------------------------

-- **PROCEDURES** --

-- create procedure pi_Funcionario
-- @nomeFunc varchar(50),
-- @cpf char(11),
-- @celular char(11),
-- @login varchar(45),
-- @senha varchar(15),
-- @perfil varchar(10)

-- as

-- insert into Funcionario (nomeFunc,cpf,celular,login,senha,perfil)
-- values (@nomeFunc,@cpf,@celular,@login,@senha,@perfil);
--GO

----------------------------------------------------------------------------------------------

-- create procedure pd_Funcionario
-- @cpf char(11)

-- as

-- delete from Funcionario
-- where cpf=@cpf;
--GO


----------------------------------------------------------------------------------------------

--create procedure pu_Funcionario
--@IdFunc int,
--@nomeFunc varchar(50),
--@celular char(11),
--@senha varchar(15),
--@perfil varchar(10)

--as

--update Funcionario
--set nomeFunc=@nomeFunc,
--celular=@celular,
--senha=@senha,
--perfil=@perfil
--where IdFunc=@IdFunc

--GO

----------------------------------------------------------------------------------------------

--create procedure ps_Funcionario
--@nomeFunc varchar(50)

--as

--select * from Funcionario
--where nomeFunc like '%' + @nomeFunc + '%'
--order by nomeFunc asc

--GO

----------------------------------------------------------------------------------------------

--create procedure pi_Produto
--@nomeProduto varchar(50),
--@tipoProduto varchar(15),
--@quantidade int,
--@valor numeric(5,2)

--as

--insert into ProdutoFinal (nomeProduto,tipoProduto,quantidade,valor)
--values(@nomeProduto,@tipoProduto,@quantidade,@valor)

--GO

----------------------------------------------------------------------------------------------

--create procedure pd_Produto
--@IdProduto int

--as

--delete from ProdutoFinal
--where IdProduto=@IdProduto

--GO


----------------------------------------------------------------------------------------------

--create procedure pu_Produto
--@nomeProduto varchar(50),
--@tipoProduto varchar(15),
--@quantidade int,
--@valor numeric(5,2)

--as

--update ProdutoFinal
--set nomeProduto = @nomeProduto,
--tipoProduto=@tipoProduto,
--quantidade=@quantidade,
--valor=@valor
--where nomeProduto=@nomeProduto

--GO

----------------------------------------------------------------------------------------------

--create procedure ps_Produto

--as

--select * from ProdutoFinal

--GO

----------------------------------------------------------------------------------------------

--create procedure ps_ProdutoLanches
--@tipoProduto varchar(15)
--as

--select * from ProdutoFinal
--where tipoProduto like 'Lanches'
--order by nomeProduto asc

--GO

----------------------------------------------------------------------------------------------

--create procedure ps_ProdutoSalgados
--@tipoProduto varchar(15)
--as

--select * from ProdutoFinal
--where tipoProduto like 'Salgados'
--order by nomeProduto asc

--GO

----------------------------------------------------------------------------------------------

--create procedure ps_ProdutoPorcoes
--@tipoProduto varchar(15)
--as

--select * from ProdutoFinal
--where tipoProduto like 'Porções'
--order by nomeProduto asc

--GO

----------------------------------------------------------------------------------------------

--create procedure ps_ProdutoMolhos
--@tipoProduto varchar(15)
--as

--select * from ProdutoFinal
--where tipoProduto like 'Molhos'
--order by nomeProduto asc

--GO

----------------------------------------------------------------------------------------------

--create procedure ps_ProdutoBebidas
--@tipoProduto varchar(15)
--as

--select * from ProdutoFinal
--where tipoProduto like 'Bebidas'
--order by nomeProduto asc

--GO

----------------------------------------------------------------------------------------------


--exec ps_Produto

--drop procedure ps_Produto

--select * from ProdutoFinal