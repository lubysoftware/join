
# AutoLuby

### Descrição da prova:

1. Esta prova consiste na criação de um sistema para gerenciamento de uma loja que realiza venda de veículos.
2. Todos os campos que não estão marcados com (OPCIONAL) são obrigatórios.
3. As colunas que descrevemos para os cruds poderão ser modificadas, de acordo com o que o desenvolvedor acredita ser a melhor forma de codificação. A criação de colunas e tabelas, poderão ser incluídas também, de acordo com o que o desenvolvedor sentir a necessidade.

### **REQUISITOS FUNCIONAIS**

##### **RF01 -** CRUD de funcionários

- **Cadastro:**

Descrição:O usuário deve ser único, os campos podem ser descritos como: cpf, nome, email, avatar, biografia, senha.

- **Edição:**

Descrição: Deve ser possível editar um usuário.

- **Listagem:**

Descrição: Deve ser possível listar todos os funcionários (Gostaríamos de ver paginado, porém, é opcional)

- **Visualizar:**

Descrição: Deve ser possível visualizar um único funcionário e as vendas/reservas de veículos deste.

- **Remoção:**

Descrição: Deve ser possível remover um funcionário.

##### RF02 - Perfil de acesso (OPCIONAL)

Descrição: sinta-se à vontade para realizar essa tarefa e use sua criatividade, você poderá utilizar perfis de acesso e atribuir funções para tipos de funcionários (administrador, vendedor).

##### RF03 - Autenticação

Descrição: deve ser possível fazer a autenticação no sistema e dividir as rotas públicas das privadas

##### RF04 - Crud de Veículo

- **Adquirir veículo:**

Descrição: o proprietário poderá adquirir veículos para sua loja. O veículo deve ser único, os campos podem ser descritos como: marca, modelo, ano, km, cor, chassi e preço de compra.

- **Listar veículo:**

Descrição: Listagem de todos veículos.

- **Mostrar veículo:**

Descrição: Listagem de um único veículo.

- **Remover veículo:**

Descrição: Deve ser possível remover um veículo.

##### RF05 - Filtrar veículos pelo status (OPCIONAL)

Descrição: você pode filtrar veículos vendidos ou disponíveis

##### RF06 - Vender veículo

Descrição: ao realizar esta ação, informações como: data, status do veículo, valor da venda e quem vendeu

##### RF07 - Reservar veículo

Descrição: ao realizar esta ação, informações como: data, valor da reserva, quem vendeu.

##### RF08 - Formatar todas as datas apresentadas ao usuário (OPCIONAL)

Descrição: todas as datas deverão estar no formato DD/MM/yyyy

#### REQUISITOS NÃO FUNCIONAIS

**RNF01 - A aplicação deverá ser feita utilizando Express com o (Sequelize) ou AdonisJs.**

**RNF02 - Utilização de Migrations**

**RNF03 - Utilização de Models**

**RNF04 - Gostaríamos de ver a utilização de typescript (OPCIONAL)**

**RNF05 - Gostaríamos que os campos necessários para os endpoints fossem validados na requisição. (OPCIONAL)**
