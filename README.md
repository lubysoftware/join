# Nodejs Challenge

A aplicação sera uma api que armazenara informações a respeito dos usuários dos github

### Observações
1. Provas duplicadas teram ambos os candidatos desclassificados
2. Ao finalizar a prova, o candidato deverá seguir as instruções do e-mail recebido!
3. Em caso de dúvidas, enviar e-mail para labluby@luby.com.br
4. A integração com a API externa, estão descritas nos **Requisitos Funcionais** da prova
5. Os **Requisitos não funcionais** marcados com **(OPCIONAL)** poderá ser desenvolvido de acordo com a vontade do candidato

### Protótipo da aplicação

- [x] A sua Api irá fornecer dados para o protótipo disponibilizado no [link](https://xd.adobe.com/view/1798f30c-7746-444c-bffa-91b29835eef5-42cb/ 'Protótipo')

### Requisitos não funcionais

- [ ] **RNF01 -** A aplicação deverá ser feita em utilizando express com o (sequelize) ou adonisjs.
- [ ] **RNF02 -** Os métodos get, post, put, devem ser coerentes com os retornos necessários definidos no protótipo. Ex: na tela de repositórios é necessário retornar um objeto {
      data: (array de repositório com suas respectivas stars),
      count: quantidade de itens retornados.
      }

### Requisitos funcionais

- [ ] **RF01 -** CRUD de users (nome, email, localização, avatar, username, bio). Um usuário deve ser único
- [ ] **RF02 -** O método de autenticação devera buscar se o usuário esta cadastrado na tabela users, se sim retornar os dados com sucesso, e armazenar o id do usuário e a data da requisição em uma tabela chamada Tokens.
- [ ] **RF03 -** CRUD de follower (todo follower deve ser um usuário, criar a relação pertinente para follower e user).
- [ ] **RF04 -** CRUD de following (todo following deve ser um usuário, criar a relação pertinente para following e user).
- [ ] **RF05 -** CRUD de repositories (nome, description, public, slug). A propriedade slug deve ser concatenada com o nome de usuário e o nome do repositório.
- [ ] **RF06 -** CRUD de repositories stars (Esse crud devera manter a relação de usuários que deram stars para um repositório, criar relação pertinente entre users, repositories).
- [ ] **RF07 -** Gostaríamos de ver os campos necessários para os endpoints fossem validados na request, opcional.
