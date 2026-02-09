# Plano de Testes de Software

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

---

## Casos de Teste - Usuários

|Caso de Teste    | CT-01 - Cadastrar usuário com dados válidos |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema permite cadastrar um novo usuário com dados válidos |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com nome, sobrenome e data de nascimento válidos <br> 3. Verificar resposta |
| Critérios de êxito | - Status 200/201 OK/Created <br> - Retornar JSON com ID do usuário criado <br> - Dados salvos no banco |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-02 - Tentar cadastrar usuário com nome vazio |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida campo nome obrigatório |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com nome vazio <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O nome do usuário não deve ser vazio" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-03 - Tentar cadastrar usuário com nome maior que 50 caracteres |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida tamanho máximo do nome |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com nome contendo mais de 50 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O nome deve ter no máximo 50 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-04 - Tentar cadastrar usuário com nome menor que 3 caracteres |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida tamanho mínimo do nome |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com nome contendo menos de 3 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O nome deve ter no mínimo 3 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-05 - Tentar cadastrar usuário com nome com caracteres especiais |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida formato do nome |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com nome contendo números ou caracteres especiais <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "Nome não deve conter números ou caracteres especiais" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-06 - Tentar cadastrar usuário com sobrenome vazio |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida campo sobrenome obrigatório |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com sobrenome vazio <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O Sobrenome do usuário não deve ser vazio" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-07 - Tentar cadastrar usuário com sobrenome maior que 50 caracteres |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida tamanho máximo do sobrenome |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com sobrenome contendo mais de 50 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O sobrenome deve ter no máximo 50 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-08 - Tentar cadastrar usuário com sobrenome menor que 3 caracteres |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida tamanho mínimo do sobrenome |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com sobrenome contendo menos de 3 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O sobrenome deve ter no mínimo 3 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-09 - Tentar cadastrar usuário com sobrenome com caracteres especiais |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida formato do sobrenome |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com sobrenome contendo números ou caracteres especiais <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "Sobrenome não deve conter números ou caracteres especiais" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-10 - Tentar cadastrar usuário com data de nascimento futura |
|:---|:---|
| Requisitos Associados | RF-01 - O sistema deve permitir cadastro de usuários |
| Objetivo do Teste | Verificar se o sistema valida data de nascimento |
| Passos | 1. Acessar o endpoint POST /api/Usuario <br> 2. Enviar JSON com data de nascimento futura <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A data de nascimento não deve ser uma data futura" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

---

## Casos de Teste - Categorias

|Caso de Teste    | CT-11 - Cadastrar categoria com dados válidos |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema permite cadastrar uma nova categoria |
| Passos | 1. Criar um usuário <br> 2. Acessar o endpoint POST /api/Categoria <br> 3. Enviar JSON com usuarioId, nome e descrição válidos <br> 4. Verificar resposta |
| Critérios de êxito | - Status 200/201 OK/Created <br> - Retornar JSON com ID da categoria criada <br> - Categoria vinculada ao usuário correto |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-12 - Tentar cadastrar categoria com nome vazio |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida campo nome obrigatório |
| Passos | 1. Criar um usuário <br> 2. Tentar cadastrar categoria com nome vazio <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O nome da categoria não deve ser vazio" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-13 - Tentar cadastrar categoria com nome maior que 50 caracteres |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida tamanho máximo do nome |
| Passos | 1. Criar um usuário <br> 2. Tentar cadastrar categoria com nome maior que 50 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O nome da categoria deve ter no máximo 50 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-14 - Tentar cadastrar categoria com nome menor que 3 caracteres |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida tamanho mínimo do nome |
| Passos | 1. Criar um usuário <br> 2. Tentar cadastrar categoria com nome menor que 3 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O nome da categoria deve ter no mínimo 3 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-15 - Tentar cadastrar categoria com nome com caracteres especiais |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida formato do nome |
| Passos | 1. Criar um usuário <br> 2. Tentar cadastrar categoria com nome contendo caracteres especiais <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O nome da categoria não deve conter caracteres especiais" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-16 - Tentar cadastrar categoria com descrição vazia |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida campo descrição obrigatório |
| Passos | 1. Criar um usuário <br> 2. Tentar cadastrar categoria com descrição vazia <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A descrição da categoria não deve ser vazia" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-17 - Tentar cadastrar categoria com descrição maior que 155 caracteres |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida tamanho máximo da descrição |
| Passos | 1. Criar um usuário <br> 2. Tentar cadastrar categoria com descrição maior que 155 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A descrição da categoria deve ter no máximo 155 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-18 - Tentar cadastrar categoria com descrição menor que 3 caracteres |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida tamanho mínimo da descrição |
| Passos | 1. Criar um usuário <br> 2. Tentar cadastrar categoria com descrição menor que 3 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A descrição da categoria deve ter no mínimo 3 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-19 - Tentar cadastrar categoria com nome duplicado |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema impede categorias duplicadas para o mesmo usuário |
| Passos | 1. Criar um usuário <br> 2. Cadastrar uma categoria "Alimentação" <br> 3. Tentar cadastrar outra categoria "Alimentação" para o mesmo usuário <br> 4. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "Não é possível criar a categoria porque já existe uma categoria com o mesmo nome" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-20 - Tentar cadastrar categoria com usuário inexistente |
|:---|:---|
| Requisitos Associados | RF-02 - O sistema deve permitir cadastro de categorias |
| Objetivo do Teste | Verificar se o sistema valida existência do usuário |
| Passos | 1. Tentar cadastrar categoria com ID de usuário inexistente <br> 2. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "Usuario Não encontrado" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

---

## Casos de Teste - Transações

|Caso de Teste    | CT-21 - Cadastrar transação com dados válidos |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema permite cadastrar uma transação simples |
| Passos | 1. Criar usuário e categoria <br> 2. Acessar o endpoint POST /api/Transacao <br> 3. Enviar JSON com usuarioId, valorTotal, descrição e um rateio <br> 4. Verificar resposta |
| Critérios de êxito | - Status 200/201 OK/Created <br> - Retornar JSON com ID da transação <br> - Valores salvos corretamente |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-22 - Tentar cadastrar transação sem valor total |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema valida campo valor obrigatório |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação sem valor total <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O valor deve ser maior que 0 e não deve ser vazio" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-23 - Tentar cadastrar transação com valor zero |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema valida valor mínimo |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação com valor 0 <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O valor deve ser maior que 0 e não deve ser vazio" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-24 - Tentar cadastrar transação sem rateio |
|:---|:---|
| Requisitos Associados | RF-03, RF-04 - O sistema deve permitir cadastro de transações com rateio |
| Objetivo do Teste | Verificar se o sistema valida rateio obrigatório |
| Passos | 1. Criar usuário <br> 2. Tentar cadastrar transação sem rateios <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A transação deve ter uma categoria e destino (rateio)." |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-25 - Cadastrar transação com múltiplos rateios |
|:---|:---|
| Requisitos Associados | RF-03, RF-04 - O sistema deve permitir cadastro de transações e rateio |
| Objetivo do Teste | Verificar se o sistema permite dividir uma transação entre várias categorias |
| Passos | 1. Criar usuário e 2 categorias <br> 2. Acessar o endpoint POST /api/Transacao <br> 3. Enviar JSON com valorTotal 150 e 2 rateios (100 e 50) <br> 4. Verificar resposta |
| Critérios de êxito | - Status 200/201 OK/Created <br> - Retornar transação com 2 rateios <br> - Soma dos rateios = valor total |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-26 - Tentar cadastrar transação com categoria inexistente |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema valida existência da categoria |
| Passos | 1. Criar usuário <br> 2. Tentar cadastrar transação com ID de categoria inexistente <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-27 - Tentar cadastrar transação com descrição vazia |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema valida campo descrição obrigatório |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação com descrição vazia <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A descrição da transação não pode ser vazia" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-28 - Tentar cadastrar transação com descrição maior que 155 caracteres |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema valida tamanho máximo da descrição |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação com descrição maior que 155 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A descrição deve ter no máximo 155 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-29 - Tentar cadastrar transação com descrição menor que 5 caracteres |
|:---|:---|
| Requisitos Associados | RF-03 - O sistema deve permitir cadastro de transações |
| Objetivo do Teste | Verificar se o sistema valida tamanho mínimo da descrição |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação com descrição menor que 5 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "A descrição deve ter no mínimo 5 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-30 - Tentar cadastrar transação com rateio sem destino |
|:---|:---|
| Requisitos Associados | RF-03, RF-04 - O sistema deve permitir cadastro de transações com rateio |
| Objetivo do Teste | Verificar se o sistema valida campo destino obrigatório no rateio |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação com rateio sem destino <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O destino da transação não pode ser vazia" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-31 - Tentar cadastrar transação com destino menor que 5 caracteres |
|:---|:---|
| Requisitos Associados | RF-03, RF-04 - O sistema deve permitir cadastro de transações com rateio |
| Objetivo do Teste | Verificar se o sistema valida tamanho mínimo do destino |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação com destino menor que 5 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O destino deve ter no mínimo 5 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-32 - Tentar cadastrar transação com destino maior que 20 caracteres |
|:---|:---|
| Requisitos Associados | RF-03, RF-04 - O sistema deve permitir cadastro de transações com rateio |
| Objetivo do Teste | Verificar se o sistema valida tamanho máximo do destino |
| Passos | 1. Criar usuário e categoria <br> 2. Tentar cadastrar transação com destino maior que 20 caracteres <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O destino deve ter no máximo 20 caracteres" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

|Caso de Teste    | CT-33 - Tentar cadastrar transação com soma dos rateios diferente do valor total |
|:---|:---|
| Requisitos Associados | RF-04 - O sistema deve permitir rateio de transações |
| Objetivo do Teste | Verificar se o sistema valida que a soma dos rateios deve ser igual ao valor total |
| Passos | 1. Criar usuário e categorias <br> 2. Tentar cadastrar transação com valor 100 e rateios somando 80 <br> 3. Verificar resposta |
| Critérios de êxito | - Status 400 Bad Request <br> - Retornar mensagem: "O valor da categoria está diferente do valor total" |
| Responsável pela elaboração do caso de Teste | Gabriel Henrique |

---

## Ferramentas de Teste

- **Postman/Insomnia**: Testes manuais de API
- **In-Memory Database**: Ambiente de desenvolvimento
- **Visual Studio**: Debugger para análise de falhas

## Ambiente de Testes

- **Ambiente**: Desenvolvimento
- **Banco de Dados**: In-Memory (Postgress)
- **Framework**: .NET 10.0
- **Servidor**: Localhost

## Cronograma

- **Planejamento**: Em andamento
- **Execução**: 06/02/2026
- **Taxa de sucesso atual**: 89% (29/33 casos aprovados)
- **Próxima execução**: Após correções dos casos CT-19, CT-20, CT-26 e CT-33