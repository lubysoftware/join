# Loja do Aventureiro

### Descrição da prova:

Meus parabéns! Agora você está no Desafio Técnico do LabLuby Games! 

Você será responsável por criar um sistema para a mais nova Loja de Aventureiros! Aventureiros de todas as partes do reino vem a 
loja em busca de `Itens` para ajudá-los em suas jornadas. Abaixo estão as informações que você precisa para realizar essa tarefa. 
Algumas coisas são opcionais e vão estar marcadas com _**(Opcional)***_, mas todas as outras são obrigatórias. 

Então, o que está esperando! Siga em frente, a fila ja está se formando!

_Ahh mais uma coisa! Aqui nós não usamos esse papel como dinheiro. O que manda aqui é são as Peças de Ouro, 
então use PO ao invés de R$!_

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

#### F) **Importação do Estoque:** _**(Opcional)***_

Descrição: O usuário deverá poder importar um arquivo .txt contendo uma lista de todos os itens em estoque e
aplicar ao estoque.

### RF02 - Venda:

#### A) **Venda de Itens:**

Descrição: O usuário deverá poder realizar uma venda de uma ou mais unidades de um item em estoque.

Um valor de desconto é calculado como: 2% * Quantidade de numeros Primos entre 0 e o número de unidades sendo compradas.
```
Unidades = 10
Números primos entre 0-10 = 4 (2, 3, 5, 7)
Desconto total = 8% (4*2%)
```
Ao final da compra, deve ser exibida uma tela de confirmação mostrando o `Custo da Unidade`,  `Valor sem desconto`, o `Desconto` em PO e 
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

**RNF03 - Utilize o padrão de Orientação a Objetos.**

**RNF04 - Cries classes para os diferentes tipos de itens.**

**RNF05 - A aplicação deverá iniciar com um item de cada tipo já em estoque.**

## Observações
Antes de ir para a loja, os magos avaliadores irão análisar sua tarefa. Eles dão bastante importância para algumas coisas:  
- Organização do código
- Documentação
- Performance
- Escalabilidade
- Lixo de memória ⇦ _Esse aqui especialmente_

## **Atenção:**
1. **CÓPIAS DE PROVAS NÃO SERÃO PERMITIDAS!** _(Os magos são muito atentos, não desperdice essa chance!)_
2. Assim que terminar esse Desafio Técnico, siga os seguintes passos: 
- Suba o projeto para um repositório privado em sua conta pessoal do Github;
- Adicione o e-mail labluby@luby.com.br como colaborador;
- Retorne o e-mail que te enviamos anteriormente, respondendo com o link do seu repositório.
3. Em caso de dúvidas, envie um e-mail para labluby@luby.com.br.
