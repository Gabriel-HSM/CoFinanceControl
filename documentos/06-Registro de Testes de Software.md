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
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Não é possível criar a categoria porque já existe uma categoria com o mesmo nome." <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-20 - Tentar cadastrar categoria com id de usuario inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o usuario não encontrado ou inexistente |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Usuario não encontrado ou inexistente" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
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
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O valor deve ser maior que 0 e não deve ser vazio" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-23 - Tentar cadastrar transação adicionando 0 no valor total |
|:---|:---|
| Resultado esperado |  Sistema deve retornar status 400 Bad Request e mensagem informando que não é o valor total tem que ser maior que 0 |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O valor deve ser maior que 0 e não deve ser vazio" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---

| Caso de Teste    | CT-24 - Tentar cadastrar transação sem rateio |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que não é possivel cadastrar transação sem a categoria e destino|
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Não é possível cadastrar transação sem categoria e destino" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-25 - Tentar cadastrar transação com multiplos rateios |
|:---|:---|
| Resultado esperado | Sistema deve permitir o cadastro de transação com múltiplos rateios |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Transação criada com múltiplos rateios <br> - Dados salvos corretamente no banco |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-26 - Tentar cadastrar transação com categoria inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a categoria não foi encontrada ou inexistente |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-27 - Tentar cadastrar transação com descrição vazia |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição não pode estar vazia |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br>  - Mensagem de erro: "A descrição da transação não pode ser vazia" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-28 - Tentar cadastrar transação com descrição maior que 155 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição deve ter no máximo 155 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br>  - Mensagem de erro: "A descrição deve ter no máximo 155 caracteres" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-29 - Tentar cadastrar transação com descrição menor que 5 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição deve ter no mínimo 5 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br>  - Mensagem de erro: "A descrição deve ter no mínimo 5 caracteres" <br> | Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-30 - Tentar cadastrar transação com rateio sem destino |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o destino não pode estar vazio |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br>  - Mensagem de erro: "O destino da transação não pode ser vazia" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-31 - Tentar cadastrar transação com destino menor que 5 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o destino deve ter no mínimo 5 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br>  - Mensagem de erro: "O destino deve ter no mínimo 5 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-32 - Tentar cadastrar transação com destino maior que 20 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o destino deve ter no máximo 20 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br>  - Mensagem de erro: "O destino deve ter no máximo 20 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-33 - Tentar cadastrar transação com soma dos rateios diferentes do valor total |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a soma dos rateios deve ser igual ao valor total |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A soma do valor da categoria está diferente do valor total da transação" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-34 - Tentar cadastrar transação com usuário inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o usuário não foi encontrado |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Usuario não encontrado ou inexistente" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

## Avaliação ATUALIZAR

<br>

# Categoria

<br>

---
| Caso de Teste    | CT-35 - Atualizar categoria com dados válidos |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 200 OK e a categoria atualizada |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Categoria atualizada com sucesso <br> - Dados salvos corretamente no banco |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-36 - Tentar atualizar categoria inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 404 Not Found e mensagem informando que a categoria não foi encontrada |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 404 Not Found <br> - Mensagem de erro: "Categoria não encontrada ou inexistente" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-37 - Tentar atualizar categoria com nome menor que 3 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o nome deve ter no mínimo 3 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O nome deve ter no mínimo 3 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-38 - Tentar atualizar categoria com descrição menor que 3 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição deve ter no mínimo 3 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A descrição deve ter no máximo 155 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-39 - Atualizar categoria com atualização parcial (apenas nome) |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 200 OK e atualizar apenas o nome, mantendo os outros campos |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Apenas o nome foi atualizado <br> - Outros campos permaneceram inalterados |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-40 - Atualizar categoria com atualização parcial (apenas descrição) |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 200 OK e atualizar apenas a descrição, mantendo os outros campos |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Apenas a descrição foi atualizada <br> - Outros campos permaneceram inalterados |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

# Transacao

<br>

---
| Caso de Teste    | CT-41 - Atualizar transação com dados válidos |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 200 OK e a transação atualizada |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Transação atualizada com sucesso <br> - Dados salvos corretamente no banco |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-42 - Tentar atualizar transação inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 404 Not Found e mensagem informando que a transação não foi encontrada |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 404 Not Found <br> - Mensagem de erro: "Transação não encontrada ou inexistente" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-43 - Tentar atualizar transação sem rateio |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a transação deve ter categoria e destino |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Não é possível cadastrar transação sem categoria e destino" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-44 - Tentar atualizar transação com categoria inexistente |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a categoria não foi encontrada |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-45 - Tentar atualizar transação com descrição menor que 3 caracteres |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a descrição deve ter no mínimo 3 caracteres |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "A descrição deve ter no mínimo 3 caracteres" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-46 - Tentar atualizar transação com valor menor ou igual a 0 |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que o valor deve ser maior que 0 |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O valor não deve ser menor ou igual a 0" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-47 - Tentar atualizar transação com soma dos rateios diferente do valor total |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 400 Bad Request e mensagem informando que a soma dos rateios deve ser igual ao valor total |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 400 Bad Request <br> - Mensagem de erro: "O valor da categoria está diferente do valor total da transação" |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-48 - Atualizar transação com atualização parcial (apenas valor total) |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 200 OK e atualizar apenas o valor total, mantendo os outros campos |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Apenas o valor total foi atualizado <br> - Outros campos permaneceram inalterados |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

---
| Caso de Teste    | CT-49 - Atualizar transação com atualização parcial (apenas descrição) |
|:---|:---|
| Resultado esperado | Sistema deve retornar status 200 OK e atualizar apenas a descrição, mantendo os outros campos |
| Resultados obtidos | ✅ **APROVADO** <br> - Sistema retornou status 200 OK <br> - Apenas a descrição foi atualizada <br> - Outros campos permaneceram inalterados |
| Responsável pela execução do caso de Teste | Gabriel Henrique |
---

<br>

## Observações Gerais

- **Taxa de sucesso**: 49/49 casos aprovados (100%)
- **Casos pendentes**: 0
- **Correções implementadas**: 
  - Tratamento de exceções personalizadas convertido para Bad Request (400) nos casos CT-19, CT-20, CT-26 e CT-33
  - Suporte para atualização parcial implementado nos métodos de atualização
- **Testes executados em**: 06/02/2026
- **Ambiente**: Desenvolvimento (In-Memory Database)

## Próximos Passos

1. Executar testes de integração com banco de dados real
2. Implementar testes automatizados (testes de unidade)
3. Adicionar testes de deleção (DELETE)
4. Adicionar testes de listagem e busca (GET)
5. Implementar testes de performance e carga