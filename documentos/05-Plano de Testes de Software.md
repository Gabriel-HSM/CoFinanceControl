# Plano de Testes de Software

Os testes funcionais a serem realizados na aplicação são descritos a seguir.
 
| **Caso de Teste** 	| **CT-01 – Cadastrar usuário com dados válidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema permite o cadastro de um novo usuário com dados válidos. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher os campos obrigatórios (nome, sobrenome, email, senha, data de nascimento) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O sistema deve retornar status 201 Created <br> - O usuário deve ser criado com sucesso <br> - Um ID deve ser gerado automaticamente. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-02 – Tentar cadastrar usuário com nome vazio** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida o campo nome e impede o cadastro sem nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Deixar o campo nome vazio <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome do usuário não deve ser vazio". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-03 – Tentar cadastrar usuário com nome maior que 50 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho máximo do campo nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher o campo nome com mais de 50 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome deve ter no máximo 50 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-04 – Tentar cadastrar usuário com nome menor que 3 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo do campo nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher o campo nome com menos de 3 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome deve ter no mínimo 3 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-05 – Tentar cadastrar usuário com nome com caracteres especiais** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida caracteres especiais no campo nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher o campo nome com caracteres especiais ou números <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Nome não deve conter números ou caracteres especiais". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-06 – Tentar cadastrar usuário com sobrenome vazio** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida o campo sobrenome e impede o cadastro sem sobrenome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Deixar o campo sobrenome vazio <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O Sobrenome do usuário não deve ser vazio". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-07 – Tentar cadastrar usuário com sobrenome maior que 50 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho máximo do campo sobrenome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher o campo sobrenome com mais de 50 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O sobrenome deve ter no máximo 50 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-08 – Tentar cadastrar usuário com sobrenome menor que 3 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo do campo sobrenome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher o campo sobrenome com menos de 3 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O sobrenome deve ter no mínimo 3 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-09 – Tentar cadastrar usuário com sobrenome com caracteres especiais** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida caracteres especiais no campo sobrenome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher o campo sobrenome com caracteres especiais ou números <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Sobrenome não deve conter números ou caracteres especiais". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-10 – Tentar cadastrar usuário com data de nascimento futura** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida datas futuras no campo data de nascimento. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de usuários <br> - Preencher o campo data de nascimento com uma data futura <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A data de nascimento não deve ser uma data futura". |
|  	|  	|

<br>

## Testes de Categoria

| **Caso de Teste** 	| **CT-11 – Cadastrar categoria com dados válidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema permite o cadastro de uma nova categoria com dados válidos. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Preencher os campos obrigatórios (nome, descrição) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - A categoria deve ser criada com sucesso <br> - Um ID deve ser gerado automaticamente. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-12 – Tentar cadastrar categoria com nome vazio** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o campo nome e impede o cadastro sem nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Deixar o campo nome vazio <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome da categoria não deve ser vazio". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-13 – Tentar cadastrar categoria com nome maior que 50 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho máximo do campo nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Preencher o campo nome com mais de 50 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome da categoria deve ter no máximo 50 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-14 – Tentar cadastrar categoria com nome menor que 3 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo do campo nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Preencher o campo nome com menos de 3 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome da categoria deve ter no mínimo 3 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-15 – Tentar cadastrar categoria com nome com caracteres especiais** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida caracteres especiais no campo nome. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Preencher o campo nome com caracteres especiais <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome da categoria não deve conter caracteres especiais". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-16 – Tentar cadastrar categoria com descrição vazia** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o campo descrição e impede o cadastro sem descrição. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Deixar o campo descrição vazio <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A descrição da categoria não deve ser vazia". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-17 – Tentar cadastrar categoria com descrição maior que 155 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho máximo do campo descrição. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Preencher o campo descrição com mais de 155 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A descrição da categoria deve ter no máximo 155 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-18 – Tentar cadastrar categoria com descrição menor que 3 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo do campo descrição. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Preencher o campo descrição com menos de 3 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A descrição da categoria deve ter no mínimo 3 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-19 – Tentar cadastrar categoria com nome duplicado** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema impede o cadastro de categorias com nomes duplicados. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias <br> - Preencher os campos com dados de uma categoria já existente <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Não é possível criar a categoria porque já existe uma categoria com o mesmo nome". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-20 – Tentar cadastrar categoria com ID de usuário inexistente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência do usuário antes de criar a categoria. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de categorias de usuário <br> - Preencher os campos com um ID de usuário inexistente <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Usuario não encontrado ou inexistente". |
|  	|  	|

<br>

## Testes de Transação

| **Caso de Teste** 	| **CT-21 – Cadastrar transação com dados válidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema permite o cadastro de uma nova transação com dados válidos. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Preencher os campos obrigatórios (descrição, valor, rateios) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - A transação deve ser criada com sucesso <br> - Um ID deve ser gerado automaticamente. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-22 – Tentar cadastrar transação sem valor total** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o campo valor e impede o cadastro sem valor. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Deixar o campo valor vazio <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O valor deve ser maior que 0 e não deve ser vazio". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-23 – Tentar cadastrar transação com valor 0** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida valores zerados. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Preencher o campo valor com 0 <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O valor deve ser maior que 0 e não deve ser vazio". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-24 – Tentar cadastrar transação sem rateio** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência de rateios. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Não informar nenhum rateio <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Não é possível cadastrar transação sem categoria e destino". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-25 – Cadastrar transação com múltiplos rateios** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema permite o cadastro de transações com múltiplos rateios. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Preencher os campos obrigatórios <br> - Adicionar múltiplos rateios <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - A transação deve ser criada com múltiplos rateios <br> - Os dados devem ser salvos corretamente. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-26 – Tentar cadastrar transação com categoria inexistente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência das categorias nos rateios. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Adicionar rateio com categoria inexistente <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-27 – Tentar cadastrar transação com descrição vazia** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o campo descrição. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Deixar o campo descrição vazio <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A descrição da transação não pode ser vazia". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-28 – Tentar cadastrar transação com descrição maior que 155 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho máximo da descrição. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Preencher descrição com mais de 155 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A descrição deve ter no máximo 155 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-29 – Tentar cadastrar transação com descrição menor que 5 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo da descrição. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Preencher descrição com menos de 5 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A descrição deve ter no mínimo 5 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-30 – Tentar cadastrar transação com rateio sem destino** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o campo destino nos rateios. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Adicionar rateio sem destino <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O destino da transação não pode ser vazia". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-31 – Tentar cadastrar transação com destino menor que 5 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo do destino. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Adicionar rateio com destino menor que 5 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O destino deve ter no mínimo 5 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-32 – Tentar cadastrar transação com destino maior que 20 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho máximo do destino. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Adicionar rateio com destino maior que 20 caracteres <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O destino deve ter no máximo 20 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-33 – Tentar cadastrar transação com soma dos rateios diferente do valor total** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a soma dos rateios com o valor total. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Adicionar rateios cuja soma seja diferente do valor total <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A soma do valor da categoria está diferente do valor total da transação". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-34 – Tentar cadastrar transação com usuário inexistente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência do usuário. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de cadastro de transações <br> - Informar ID de usuário inexistente <br> - Preencher os demais campos obrigatórios <br> - Tentar cadastrar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Usuario não encontrado ou inexistente". |
|  	|  	|

<br>

## Testes de Atualização de Categoria

| **Caso de Teste** 	| **CT-35 – Atualizar categoria com dados válidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário atualizar categorias. |
| Objetivo do Teste 	| Verificar se o sistema permite a atualização de uma categoria existente. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização de categorias com ID válido <br> - Preencher os campos a serem atualizados <br> - Clicar em "Atualizar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - A categoria deve ser atualizada com sucesso <br> - Os dados devem ser salvos corretamente. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-36 – Tentar atualizar categoria inexistente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário atualizar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência da categoria antes de atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID inexistente <br> - Preencher os campos <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 404 Not Found <br> - Uma mensagem de erro deve ser exibida: "Categoria não encontrada ou inexistente". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-37 – Tentar atualizar categoria com nome menor que 3 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário atualizar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo do nome ao atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher nome com menos de 3 caracteres <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O nome deve ter no mínimo 3 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-38 – Tentar atualizar categoria com descrição menor que 3 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário atualizar categorias. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo da descrição ao atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher descrição com menos de 3 caracteres <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida relacionada ao tamanho da descrição. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-39 – Atualizar categoria parcialmente (apenas nome)** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário atualizar categorias. |
| Objetivo do Teste 	| Verificar se o sistema permite atualização parcial de campos. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher apenas o campo nome <br> - Clicar em "Atualizar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - Apenas o nome deve ser atualizado <br> - Outros campos devem permanecer inalterados. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-40 – Atualizar categoria parcialmente (apenas descrição)** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário atualizar categorias. |
| Objetivo do Teste 	| Verificar se o sistema permite atualização parcial de campos. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher apenas o campo descrição <br> - Clicar em "Atualizar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - Apenas a descrição deve ser atualizada <br> - Outros campos devem permanecer inalterados. |
|  	|  	|

<br>

## Testes de Atualização de Transação

| **Caso de Teste** 	| **CT-41 – Atualizar transação com dados válidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema permite a atualização de uma transação existente. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização de transações com ID válido <br> - Preencher os campos a serem atualizados <br> - Clicar em "Atualizar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - A transação deve ser atualizada com sucesso <br> - Os dados devem ser salvos corretamente. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-42 – Tentar atualizar transação inexistente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência da transação antes de atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID inexistente <br> - Preencher os campos <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 404 Not Found <br> - Uma mensagem de erro deve ser exibida: "Transação não encontrada ou inexistente". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-43 – Tentar atualizar transação sem rateio** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência de rateios ao atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Remover todos os rateios <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Não é possível cadastrar transação sem categoria e destino". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-44 – Tentar atualizar transação com categoria inexistente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a existência das categorias ao atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Adicionar rateio com categoria inexistente <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-45 – Tentar atualizar transação com descrição menor que 3 caracteres** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida o tamanho mínimo da descrição ao atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher descrição com menos de 3 caracteres <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "A descrição deve ter no mínimo 3 caracteres". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-46 – Tentar atualizar transação com valor menor ou igual a 0** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida valores negativos ou zerados ao atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher valor com 0 ou negativo <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O valor não deve ser menor ou igual a 0". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-47 – Tentar atualizar transação com soma dos rateios diferente do valor total** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema valida a soma dos rateios ao atualizar. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Adicionar rateios cuja soma seja diferente do valor total <br> - Tentar atualizar |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve ser exibida: "O valor da categoria está diferente do valor total da transação". |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-48 – Atualizar transação parcialmente (apenas valor total)** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema permite atualização parcial de campos. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher apenas o campo valor total <br> - Clicar em "Atualizar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - Apenas o valor total deve ser atualizado <br> - Outros campos devem permanecer inalterados. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-49 – Atualizar transação parcialmente (apenas descrição)** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário atualizar transações. |
| Objetivo do Teste 	| Verificar se o sistema permite atualização parcial de campos. |
| Passos 	| - Acessar o navegador <br> - Informar o endpoint de atualização com ID válido <br> - Preencher apenas o campo descrição <br> - Clicar em "Atualizar" |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - Apenas a descrição deve ser atualizada <br> - Outros campos devem permanecer inalterados. |
|  	|  	|

<br>

## Resumo dos Testes

| Total de Casos | Casos de Criação | Casos de Atualização | Casos de Validação |
|:---:|:---:|:---:|:---:|
| 49 | 34 | 15 | 49 |

### Distribuição por Entidade

- **Usuário**: 10 casos (CT-01 a CT-10)
- **Categoria**: 16 casos (CT-11 a CT-20, CT-35 a CT-40)
- **Transação**: 23 casos (CT-21 a CT-34, CT-41 a CT-49)

### Tipos de Teste

- ✅ **Testes de Sucesso**: Casos que validam o funcionamento correto (CT-01, CT-11, CT-21, CT-25, CT-35, CT-39, CT-40, CT-41, CT-48, CT-49)
- ❌ **Testes de Falha**: Casos que validam tratamento de erros e exceções (todos os outros casos)
- 🔄 **Testes de Atualização Parcial**: Casos que validam PATCH (CT-39, CT-40, CT-48, CT-49)