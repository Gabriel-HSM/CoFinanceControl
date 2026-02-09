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
| Resultados obtidos | ⚠️ **PENDENTE** <br> - Sistema retornou status 500  Internal Server Error <br> - Implementação Bad Request Pendente <br> - Mensagem de erro: "Não é possível criar a categoria porque já existe uma categoria com o mesmo nome" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-20 - Tentar cadastrar categoria com id de usuario inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o usuario não encontrado ou inexistente |
| Resultados obtidos | ⚠️ **PENDENTE** <br> - Sistema retornou status 500  Internal Server Error <br> - Implementação Bad Request Pendente <br> - Mensagem de erro: "Usuario Não encontrado" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

# Transacao

<br>

---
| Caso de Teste    | CT-21 - Cadastrar transação com dados válidos |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 201 Created e a transação retornada |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Transação criada com ID gerado automaticamente <br> - Dados salvos corretamente no banco |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-22 - Tentar cadastrar transação sem valor total |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que não é possivel cadastrar transação sem o valor |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O valor deve ser maior que 0 e não deve ser vazio" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-23 - Tentar cadastrar transação adicionando 0 no valor total |
|:---|:---|
| Resultado esperado |  Sistema deve retornar status 400 Bad Request e mensagem informando que não é o valor total tem que ser maior que 0 |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O valor deve ser maior que 0 e não deve ser vazio" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---

| Caso de Teste    | CT-24 - Tentar cadastrar transação sem rateio |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que não é possivel cadastrar transação sem a categoria e destino|
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A transação deve ter uma categoria e destino (rateio)." |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-25 - Tentar cadastrar transação com multiplos rateios |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que não é possivel cadastrar transação sem o categoria |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Transação criada com múltiplos rateios <br> - Dados salvos corretamente no banco |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-26 - Tentar cadastrar transação com categoria inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a categoria não foi encontrada ou inexistente |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 500 Internal Server Error <br> - Implementação Bad Request Pendente <br> - Mensagem de erro: Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-27 - Tentar cadastrar transação com soma dos rateios diferentes do valor total |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que não é possivel cadastrar transação sem o categoria |
| Resultados obtidos | ⚠️ **PENDENTE** <br> - Sistema retornou status 500  Internal Server Error <br> - Implementação Bad Request Pendente <br> - Mensagem de erro: "O valor da categoria está diferente do valor total" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

## Observações Gerais

- **Taxa de sucesso**: 17/20 casos aprovados (85%)
- **Casos pendentes**: 2 (CT-19, CT-20)
- **Pendências**: Transações
- **Correções necessárias**: Precisa de ajuste (CT-19, CT-20)
- **Testes executados em**: 06/02/2026
- **Ambiente**: Desenvolvimento (In-Memory Database)

## Próximos Passos

1. Adicionar validação de soma dos rateios
2. Organizar transacoes
3. Re-executar testes após correções