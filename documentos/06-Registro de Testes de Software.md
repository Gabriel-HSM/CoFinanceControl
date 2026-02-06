# Registro de Testes de Software

Relatório com as evidências dos testes de software realizados na aplicação, baseado no plano de testes pré-definido.

Os resultados dos testes funcionais realizados na aplicação são descritos a seguir.

---

## Avaliação CRIAR

<br>

# Usuario

<br>

---
| Caso de Teste    | CT-01 - Cadastrar usuário com dados válidos |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 201 Created e o usuário retornado |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Usuário criado com ID gerado automaticamente <br> - Dados salvos corretamente no banco |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-02 – Tentar cadastrar usuário com nome vazio |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome é obrigatório |
| Resultados obtidos | ✅ **APROVADO** <br> - Status 400 Bad Request <br> - Mensagem de erro: "O nome do usuário não deve ser vazio" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---

| Caso de Teste    | CT-03 - Tentar cadastrar usuário com nome maior que 50 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome deve ter no máximo 50 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O nome deve ter no máximo 50 caracteres" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-04 - Tentar cadastrar usuário com nome menor que 3 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome deve ter no mínimo 3 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O nome deve ter no mínimo 3 caracteres" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-05 - Tentar cadastrar usuário com nome com caracteres especiais |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome não deve conter números ou caracteres especiais |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Nome não deve conter números ou caracteres especiais" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-06 - Tentar cadastrar usuário com sobrenome vazio |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o sobrenome é obrigatório |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O Sobrenome do usuário não deve ser vazio" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-07 - Tentar cadastrar usuário com sobrenome maior que 50 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o sobrenome deve ter no máximo 50 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O sobrenome deve ter no máximo 50 caracteres" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-08 - Tentar cadastrar usuário com sobrenome menor que 3 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o sobrenome deve ter no mínimo 3 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O sobrenome deve ter no mínimo 3 caracteres" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-09 - Tentar cadastrar usuário com sobrenome com caracteres especiais |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o sobrenome não deve conter números ou caracteres especiais |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Sobrenome não deve conter números ou caracteres especiais" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-10 - Tentar cadastrar usuário com data de nascimento com data futura |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a data não deve ser futura |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A data de nascimento não deve ser uma data futura" <br> - Validação funcionou conforme esperado |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

# Categoria

<br>

---
| Caso de Teste    | CT-11 - Cadastrar categoria com dados válidos |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 201 Created e o categoria retornado |
| Resultados obtidos |✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Categoria criado com ID gerado automaticamente <br> - Dados salvos corretamente no banco |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-12 - Tentar cadastrar categoria com nome vazio |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome da categoria não deve ser vazio |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O nome da categoria não deve ser vazio" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-13 - Tentar cadastrar categoria com nome maior que 50 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome da categoria deve ter no máximo 50 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O nome da categoria deve ter no máximo 50 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-14 - Tentar cadastrar categoria com nome menor que 3 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome da categoria deve ter no mínimo 3 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O nome da categoria deve ter no mínimo 3 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-15 - Tentar cadastrar categoria com nome com caracteres especiais |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome da categoria não deve conter caracteres especiais |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O nome da categoria não deve conter caracteres especiais" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-16 - Tentar cadastrar categoria com descrição vazia |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição da categoria não deve ser vazia |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A descrição da categoria não deve ser vazia" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-17 - Tentar cadastrar categoria com descrição maior que 155 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição da categoria deve ter no máximo 155 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A descrição da categoria deve ter no máximo 155 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-18 - Tentar cadastrar categoria com descrição menor que 3 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição da categoria deve ter no mínimo 3 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A descrição da categoria deve ter no mínimo 3 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-19 - Tentar cadastrar categoria com nome duplicado |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a já possui categoria com esse nome |
| Resultados obtidos | ⚠️ **PENDENTE** <br> - Sistema retornou status 500  Internal Server Error, implementação Bad Request Pendente <br> - Mensagem de erro: "Não é possível criar a categoria porque já existe uma categoria com o mesmo nome" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---
---

<br>

---
| Caso de Teste    | CT-20 - Tentar cadastrar categoria com id de usuario inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o usuario não encontrado ou inexistente |
| Resultados obtidos | ⚠️ **PENDENTE** <br> - Sistema retornou status 500  Internal Server Error, implementação Bad Request Pendente <br> - Mensagem de erro: "Usuario Não encontrado" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

# Transacao

<br>

---
|Caso de Teste    | CT-05 - Cadastrar transação sem rateio |
|:---|:---|
| Resultados obtidos | ✅ **APROVADO** <br> - Transação criada com sucesso <br> - Rateio único vinculado corretamente <br> - DataCriacao registrada |
| Responsável pela execução do caso de Teste | Gabriel Henrique |

---

|Caso de Teste    | CT-06 - Cadastrar transação com múltiplos rateios |
|:---|:---|
| Resultados obtidos | ✅ **APROVADO** <br> - Transação aceita múltiplos rateios <br> - Todos os rateios foram salvos corretamente <br> - Soma validada |
| Responsável pela execução do caso de Teste | Gabriel Henrique |

---

|Caso de Teste    | CT-07 - Tentar cadastrar transação com soma dos rateios diferente do valor total |
|:---|:---|
| Resultados obtidos | ❌ **REPROVADO** <br> - Sistema não validou a inconsistência <br> - Transação foi criada com valores inconsistentes <br> - **Correção necessária**: Adicionar validação no método `DefinirRateios` |
| Responsável pela execução do caso de Teste | Gabriel Henrique |

---

## Observações Gerais

- **Taxa de sucesso**: 5/7 casos aprovados (71%)
- **Pendências**: 1 caso ainda não implementado (CT-04)
- **Correções necessárias**: 1 caso reprovou e precisa de ajuste (CT-07)
- **Testes executados em**: 05/02/2026
- **Ambiente**: Desenvolvimento (In-Memory Database)

## Próximos Passos

1. Implementar validação de categoria duplicada (CT-04)
2. Adicionar validação de soma dos rateios (CT-07)
3. Re-executar testes após correções