# Nodejs Challenge

A aplicação sera uma api que armazenara informações a respeito dos usuários dos github

### Protótipo da aplicação

- [x] A sua Api irá fornecer dados para o protótipo disponibilizado no link https: //

### Requisitos não funcionais

- [x] A aplicação deverá ser feita em utilizando express com o (sequelize) ou adonisjs.
- [x] Os métodos get, post, put, devem ser coerentes com os retornos necessários definidos no protótipo. Ex: na tela de repositórios é necessário retornar um objeto {
      data: (array de repositório com suas respectivas stars),
      count: quantidade de itens retornados.
      }

### Requisitos funcionais

- [x] CRUD de users (nome, email, localização, avatar, username, bio). Um usuário deve ser único
- [x] O método de autenticação devera buscar se o usuário esta cadastrado na tabela users, se sim retornar os dados com sucesso, e armazenar o id do usuário e a data da requisição em uma tabela chamada Tokens.
- [x] CRUD de follower (todo follower deve ser um usuário, criar a relação pertinente para follower e user).
- [x] CRUD de following (todo following deve ser um usuário, criar a relação pertinente para following e user).
- [x] CRUD de repositories (nome, description, public, slug). A propriedade slug deve ser concatenada com o nome de usuário e o nome do repositório.
- [x] CRUD de repositories stars (Esse crud devera manter a relação de usuários que deram stars para um repositório, criar relação pertinente entre users, repositories).
- [ ] Gostaríamos de ver os campos necessários para os endpoints fossem validados na request, opcional.
