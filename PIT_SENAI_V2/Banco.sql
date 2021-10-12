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
    ativo BIT(1) DEFAULT 1,
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
    email VARCHAR(255) UNIQUE,
    ativo bit(1) default 1
);

insert into fornecedores
values
(0,'Magalu','Luao','imoveis','(00) 1111-1111','(00) 2344-2333','magalu@mail.com'),
(0,'Redes Mar','Redesmar','Infra redes', '(22)2344-3333', null, 'redesmar@mail.com');



CREATE TABLE categorias (
    idCategoria INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(100) NOT NULL UNIQUE,
    ativo BIT(1) DEFAULT 1
);
insert into categorias (categoria)
values
('cabos'),
('redes'),
('estantes'),
('armarios');
CREATE TABLE produtos (
    idProduto INT PRIMARY KEY AUTO_INCREMENT,
    nomeProduto VARCHAR(255) NOT NULL UNIQUE,
    preco DECIMAL(32 , 2 ) DEFAULT 0,
    estoqueMinimo INT DEFAULT 0,
    idCategoria INT,
    idFornecedor int NOT NULL,
    ativo bit(1) default 1,
    FOREIGN KEY (idCategoria)
        REFERENCES categorias (idCategoria),
    FOREIGN KEY (idFornecedor)
        REFERENCES fornecedores (idFornecedor)
);

insert into produtos values
(0,'Rede 1',123.22,2,2,2),
(0,'Armario 5 portas',123.22,2,4,1),
(0,'Cabo de cobre',123.22,2,1,2);


-- drop table estoque;
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
    idVendedor INT,
    banco VARCHAR(255),
    ativo bit(1) default 1,
    FOREIGN KEY (idVendedor)
        REFERENCES funcionarios (idFuncionario)
);

create table contatosDosClientes(
	idCliente int not null,
	tipoContato varchar(100),
    contato varchar(100),
    foreign key (idCliente)
		references clientes(idCliente)
);


CREATE TABLE ordens (
    idOrdem INT PRIMARY KEY AUTO_INCREMENT,
    observacao VARCHAR(255),
    dataEmissao DATE default (curdate()),
    completa bit(1) default 0,
    idCliente INT,
    idFuncionario INT not null,
    FOREIGN KEY (idCliente)
        REFERENCES clientes (idCliente),
    FOREIGN KEY (idFuncionario)
        REFERENCES funcionarios (idFuncionario)
);
CREATE TABLE itensDasOrdens (
    idEstoque INT not null,
    idOrdem INT not null,
    FOREIGN KEY (idEstoque)
        REFERENCES estoque (idEstoque),
    FOREIGN KEY (idOrdem)
        REFERENCES ordens (idOrdem)
);

-- pesquisa baseada na data de emissão | select * from ordens where dataEmissao like ('%13%');


-- ----------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE FormasDePagamento (
    idFormaDePagamento INT PRIMARY KEY AUTO_INCREMENT,
    FormaDePagamento VARCHAR(100) NOT NULL UNIQUE,
    ativo bit(1) default 1
);
insert into 
	Formasdepagamento(FormaDePagamento)
values
	('Dinheriro'),
    ('Débito'),
    ('Crédito'),
    ('Parcelado'),
    ('Cheque');

CREATE TABLE fechamentoCaixa (
    dataFechamento date PRIMARY KEY default (curdate()),
    horaAbertura time default (time(now())),    
    idFuncionarioAbertura INT not null,
    saldoInicial decimal(32,2) not null,
    horaFechamento time,
    idFuncionarioFechamento int,
    valorFechamento DECIMAL(32 , 2),
    valorContado DECIMAL(32 , 2),
    observacao varchar(255),
    FOREIGN KEY (idFuncionarioAbertura)
        REFERENCES funcionarios (idFuncionario),
    FOREIGN KEY (idFuncionarioFechamento)
        REFERENCES funcionarios (idFuncionario)
);
CREATE TABLE notas (
    idNota INT PRIMARY KEY AUTO_INCREMENT,
    dataEmissao date default (curdate()),
    horaEmissao time default (time(now())),
    idOrdem int,
    idFormaDePagamento INT NOT NULL,
    ativo bit(1) default 1,
    foreign key (dataEmissao)
		references fechamentoCaixa(dataFechamento),
	foreign key (idOrdem)
		references ordens(idOrdem),
    FOREIGN KEY (idFormaDePagamento)
        REFERENCES FormasDePagamento (idFormaDePagamento)
);

CREATE TABLE itensDasNotas (
    idEstoque INT not null,
    idNota INT not null,
    FOREIGN KEY (idEstoque)
        REFERENCES estoque (idEstoque),
    FOREIGN KEY (idNota)
        REFERENCES notas (idNota)
);

create table tiposDeMovimento(
	idTipoDeMovimento int primary key auto_increment,
    tipoDeMovimento varchar(255),
    ativo bit(1) default 1
);

insert into
	tiposDeMovimento(tipoDeMovimento)
values
	('Recebimento'),
	('Pagamento'),
	('Est. Debt'),
	('Est. Cred');

CREATE TABLE movimentoDoCaixa (
    idMovimento INT PRIMARY KEY AUTO_INCREMENT,
    dataMovimento date default (curdate()),
    horaMovimento time default (time(now())),
    idTipoDeMovimento int,
    observacao VARCHAR(255),
    valor DECIMAL(32 , 2 ) ,
    idNota int,
    idMovEst int,
    idFuncionario int,
    foreign key (dataMovimento)
		references fechamentoCaixa(dataFechamento),
	foreign key (idNota)
		references notas(idNota),
	foreign key (idMovEst)
		references movimentodocaixa(idMovimento),
	foreign key (idFuncionario)
		references funcionarios(idFuncionario),
	foreign key (idTipoDeMovimento)
		references tiposDeMovimento(idTipoDeMovimento)
);
/*
+recebimento
-pagamento
+est.debt
-est.cred
-sangria
*/