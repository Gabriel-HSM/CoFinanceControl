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

---

## Autenticação

<br>

| **Caso de Teste** 	| **CT-50 – Registrar nova conta com dados válidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema cria uma Entidade Financeira, usuário Admin e credencial, retornando um token JWT. |
| Passos 	| - Acessar `POST /api/Autentificacao/registrar` <br> - Preencher os campos obrigatórios (nome, sobrenome, email, senha, nomeEntidade, tipoEntidade) <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 201 Created <br> - A resposta deve conter `token`, `usuarioId` e `entidadeFinanceiraId`. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-51 – Tentar registrar com email já cadastrado** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema impede o cadastro com email duplicado. |
| Passos 	| - Acessar `POST /api/Autentificacao/registrar` <br> - Informar um email já existente no sistema <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve informar que o email já está em uso. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-52 – Tentar registrar com senha fora do padrão** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o sistema valida o formato da senha (mínimo 8 caracteres, letras e números). |
| Passos 	| - Acessar `POST /api/Autentificacao/registrar` <br> - Preencher o campo senha com valor inválido (ex: "abc") <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve descrever o formato esperado da senha. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-53 – Realizar login com credenciais válidas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário autenticar-se. |
| Objetivo do Teste 	| Verificar se o sistema autentica o usuário e retorna um token JWT válido. |
| Passos 	| - Acessar `POST /api/Autentificacao/login` <br> - Informar email e senha cadastrados <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - A resposta deve conter `token`, `usuarioId` e `entidadeFinanceiraId`. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-54 – Tentar login com senha incorreta** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário autenticar-se. |
| Objetivo do Teste 	| Verificar se o sistema rejeita credenciais com senha errada. |
| Passos 	| - Acessar `POST /api/Autentificacao/login` <br> - Informar email válido e senha incorreta <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - Uma mensagem de erro deve indicar credenciais inválidas. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-55 – Tentar login com email inexistente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário autenticar-se. |
| Objetivo do Teste 	| Verificar se o sistema retorna 404 para email não cadastrado. |
| Passos 	| - Acessar `POST /api/Autentificacao/login` <br> - Informar um email não cadastrado no sistema <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 404 Not Found <br> - Uma mensagem deve informar que o email não foi encontrado. |
|  	|  	|

<br>

---

## Autorização (JWT)

<br>

| **Caso de Teste** 	| **CT-56 – Acessar endpoint protegido sem token** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve controlar o acesso via autenticação. |
| Objetivo do Teste 	| Verificar se o sistema bloqueia acesso a endpoints protegidos sem autenticação. |
| Passos 	| - Acessar `GET /api/entidadefinanceira` **sem** o header `Authorization` <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 401 Unauthorized. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-57 – Acessar endpoint de Admin com cargo insuficiente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve controlar o acesso via autorização por cargo. |
| Objetivo do Teste 	| Verificar se o sistema bloqueia acesso a endpoints restritos a Admin quando o usuário possui cargo inferior. |
| Passos 	| - Autenticar com usuário de cargo **não-Admin** <br> - Acessar `DELETE /api/entidadefinanceira/{id}` com o token obtido <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 403 Forbidden. |
|  	|  	|

<br>

---

## Entidade Financeira

<br>

| **Caso de Teste** 	| **CT-58 – Obter dados da Entidade Financeira autenticado** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve exibir os dados da entidade financeira do usuário. |
| Objetivo do Teste 	| Verificar se o sistema retorna os dados da entidade associada ao usuário autenticado. |
| Passos 	| - Registrar ou fazer login para obter token <br> - Acessar `GET /api/entidadefinanceira` com header `Authorization: Bearer <token>` <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - A resposta deve conter os dados da entidade financeira do usuário. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-59 – Tentar adicionar segundo usuário a entidade do tipo Solo** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve respeitar as restrições de tipo de entidade. |
| Objetivo do Teste 	| Verificar se o sistema impede adicionar um segundo usuário a uma entidade Solo. |
| Passos 	| - Registrar conta com tipo `Solo` <br> - Autenticar como Admin <br> - Acessar `POST /api/users` e tentar criar um segundo usuário <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - A mensagem deve informar que entidade Solo permite apenas 1 usuário. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-60 – Alterar tipo da entidade para Solo com mais de 1 membro** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve validar mudança de tipo de entidade. |
| Objetivo do Teste 	| Verificar se o sistema impede alterar para Solo quando há mais de 1 usuário na entidade. |
| Passos 	| - Registrar conta com tipo `Familia` <br> - Adicionar um segundo usuário <br> - Autenticar como Admin <br> - Acessar `PATCH /api/entidadefinanceira/{id}/tipo` com `novoTipo: "Solo"` <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - A mensagem deve informar a quantidade de membros que impedem a mudança. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-61 – Alterar tipo da entidade com sucesso** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao Admin alterar o tipo da entidade. |
| Objetivo do Teste 	| Verificar se o sistema permite alterar o tipo da entidade quando as regras são respeitadas. |
| Passos 	| - Registrar conta com tipo `Solo` <br> - Autenticar como Admin <br> - Acessar `PATCH /api/entidadefinanceira/{id}/tipo` com `novoTipo: "Familia"` <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 200 OK <br> - O tipo da entidade deve ser atualizado para `Familia`. |
|  	|  	|

<br>

| **Caso de Teste** 	| **CT-62 – Tentar alterar tipo da entidade para o mesmo tipo atual** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve validar mudança de tipo de entidade. |
| Objetivo do Teste 	| Verificar se o sistema impede alterar o tipo para o mesmo valor já definido. |
| Passos 	| - Registrar conta com tipo `Solo` <br> - Autenticar como Admin <br> - Acessar `PATCH /api/entidadefinanceira/{id}/tipo` com `novoTipo: "Solo"` <br> - Enviar a requisição |
|Critério de Êxito | - O sistema deve retornar status 400 Bad Request <br> - A mensagem deve informar que a entidade já é do tipo informado. |
|  	|  	|

<br>

---

## Resumo dos Testes

| Total de Casos | Casos de Criação/Autenticação | Casos de Atualização | Casos de Validação |
|:---:|:---:|:---:|:---:|
| 62 | 37 | 17 | 62 |

### Distribuição por Entidade

- **Usuário**: 10 casos (CT-01 a CT-10)
- **Categoria**: 16 casos (CT-11 a CT-20, CT-35 a CT-40)
- **Transação**: 23 casos (CT-21 a CT-34, CT-41 a CT-49)
- **Autenticação**: 6 casos (CT-50 a CT-55)
- **Autorização JWT**: 2 casos (CT-56 a CT-57)
- **Entidade Financeira**: 5 casos (CT-58 a CT-62)

### Tipos de Teste

- ✅ **Testes de Sucesso**: Casos que validam o funcionamento correto (CT-01, CT-11, CT-21, CT-25, CT-35, CT-39, CT-40, CT-41, CT-48, CT-49, CT-50, CT-53, CT-58, CT-61)
- ❌ **Testes de Falha**: Casos que validam tratamento de erros e exceções (todos os outros casos)
- 🔄 **Testes de Atualização Parcial**: Casos que validam PATCH (CT-39, CT-40, CT-48, CT-49, CT-61)