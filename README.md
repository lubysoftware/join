# Loja do Aventureiro

### Descrição da prova:

Meus parabéns! Você foi encarregado de criar um sistema para a mais nova Loja de Aventureiros! Aventureiros de todas as
partes do reino vem a loja em busca de `Itens` para ajudá-los em suas jornadas. Abaixo estão as informações que você precisa
para realizar essa tarefa. Então siga em frente, a fila ja está se formando.

## Itens

A loja oferece 3 tipos de itens: `Armamentos`, `Armaduras` e `Consumíveis`. Todos eles possuem:
- Número identificador
- Nome
- Tipo
- Custo

Porém cada um dos tipos possui uma característica específica:

**Armamentos:**
- Dano

**Armaduras:**
- Durabilidade

**Consumíveis:**
- Usos


## **REQUISITOS FUNCIONAIS**

### **RF01 -** Estoque:

#### A) **Cadastro de Itens:**

Descrição: O usuário deverá poder cadastrar itens novos ao estoque.

#### B) **Remoção de Itens:**

Descrição: O usuário deverá poder remover itens ao estoque.

#### C) **Adição de unidades:**

Descrição: O usuário deverá poder adicionar unidades de itens em estoque.

#### D) **Listagem do Estoque:**

Descrição: O usuário deverá poder visualizar uma lista de todos os itens em estoque.

#### E) **Exportação do Estoque:**

Descrição: O usuário deverá poder exportar um arquivo .txt contendo uma lista de todos os itens em estoque.

### RF02 - Venda:

#### A) **Venda de Itens:**

Descrição: O usuário deverá poder realizar uma venda de uma ou mais unidades de um item em estoque.

Um valor de desconto é calculado como: 2% * Quantidade de numeros Primos entre 0 e o número de unidades sendo compradas.
```
Unidades = 10
Números primos entre 0-10 = 4 (2, 3, 5, 7)
Desconto total = 8% (4*2%)
```
Ao final da compra, deve ser exibida uma tela de confirmação mostrando o `Custo da Unidade`,  `Valor sem desconto`, o `Desconto` em G$ e 
em % e o `Valor com desconto`.

Cada venda deve gerar uma entrada no Log de vendas.

#### B) **Log de Vendas**

Descrição: O usuário deverá poder visualizar o log de vendas. O log deve mostrar:
- Número identificador da venda.
- Número identificador do item.
- Nome do Item.
- Quantidade de itens vendidos.
- Custo por Item sem desconto.
- Custo final.


#### C) **Exportação do Log de Vendas:**

Descrição: O usuário deverá poder exportar um arquivo .txt contendo um log de vendas. Esse arquivo deve 
conter as mesmas informações que podem ser visualizadas no log dentro da aplicação.

## REQUISITOS NÃO FUNCIONAIS

**RNF01 - A aplicação deverá ser feita utilizando C++.**

**RNF02 - A aplicação deve utilizar apenas o console. Não é necessário a implementação de nenhuma GUI.**



## **Atenção:**
1. **CÓPIAS DE PROVAS NÃO SERÃO PERMITIDAS!** _Os magos avaliadores são muito atentos, não disperdice essa chance!_
2. Ao finalizar a tarefa, o siga as instruções da carta(e-mail) recebido!
3. Em caso de dúvidas, envie uma carta(e-mail) para labluby@luby.com.br.