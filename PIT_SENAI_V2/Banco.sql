/*
create user gerencia@localhost identified by 'Gerencia123';
GRANT ALL PRIVILEGES ON `pit_senai_v2`.* TO 'gerencia'@'localhost';
flush privileges;

revoke all privileges on *.* from 'gerencia'@'localhost'
*/
create database pit_senai_v2;
use pit_senai_v2;


CREATE TABLE acessos (
    idAcesso INT PRIMARY KEY,
    acesso VARCHAR(40) NOT NULL UNIQUE
);
insert into acessos (idAcesso,acesso)
	values
    (1,'Master'),
    (2,'Financeiro'),
    (3,'Estoque'),
    (4,'Caixa'),
    (5,'Vendedor');
CREATE TABLE funcionarios (
    idFuncionario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(255) NOT NULL,
    senha VARCHAR(255) NOT NULL,
    documento VARCHAR(100) NOT NULL UNIQUE,
    endereco VARCHAR(255),
    cep VARCHAR(20),
    telefone VARCHAR(50),
    contato VARCHAR(50),
    email VARCHAR(255),
    idAcesso INT NOT NULL,
    FOREIGN KEY (idAcesso)
        REFERENCES acessos (idAcesso)
);
insert into 
	funcionarios
values
    (1,'Master',md5('senha'),'11111111111','Rua maestrio de solza filho','11111111','(11)1111-1111',null,'gerencia@email.com',1),
    (2,'Financeiro',md5('senha'),'22222222222','Alameda das finanças', '22222222','(22)2222-2222',null,'financeiro@mail.com',2),
    (3,'Estoque',md5('senha'),'33333333333','Avenida dos estoquistas','33333333','(33)3333-3333',null,'estoque@gmail.com',3),
    (4,'Caixa',md5('senha'),'44444444444','Avenida duque de caxias','44444444','(44)4444-4444',null,'caixa@mail.com',4),
    (5,'Vendedor',md5('senha'),'55555555555','Rua das vendas','55555555','(55)5555-5555',null,'vendedoramaro@gmail.com',5);
-- ----------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE fornecedores (
    idFornecedor INT PRIMARY KEY AUTO_INCREMENT,
    fornecedor VARCHAR(100) NOT NULL UNIQUE,
    responsavel VARCHAR(255) NOT NULL,
    descricao VARCHAR(255),
    telefone VARCHAR(20) NOT NULL,
    contato VARCHAR(20),
    email VARCHAR(255) UNIQUE
);

insert into fornecedores
values
(0,'Magalu','Luao','imoveis','(00) 1111-1111','(00) 2344-2333','magalu@mail.com'),
(0,'Redes Mar','Redesmar','Infra redes', '(22)2344-3333', null, 'redesmar@mail.com');

-- drop procedure procurarFornecedores;
delimiter ##
create procedure procurarFornecedores(pesquisa varchar(255))	
begin
	select * from fornecedores as f
    where 
		if(pesquisa = null, null,
		f.fornecedor like concat('%',pesquisa,'%')
		or   
		f.idFornecedor like pesquisa);
end;##
delimiter ;
-- call procurarFornecedores('');

CREATE TABLE categorias (
    idCategoria INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(100) NOT NULL UNIQUE
);
insert into categorias 
values
(0,'cabos'),
(0,'redes'),
(0,'estantes'),
(0,'armarios');
CREATE TABLE produtos (
    idProduto INT PRIMARY KEY AUTO_INCREMENT,
    nomeProduto VARCHAR(255) NOT NULL UNIQUE,
    preco DECIMAL(32 , 2 ) DEFAULT 0,
    estoqueMinimo INT DEFAULT 0,
    idCategoria INT,
    idFornecedor int NOT NULL,
    FOREIGN KEY (idCategoria)
        REFERENCES categorias (idCategoria),
    FOREIGN KEY (idFornecedor)
        REFERENCES fornecedores (idFornecedor)
);

insert into produtos values
(0,'Rede 1',123.22,2,2,2),
(0,'Armario 5 portas',123.22,2,4,1),
(0,'Cabo de cobre',123.22,2,1,2);

-- drop procedure procurarProdutos;
delimiter ##
create procedure procurarProdutos (pesquisa varchar(255))	
begin
		select
		p.idProduto,
        p.nomeProduto,
        p.preco,
        p.estoqueMinimo,
        Count(*) as 'emEstoque',
        c.categoria,
        f.fornecedor        
    from 
		produtos as p
	inner join 
		estoque as e on e.idProduto = p.idProduto
	inner join 
		categorias as c on c.idCategoria = p.idCategoria
    inner join
		fornecedores as f on f.idFornecedor = p.idFornecedor
    where 
		if(@pesquisa = null, null,
				p.nomeProduto like concat('%',@pesquisa,'%') or
				p.idProduto like @pesquisa)
		and saida is null
	group by p.idProduto
    order by idProduto asc;
end;##
delimiter ;
-- call procurarProdutos('');


drop table estoque;
CREATE TABLE estoque (
    idEstoque INT PRIMARY KEY AUTO_INCREMENT,
    vendido BIT(1) DEFAULT 0,
    entrada DATE default (curdate()),
    saida DATE,
    idProduto INT NOT NULL,
    FOREIGN KEY (idProduto)
        REFERENCES produtos (idProduto)
);
/* insert into estoque 
values
	(0,0,'2021-05-31','2021-06-22',1);
    
insert into estoque values (0,0,date(now()),null,3);
*/
-- drop procedure procurarEstoque;
delimiter ##
create procedure procurarEstoque(pesquisa varchar(255))	
begin
	select
		e.idEstoque,
        case 
			when vendido = 0 then 'não vendido'
            when vendido = 1 then 'vendido'
		end as 'status',
        e.entrada,
        e.saida,
		p.idProduto,
        p.nomeProduto,
        p.preco,
        p.estoqueMinimo,
        c.categoria,
        f.fornecedor
    from 
		estoque as e
    inner join 
		produtos as p on e.idProduto = p.idProduto
	inner join 
		categorias as c on c.idCategoria = p.idCategoria
    inner join
		fornecedores as f on f.idFornecedor = p.idFornecedor    
    where 
		if(pesquisa = null, null,
		p.nomeProduto like concat('%',pesquisa,'%')        
		or   
		e.idEstoque like pesquisa
		or   
		p.idProduto like pesquisa);
end;##
-- call procurarEstoque('');

-- selecionar as primeiras instancias de um produto que ainda não tenha sendo vendido
-- select * from estoque where idproduto = 1 and vendido = 0 limit 3;

-- drop procedure registrarSaida;
delimiter ##
create procedure registrarSaida(id int)
begin
	update
		estoque
	set
		saida = curdate()
	where idEstoque = id;
end;##
delimiter ;
-- call registrarSaida(1);

delimiter ##
create procedure registrarEntrada(idProd int, qtde int)
begin
    declare i int default 0;
	lEntradas: LOOP
    SET i = i + 1;
    insert into estoque(idProduto) values
    (idProd);
    IF i < qtde THEN
      ITERATE lEntradas;
    END IF;
    LEAVE lEntradas;
	END LOOP lEntradas;
end;##
delimiter ;
-- call registrarEntrada(3,2);
-- ----------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE clientes(
    idCliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(255) NOT NULL,
    documento VARCHAR(100) NOT NULL UNIQUE,
    endereco VARCHAR(255),
    cep VARCHAR(20),
    tel VARCHAR(50),
    contato VARCHAR(50),
    telComercial VARCHAR(50),
    contatoComercial VARCHAR(50),
    email VARCHAR(255) NOT NULL UNIQUE,
    idVendedor INT,
    banco VARCHAR(255),
    FOREIGN KEY (idVendedor)
        REFERENCES funcionarios (idFuncionario)
);
insert into 
	clientes(nome,documento,endereco,cep,tel,contato,telComercial,contatoComercial,email,idVendedor,banco)
values
	(@nome,@documento,@endereco,@cep,@tel,@contato,@telComercial,@contatoComercial,@email,@idVendedor,@banco);


CREATE TABLE ordens (
    idOrdem INT PRIMARY KEY AUTO_INCREMENT,
    descricao VARCHAR(255),
    dataEmisao DATE default (curdate()),
    idCliente INT,
    idFuncionario INT not null,
    FOREIGN KEY (idCliente)
        REFERENCES clientes (idCliente),
    FOREIGN KEY (idFuncionario)
        REFERENCES funcionarios (idFuncionario)
);
CREATE TABLE itemsDasOrdens (
    idEstoque INT not null,
    idOrdem INT not null,
    FOREIGN KEY (idEstoque)
        REFERENCES estoque (idEstoque),
    FOREIGN KEY (idOrdem)
        REFERENCES ordens (idOrdem)
);


update estoque set vendido = 0 where idEstoque in (select idEstoque from itemsdasordens where idOrdem = 3);
delete from itemsdasordens where idOrdem = 3;
delete from ordens where idOrdem = 3;

select * from itemsdasordens;
select * from estoque;

insert into ordens (idOrdem,descricao,idCliente,idFuncionario)
	values (3,'Primeira Ordem de Teste',1,5);
call adicionarItemAOrdem(2);


delimiter ##
create procedure adicionarItemAOrdem(idDaOrdem int,idDoProduto int)
begin
	declare idDoEstoque int;
    set idDoEstoque =
		(select idEstoque 
		from estoque
		where vendido = 0 and idProduto = idDoProduto
		limit 1
		);
	insert into 
		itemsdasordens (idEstoque,idOrdem)
	values 
		(idDoEstoque,idDaOrdem);
	update estoque set vendido = 1 where idEstoque = idDoEstoque;
end;##
delimiter ;

-- call adicionarItemAOrdem(2,2);

select* from estoque;
select * from itemsdasordens;

select
	p.idProduto as 'ID',
    p.nomeProduto as 'Produto',
    p.preco as 'Preço',
    Count(*) as 'Qtde'
from produtos as p
inner join estoque as e
	on p.idProduto = e.idProduto
inner join itemsdasordens as i
	on e.idEstoque = i.idEstoque 
    where i.idOrdem = 1
group by p.idProduto;

select 
	sum(p.preco)
from produtos as p
inner join estoque as e
	on p.idProduto = e.idProduto
inner join itemsdasordens as i
	on i.idEstoque = e.idEstoque
where i.idOrdem = 1;
-- ----------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tiposDePagamento (
    idPagamento INT PRIMARY KEY AUTO_INCREMENT,
    tipoDePagamento VARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE fitas (
    idFita INT PRIMARY KEY AUTO_INCREMENT,
    fita VARCHAR(100) NOT NULL UNIQUE
);
insert into fitas 
values
	(0,'Cupon fiscal'),
	(0,'Nota fiscal eletronica'),
	(0,'Tic');
CREATE TABLE notas (
    idNota INT PRIMARY KEY AUTO_INCREMENT,
    descricao VARCHAR(255),
    dataEmisao DATE default (curdate()),
    idCliente INT NOT NULL,
    idVendedor INT NOT NULL,
    idPagamento INT NOT NULL,
    idFita INT NOT NULL DEFAULT 1,
    FOREIGN KEY (idPagamento)
        REFERENCES tiposDePagamento (idPagamento),
    FOREIGN KEY (idCliente)
        REFERENCES clientes (idCliente),
    FOREIGN KEY (idVendedor)
        REFERENCES funcionarios (idVendedor),
    FOREIGN KEY (idFita)
        REFERENCES fitas (idFita)
);
CREATE TABLE itemsDasNotas (
    idEstoque INT not null,
    idNota INT not null,
    FOREIGN KEY (idEstoque)
        REFERENCES estoque (idEstoque),
    FOREIGN KEY (idNota)
        REFERENCES notas (idNota)
);
CREATE TABLE tiposDeMovimento (
    idTipoDeMovimento INT PRIMARY KEY AUTO_INCREMENT,
    tipoDeMovimento VARCHAR(100) not null unique
);
insert into tiposdemovimento
values
(0,'Pagamento'),
(0,'Recebimento'),
(0,'Est. Cred'),
(0,'Est. Debt');
CREATE TABLE movimentoDoCaixa (
    idMovimento INT PRIMARY KEY AUTO_INCREMENT,
    dataMovimento date default (curdate()),
    idTipoDeMovimento INT default 1,
    descricao VARCHAR(255),
    valor DECIMAL(32 , 2 ),
    idNota int,
    FOREIGN KEY (idTipoDeMovimento)
        REFERENCES tiposDeMovimento (idTipoDeMovimento),
	foreign key (idNota)
		references notas(idNota)
);
CREATE TABLE fechamentoCaixa (
    dataFechamento DATE PRIMARY KEY default (curdate()),
    valorFechamento DECIMAL(32 , 2 ),
    valorContado DECIMAL(32 , 2 ),
    idFuncionario INT not null,
    FOREIGN KEY (idFuncionario)
        REFERENCES funcionarios (idFuncionario)
);