
----2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.

--		SELECT p.Nome, e.NomeEvento
--		FROM pessoa as p
--		inner join evento e on p.pessoaid = e.pessoaid;

----2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.

--		select *
--		from pessoa
--		where nome like  '%Doe';

----2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.

--		insert into Evento(eventoid, nomeEvento,pessoaid)
--		values
--		(5,'EVENTO E',5);

----2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'

--		UPDATE EVENTO 
--	    SET PessoaId = 1
--		where eventoid = 4

----2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.

--		Delete from evento 
--		where eventoid = 2;

----2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.

--		delete pessoa
--		from pessoa p left join evento e 
--		on p.PessoaId = e.PessoaId
--		where  e.NomeEvento is null;

----2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)

--		alter table pessoa
--		add idade int	

----2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:\

--		--id: int (PK)
--		--telefone: varchar(200)
--		--pessoa_id: int(FK)

--		create table tabela_telefone(
--		id int primary key,
--		telefone varchar(200),
--		PessoaId int foreign key references Pessoa(pessoaid)


----2.9 Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.

 
--		--CREATE UNIQUE INDEX idx_telefone ON tabela_telefone(telefone);


----2.10 Crie uma query para remover a 'tabela_telefone'.
	
--		--Excluindo chave estrangeira para poder excluir a tabela
--		alter table tabela_telefone
--		drop constraint  pessoaid;
--		go

--		--Excluindo a tabela
--		drop table tabela_telefone