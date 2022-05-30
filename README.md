# ReactJS Challenge

A aplicação sera uma PWA que funcionará em cima da api do gitluby, onde deve existir uma tela de login que o usuário digitará o nickname de um usuário do github, ao buscar esse usuário, ele deve ser redirecionado para uma tela interna onde estará disponível informações gerais do usuário conforme o protótipo, com uma navegação de tabs para **Início**, **Repositórios**, **Seguidores**, **Seguindo**.

### Observações
1. Provas duplicadas teram ambos os candidatos desclassificados
2. Ao finalizar a prova, o candidato deverá seguir as instruções do e-mail recebido!
3. Em caso de dúvidas, enviar e-mail para labluby@luby.com.br
4. A integração com a API externa, estão descritas nos **Requisitos Funcionais** da prova
5. Os **Requisitos não funcionais** marcados com **(OPCIONAL)** poderá ser desenvolvido de acordo com a vontade do candidato

### Protótipo da aplicação

- [x] O protótipo do aplicativo está disponível no link [link](https://xd.adobe.com/view/1798f30c-7746-444c-bffa-91b29835eef5-42cb/ 'Protótipo') (tente reproduzir o layout da forma mais fiel possível)
- O layout é o mesmo da aplicação react-native.

### Requisitos não funcionais

- [ ] **RNF01 -** O aplicativo deve usar reactjs.
- [ ] **RNF02 -** Gostaríamos de ver a utilização de TypeScript **(OPCIONAL)**
- [ ] **RNF03 -** Gostaríamos que os campos de formulário validados com yup **(OPCIONAL)**
- [ ] **RNF04 -** Gostaríamos de ver você utilizando o styled-components **(OPCIONAL)**
- [ ] **RNF05 -** Você deve gerenciar suas rotas com o react-router.
- [ ] **RNF06 -** Você deve gerenciar todo o estado do aplicativo com redux ou Context Api.

### Requisitos funcionais

- [ ] **RF01 -** Você deve permitir que um usuário seja autenticado buscando pelo username do github

Rota para validação da Autenticação
```javascript
{
  method: 'post',
  url: 'https://gitluby.api.k8s.luby.me/login',
  headers: { 'Accept': 'application/json', 'Content-Type': 'application/json' },
  data: { username: "#anilton.veiga" }
}
```
---

- [ ] **RF02 -** As informações retornadas serão apresentadas na tela de perfil, como apresentado no protótipo 

---

- [ ] **RF03 -** Ao clicar no número de seguidores, deve listar todos os seguidores do perfil logado, assim como apresentado no protótipo
```javascript
{
  method: 'get',
  url: 'https://gitluby.api.k8s.luby.me/followers',
  headers: { 'Accept': 'application/json', 'Content-Type': 'application/json', 'Authorization': `Bearer + ${token_returned_login}` }
}
```
---

- [ ] **RF04 -** Ao clicar no número de seguindo, deve listar todos os usuários seguidos pelo perfil logado, assim como apresentado no protótipo
```javascript
{
  method: 'get',
  url: 'https://gitluby.api.k8s.luby.me/followings',
  headers: { 'Accept': 'application/json', 'Content-Type': 'application/json', 'Authorization': `Bearer + ${token_returned_login}` }
}
```
---

- [ ] **RF05 -** Ao clicar no número de repositórios, deve listar todos os repositórios do perfil logado, assim como apresentado no protótipo
```javascript
{
  method: 'get',
  url: 'https://gitluby.api.k8s.luby.me/repositories',
  headers: { 'Accept': 'application/json', 'Content-Type': 'application/json', 'Authorization': `Bearer + ${token_returned_login}` }
}
```
---

- [ ] **RF06 -** Na tela início, você deve ter um botão que permita o usuário sair da aplicação o redirecionando para a tela de autenticação
