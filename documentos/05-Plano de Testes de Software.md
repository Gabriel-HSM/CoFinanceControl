# Plano de Testes de Software

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

---

## Casos de Teste - Usuários

|Caso de Teste    | CT-01 - Cadastrar usuário com dados válidos |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema permite cadastrar um novo usuário com dados válidos |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com nome, sobrenome e data de nascimento válidos <br> 3. Verificar resposta |
| Critérios de êxito | - Status 200 OK <br> - Retornar JSON com ID do usuário criado <br> - Dados salvos no banco |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-02 - Tentar cadastrar usuário com nome vazio |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida campos obrigatórios |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com nome vazio <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem de erro informando que o nome é obrigatório |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

---

## Casos de Teste - Categorias

|Caso de Teste    | CT-03 - Cadastrar categoria com dados válidos |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema permite cadastrar uma nova categoria |
| Passos | 1. Criar um usuário <br> 2. Acessar o endpoint POST /api/Categoria <br> 3. Enviar JSON com usuarioId e nome da categoria <br> 4. Verificar resposta |
| Critérios de êxito | - Status 200 OK <br> - Retornar JSON com ID da categoria criada <br> - Categoria vinculada ao usuário correto |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-04 - Tentar cadastrar categoria com nome duplicado para o mesmo usuário |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema impede categorias duplicadas para o mesmo usuário |
| Passos | 1. Criar um usuário <br> 2. Cadastrar uma categoria "Alimentação" <br> 3. Tentar cadastrar outra categoria "Alimentação" para o mesmo usuário <br> 4. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem informando que já existe categoria com esse nome |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

---

## Casos de Teste - Transações

|Caso de Teste    | CT-05 - Cadastrar transação sem rateio |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema permite cadastrar uma transação simples |
| Passos | 1. Criar usuário e categoria <br> 2. Acessar o endpoint POST /api/Transacao <br> 3. Enviar JSON com usuarioId, valorTotal, descrição e um rateio <br> 4. Verificar resposta |
| Critérios de êxito | - Status 200 OK <br> - Retornar JSON com ID da transação <br> - Valores salvos corretamente |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-06 - Cadastrar transação com múltiplos rateios |
|:---|:---|
| Requisitos Associados | RF-03, RF-04 - O sistema deve permitir cadastro de transações e rateio |
| Objetivo do Teste | Verificar se o sistema permite dividir uma transação entre várias categorias |
| Passos | 1. Criar usuário e 2 categorias <br> 2. Acessar o endpoint POST /api/Transacao <br> 3. Enviar JSON com valorTotal 150 e 2 rateios (100 e 50) <br> 4. Verificar resposta |
| Critérios de êxito | - Status 200 OK <br> - Retornar transação com 2 rateios <br> - Soma dos rateios = valor total |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-07 - Tentar cadastrar transação com soma dos rateios diferente do valor total |
|:---|:---|
| Requisitos Associados | RF-04 - O sistema deve permitir rateio de transações |
| Objetivo do Teste | Verificar se o sistema valida que a soma dos rateios deve ser igual ao valor total |
| Passos | 1. Criar usuário e categorias <br> 2. Tentar cadastrar transação com valor 100 e rateios somando 80 <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem de erro informando inconsistência nos valores |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-08 - Listar histórico de transações |
|:---|:---|
| Requisitos Associados | RF-05 - O sistema deve permitir visualização do histórico de transações |
| Objetivo do Teste | Verificar se o sistema retorna todas as transações cadastradas |
| Passos | 1. Criar usuário, categorias e cadastrar 3 transações <br> 2. Acessar o endpoint GET /api/Transacao <br> 3. Verificar resposta |
| Critérios de êxito | - Status 200 OK <br> - Retornar lista com as 3 transações <br> - Cada transação com seus rateios |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-09 - Atualizar transação existente |
|:---|:---|
| Requisitos Associados | RF-06 - O sistema deve permitir atualização de transações |
| Objetivo do Teste | Verificar se o sistema permite alterar dados de uma transação |
| Passos | 1. Criar transação <br> 2. Acessar o endpoint PUT /api/Transacao/{id} <br> 3. Enviar novos dados <br> 4. Verificar resposta |
| Critérios de êxito | - Status 200 OK <br> - Retornar transação com dados atualizados <br> - DataAtualizacao alterada |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-10 - Excluir transação existente |
|:---|:---|
| Requisitos Associados | RF-07 - O sistema deve permitir exclusão de transações |
| Objetivo do Teste | Verificar se o sistema permite deletar uma transação |
| Passos | 1. Criar transação <br> 2. Acessar o endpoint DELETE /api/Transacao/{id} <br> 3. Verificar resposta <br> 4. Tentar consultar a transação deletada |
| Critérios de êxito | - Status 200 OK na exclusão <br> - Status 404 Not Found ao tentar consultar |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |