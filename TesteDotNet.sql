
/*2.1*/
select nome, evento from tabela_evento, tabela_pessoas
where tabela_pessoas.id like tabela_evento.pessoa_id;

/*2.2*/
select nome from tabela_pessoas
where nome like "%Doe";

/*2.3*/

insert into tabela_evento
(id, evento, pessoa_id)
value
(default,"Evento E",'5');

/*2.4*/

update tabela_evento
set pessoa_id = '1'
where evento = 'Evento D';

/*2.5*/

delete from tabela_evento
where evento = 'Evento B'
limit 1;

/*2.6*/

delete from tabela_pessoas
where id not in (SELECT tabela_evento.pessoa_id from tabela_evento);

/*2.7*/

alter table tabela_pessoas
add idade int;

/*2.8*/

create table tabela_telefone(
    id int,
    telefone varchar(200),
    pessoa_id int,
    foreign key (pessoa_id) references tabela_pessoas(id),
    primary key (id)
);

/*2.9*/

alter table tabela_telefone
modify telefone varchar(200) unique;

/*2.10*/

drop table tabela_telefone;

