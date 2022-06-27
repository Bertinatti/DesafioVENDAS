create database caboclo_db;

use caboclo_db;

create table usuario(
	id_usuario int not null identity,
	login_usuario varchar(50) not null,
	senha varchar(50) not null,
	nome_usuario varchar(250) not null,
	tipo_usuario int not null,

	primary key (id_usuario)
);

create table produto(
	id_produto int not null identity,
	codigo_barras varchar(250) not null,
	nome_produto varchar(50) not null,
	preco decimal(10,2) not null,
	estoque int not null,

	primary key (id_produto)
);

create table cliente(
	id_cliente int not null identity,
	cpf varchar(14) not null,
	nome_cliente varchar(250) not null,
	telefone varchar(14) not null,
	email varchar(250) not null,

	primary key(id_cliente)
);

create table venda(
	id_venda int not null identity,
	id_cliente int not null,
	valor_total decimal(10,2) not null,

	primary key(id_venda),
	index fk_venda_cliente_idx (id_cliente ASC),

	constraint fk_venda_cliente
		foreign key (id_cliente)
		references cliente (id_cliente)
		on delete no action
		on update no action
);

create table item_venda(
	id_item_venda int not null identity,
	id_venda int not null,
	id_produto int not null,
	valor_unitario decimal(10,2) not null,
	quantidade int not null,
	valor_total decimal(10,2) not null,

	primary key(id_item_venda),
	index fk_item_venda_venda_idx (id_venda ASC),

	constraint fk_item_venda_venda
		foreign key (id_venda)
		references venda (id_venda)
		on delete no action
		on update no action,

	constraint fk_item_venda_produto
		foreign key (id_produto)
		references produto (id_produto)
		on delete no action
		on update no action
);

use caboclo_db;

insert into cliente values('454.565.897-06','João Sérgio da Silva','(14)99632-6671','joao.silva@ufn.edu.br');
insert into cliente values('278.698.912-09','Maria Aparecida de Oliveira','(14)99680-2577','maria.oliveira@ufn.edu.br');
insert into cliente values('345.758.654-12','Leandra Martins de Paz','(14)99611-3517','leandra.paz@ufn.edu.br');

select *
from cliente;

insert into produto values('7898357410015','Laranja baiana',12.79,50);
insert into produto values('7898357410025','Abacaxi',2.50,12);
insert into produto values('7898357410035','Arroz',27.10,100);

select *
from produto;

insert into usuario values ('leonardo.bertinatti','admincaboclo','Leonardo Cardoso Bertinatti',1);
insert into usuario values ('ricardo.silva','ricardofrohlich','Ricardo Frohlich da Silva',0);

select *
from usuario;

insert into venda values(1,5.00);
insert into venda values(1,34.60);

select *
from venda;

insert into item_venda values(1,2,2.50,2,5.00);
insert into item_venda values(2,2,2.50,3,7.50);
insert into item_venda values(2,3,27.10,1,27.10);

select *
from item_venda;

select tipo_usuario from usuario where login_usuario='leonardo.bertinatti' and senha='admincaboclo';

SELECT MAX(id_venda) FROM venda;

select * from venda;

SELECT estoque FROM produto where id_produto='2';

select * from cliente;

select * from produto;

update produto set estoque=estoque+8 where id_produto=2;