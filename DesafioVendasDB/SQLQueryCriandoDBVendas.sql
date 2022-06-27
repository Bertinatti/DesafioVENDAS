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