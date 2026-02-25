# Instruções de utilização

## Estrutura do Projeto

O projeto segue os princípios de **Clean Architecture**, com separação clara de responsabilidades em camadas:

```
codigo-fonte/
└─ src/
   ├─ CoFinanceControl.Domain/          # Entidades, Value Objects e Enums
   │  ├─ Models/
   │  │  ├─ Usuario/
   │  │  ├─ Categoria/
   │  │  ├─ Transacao/
   │  │  ├─ Rateio/
   │  │  ├─ EntidadeFinanceira/
   │  │  └─ Credencial/
   │  │     └─ ValueObjects/
   │  │        └─ Senha.cs
   │  └─ Enums/
   │     ├─ Cargo.cs
   │     ├─ TipoEntidade.cs
   │     └─ ProvedorAutenticacao.cs
   │
   ├─ CoFinanceControl.Application/     # Casos de uso, DTOs e contratos
   │  ├─ Autentificacao/
   │  │  ├─ Services/
   │  │  │  └─ AutentificacaoService.cs
   │  │  └─ DTOs/
   │  │     ├─ CriarAutentificacaoDto.cs
   │  │     ├─ LoginDto.cs
   │  │     └─ ResultadoAutentificacaoDto.cs
   │  ├─ EntidadeFinanceiraApp/
   │  │  ├─ Services/
   │  │  │  └─ EntidadeFinanceiraService.cs
   │  │  ├─ DTOs/
   │  │  │  ├─ AtualizarEntidadeDto.cs
   │  │  │  └─ AlterarTipoEntidadeDto.cs
   │  │  └─ Repositories/
   │  │     └─ IEntidadeFinanceiraRepository.cs
   │  ├─ Credenciais/
   │  │  └─ Repositories/
   │  │     └─ ICredencialRepository.cs
   │  ├─ Usuarios/
   │  │  ├─ Services/
   │  │  │  └─ UsuarioService.cs
   │  │  ├─ DTOs/
   │  │  └─ Repositories/
   │  │     └─ IUsuarioRepository.cs
   │  ├─ Categorias/
   │  │  ├─ Services/
   │  │  │  └─ CategoriaService.cs
   │  │  ├─ DTOs/
   │  │  └─ Repositories/
   │  │     └─ ICategoriaRepository.cs
   │  └─ Transacoes/
   │     ├─ Services/
   │     │  └─ TransacaoService.cs
   │     ├─ DTOs/
   │     └─ Repositories/
   │        └─ ITransacaoRepository.cs
   │
   ├─ CoFinanceControl.Infrastructure/  # Repositórios e acesso a dados
   │  ├─ Data/
   │  │  └─ CoFinanceDbContext.cs
   │  ├─ Repositories/
   │  │  ├─ UsuarioRepository.cs
   │  │  ├─ CategoriaRepository.cs
   │  │  ├─ TransacaoRepository.cs
   │  │  ├─ EntidadeFinanceiraRepository.cs
   │  │  └─ CredencialRepository.cs
   │  └─ Extensions/
   │     └─ InjecaoDependencia.cs
   │
   └─ CoFinanceControl.WebApi/          # Controllers, Middleware e configuração da API
      ├─ Controllers/
      │  ├─ AutentificacaoController.cs
      │  ├─ UsersController.cs
      │  ├─ EntidadeFinanceiraController.cs
      │  ├─ CategoriasController.cs
      │  └─ TransacoesController.cs
      ├─ Middleware/
      │  └─ ExceptionHandlerMiddleware.cs
      ├─ Common/
      │  ├─ IJwtService.cs / JwtService.cs
      │  └─ IUsuarioAutenticado.cs / UsuarioAutenticado.cs
      ├─ Program.cs
      └─ appsettings*.json
```

## Padrões e Convenções

| Padrões | Descrição | Implementação |
| --- | --- | --- |
| Arquitetura | Clean Architecture com DDD | Separação em Domain, Application, Infrastructure e WebApi |
| Versionamento de API | `/api/[controller]` | Preparado para versionamento futuro |
| Formato de resposta | `JSON` | Padronizado via controllers |
| Validação | DataAnnotations + Regras de Negócio | Validações em DTOs e Services |
| Persistência | Entity Framework Core | In-Memory para desenvolvimento, SQL Server para produção |
| Documentação | Swagger/OpenAPI | Disponível em `/swagger` (com suporte a Bearer token) |
| Injeção de Dependência | Nativa do .NET | Configurada em `InjecaoDependencia.cs` e `Program.cs` |
| Tratamento de Exceções | Middleware customizado | 400, 404, 500 padronizados; ArgumentException → 400 |
| Autenticação | JWT Bearer (HS256) | Configurado em `Program.cs`; claims: UsuarioId, EntidadeFinanceiraId, Cargo |
| Autorização | RBAC por Cargo | `[Authorize(Roles = "...")]` por endpoint |
| Hash de senha | BCrypt (BCrypt.Net-Next 4.1.0) | Senhas nunca armazenadas em texto puro |

## Instalação da aplicação

**Pré-requisitos**

- .NET SDK 8.0 ou superior
- (Opcional) SQL Server para ambiente de produção
- (Opcional) Docker para containerização

**Execução local**

1. Clone o repositório:
```bash
git clone https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e3-proj-mov-t1-pmv-ads-2024-2-e3-proj-cofinance.git
cd CoFinanceControl/codigo-fonte
```

2. Restaure as dependências:
```bash
dotnet restore
```

3. Execute a aplicação:
```bash
cd src/CoFinanceControl.API
dotnet run
```

4. Acesse o Swagger:
```
https://localhost:7138/swagger
```

> **Autenticação no Swagger:** Clique em "Authorize" (cadeado) e informe `Bearer <token>` no campo. O token é obtido via `POST /api/Autentificacao/registrar` ou `POST /api/Autentificacao/login`.

**Configuração do Banco de Dados**

- **Desenvolvimento**: Utiliza In-Memory Database (configurado por padrão)
- **Produção**: Configure a connection string no `appsettings.json`

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=seu_servidor;Database=CoFinanceControl;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

**Execução remota**

- Provedores sugeridos: Azure App Service, AWS Elastic Beanstalk, Railway
- Banco de dados: SQL Server (Azure SQL, AWS RDS)
- URL pública: [a definir]

## Módulos Implementados

| Módulo | Responsável | Status | Endpoints |
| --- | --- | --- | --- |
| Autenticação | Gabriel Henrique | ✅ Concluído | POST `/api/Autentificacao/registrar`, POST `/api/Autentificacao/login` |
| Entidade Financeira | Gabriel Henrique | ✅ Concluído | GET, PUT, DELETE, PATCH `/api/entidadefinanceira` |
| Usuários | Gabriel Henrique | ✅ Concluído | POST, GET, PUT, DELETE `/api/users` |
| Categorias | Gabriel Henrique | ✅ Concluído | POST, GET, PATCH, DELETE `/api/categorias` |
| Transações | Gabriel Henrique | ✅ Concluído | POST, GET, PATCH, DELETE `/api/transacoes` |
| Rateios | Gabriel Henrique | ✅ Integrado | Vinculado a Transações (sistema de múltiplos rateios) |

## Autenticação e Autorização

### Fluxo de Autenticação

1. **Registro**: `POST /api/Autentificacao/registrar` — cria uma Entidade Financeira, um usuário Admin e suas credenciais. Retorna um JWT token.
2. **Login**: `POST /api/Autentificacao/login` — valida email e senha (BCrypt), retorna JWT token.
3. **Uso do token**: Todas as rotas protegidas exigem o header `Authorization: Bearer <token>`.

### Cargos disponíveis (`Cargo`)

| Cargo | Valor | Permissões típicas |
|---|---|---|
| Admin | 1 | Acesso total: gerenciar usuários, inativar entidade, alterar tipo |
| GerenteFinanceiro | 2 | Acesso de leitura + operações financeiras |
| AnalistaFinanceiro | 3 | Operações de análise |
| Contador | 4 | Operações contábeis |
| OperadorFinanceiro | 5 | Operações básicas de registro |

### Tipos de Entidade Financeira (`TipoEntidade`)

| Tipo | Descrição | Restrição |
|---|---|---|
| Solo | Uso pessoal individual | Máximo 1 usuário |
| Familia | Controle familiar | Múltiplos usuários |
| Empresa | Uso corporativo | Múltiplos usuários |

> Alterar de Familia/Empresa para Solo só é permitido se houver apenas 1 membro.

---

## Funcionalidades Principais

### 1. Gestão de Usuários
- Cadastro de usuários com validação completa de dados
- Validações:
  - Nome e sobrenome: mínimo 3, máximo 50 caracteres, sem números/caracteres especiais
  - Email: formato válido
  - Data de nascimento: não pode ser futura
- Consulta de usuários por ID e listagem

### 2. Gestão de Categorias
- Categorias do sistema (padrão)
- Categorias personalizadas por usuário
- Validações:
  - Nome: mínimo 3, máximo 50 caracteres, sem caracteres especiais, único
  - Descrição: mínimo 3, máximo 155 caracteres
- Atualização parcial (PATCH) de campos
- Exclusão de categorias
- Verificação de existência de usuário

### 3. Gestão de Transações
- Registro de receitas e despesas
- Sistema de múltiplos rateios por transação
- Validações:
  - Descrição: mínimo 5, máximo 155 caracteres
  - Valor total: deve ser maior que 0
  - Rateios: soma deve ser igual ao valor total
  - Destino: mínimo 5, máximo 20 caracteres
- Atualização parcial (PATCH) de transações
- Exclusão de transações com rateios em cascata
- Verificação de categorias válidas

### 4. Sistema de Rateios
- Divisão de transações entre múltiplas categorias
- Validação automática da soma dos valores
- Suporte a múltiplos destinos
- Atualização completa ao modificar transação

## Validações Implementadas

### Validações de Dados (DataAnnotations)

| Entidade | Campo | Regras |
|----------|-------|--------|
| **Usuário** | Nome | Obrigatório, 3-50 caracteres, sem números/especiais |
| | Sobrenome | Obrigatório, 3-50 caracteres, sem números/especiais |
| | Email | Obrigatório, formato válido |
| | Data Nascimento | Obrigatório, não pode ser futura |
| **Categoria** | Nome | Obrigatório, 3-50 caracteres, sem especiais |
| | Descrição | Obrigatório, 3-155 caracteres |
| **Transação** | Descrição | Obrigatório, 5-155 caracteres |
| | Valor Total | Obrigatório, > 0 |
| **Rateio** | Destino | Obrigatório, 5-20 caracteres |
| | Valor | Obrigatório, > 0 |

### Validações de Negócio (Services)

- ✅ Nome de categoria único (por usuário/sistema)
- ✅ Soma dos rateios = valor total da transação
- ✅ Categorias devem existir antes de uso em transações
- ✅ Usuários devem existir antes de associação
- ✅ Impedimento de valores zerados ou negativos
- ✅ Validação de integridade referencial

### Documentação Completa

Para detalhes sobre os casos de teste:
- [Plano de Testes](../documentos/05-Plano%20de%20Testes%20de%20Software.md) - 49 casos planejados
- [Registro de Testes](../documentos/06-Registro%20de%20Testes%20de%20Software.md) - 49 casos executados

## Documentação da API

### Endpoints Disponíveis

#### Autenticação (público)
- `POST /api/Autentificacao/registrar` - Registrar nova Entidade Financeira + usuário Admin (retorna token)
- `POST /api/Autentificacao/login` - Autenticar e receber token JWT

#### Entidade Financeira (requer autenticação)
- `GET /api/entidadefinanceira` - Obter dados da entidade do usuário autenticado
- `PUT /api/entidadefinanceira/{id}` - Atualizar entidade (**Admin**)
- `DELETE /api/entidadefinanceira/{id}` - Inativar entidade (**Admin**)
- `PATCH /api/entidadefinanceira/{id}/tipo` - Alterar tipo da entidade (**Admin**)

#### Usuários (requer autenticação)
- `POST /api/users` - Criar usuário na entidade (**Admin**)
- `GET /api/users/{id}` - Buscar usuário por ID (todos os cargos)
- `PUT /api/users` - Atualizar meu próprio perfil (todos os cargos)
- `PUT /api/users/{id}` - Atualizar outro usuário (**Admin**)
- `DELETE /api/users/{id}` - Remover usuário (**Admin**)
- `GET /api/users` - Listar todos os usuários (**Admin**, **GerenteFinanceiro**)

#### Categorias
- `POST /api/categorias/sistema` - Criar categoria do sistema
- `POST /api/categorias/usuario` - Criar categoria de usuário
- `GET /api/categorias` - Listar categorias
- `GET /api/categorias/{id}` - Buscar categoria por ID
- `PATCH /api/categorias/{id}` - Atualizar categoria parcialmente
- `DELETE /api/categorias/{id}` - Excluir categoria

#### Transações
- `POST /api/transacoes` - Criar transação com rateios
- `GET /api/transacoes` - Listar transações
- `GET /api/transacoes/{id}` - Buscar transação por ID
- `PATCH /api/transacoes/{id}` - Atualizar transação parcialmente
- `DELETE /api/transacoes/{id}` - Excluir transação

### Swagger/OpenAPI
A documentação interativa está disponível após executar a aplicação:
- **URL local**: `https://localhost:7138/swagger`
- **Especificação OpenAPI**: Gerada automaticamente
- **Teste de endpoints**: Interface interativa para testes

## Tratamento de Erros

A API retorna códigos HTTP padronizados:

| Código | Significado | Exemplo |
|--------|-------------|---------|
| 200 | OK | Operação bem-sucedida |
| 201 | Created | Recurso criado com sucesso |
| 400 | Bad Request | Dados inválidos, regra de negócio violada ou ArgumentException |
| 401 | Unauthorized | Token JWT ausente ou inválido |
| 403 | Forbidden | Cargo sem permissão para o endpoint |
| 404 | Not Found | Recurso não encontrado |
| 500 | Internal Server Error | Erro interno do servidor |

**Formato de resposta de erro:**
```json
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "errors": {
    "Nome": [
      "O nome deve ter no mínimo 3 caracteres"
    ]
  }
}
```

## Histórico de versões

### [1.1.0] - 25/02/2026
#### Adicionado
- Sistema completo de autenticação JWT (registro + login)
- Hash de senhas com BCrypt (BCrypt.Net-Next 4.1.0)
- Autorização baseada em Cargo (RBAC) em todos os endpoints
- Suporte a múltiplos perfis (Cargo): Admin, GerenteFinanceiro, AnalistaFinanceiro, Contador, OperadorFinanceiro
- Módulo EntidadeFinanceira: Criar, Atualizar, Desativar, Reativar, AlterarTipo
- Módulo Credencial: repositório e serviço completos
- Endpoint `PATCH /entidadefinanceira/{id}/tipo` para alterar tipo da entidade com validações
- Token JWT gerado automaticamente ao registrar
- Swagger com suporte a Bearer token (botão Authorize)
- Value Object `Senha` com factory `DeHash()` para hashes BCrypt
- `IUsuarioAutenticado` lendo claims do HttpContext
- Registro automático de todas as dependências em `InjecaoDependencia.cs` e `Program.cs`

#### Corrigido
- `ArgumentException` → HTTP 400 (antes retornava 500)
- `DomainExeption` → HTTP 400 (antes estava mapeado como 404)
- Typo `"applicarion/json"` → `"application/json"` no middleware
- `WithMany()` no DbContext apontando para coleção `Usuarios`
- Lambda de mapeamento de `Senha` no DbContext (`senha.HasValue ? senha.Value.Valor : null`)
- Ordenação de validação no `UsuarioService.CriarAsync` (validar antes de persistir)

#### Segurança
- Senhas nunca armazenadas em texto puro
- Endpoints protegidos com `[Authorize]` e restrição por `Roles`
- JWT com expiração configurável (`Jwt:ExpiracaoHoras` no appsettings)

### [1.0.0] - 05/02/2026
#### Adicionado
- Implementação do Domain com entidades
- CRUD completo de Usuários
- CRUD completo de Categorias
- Cadastro de Transações com Rateio
- Configuração de Clean Architecture
- Documentação Swagger/OpenAPI
- Suporte a In-Memory Database para desenvolvimento

### [1.0.1] - 06/02/2026
#### Adicionado
- CRUD completo de Transações
- Validações adicionais nos usuários, impedindo caracteres especiais
- Validações adicionais nas categorias, impedindo caracteres especiais
- Melhorias no CRUD de Categorias
- Aprimoramentos no CRUD de Usuários

### [1.0.2] - 10/02/2026
#### Adicionado
- Implementação completa do CRUD de Transações com todos os endpoints
- Integração completa do sistema de Rateios com Transações
- Estrutura de DTOs para atualização (AtualizarCategoriaDto, AtualizarTransacaoDto)
- Suporte a PATCH para atualização parcial
- Sistema de múltiplos rateios por transação

#### Melhorias
- Estrutura de services e repositories completa para Transações
- Validação de soma dos rateios = valor total (implementada)
- Tratamento de exceções melhorado (BadRequest em vez de InternalServerError)
- Mensagens de erro descritivas e padronizadas

#### Corrigido
- Status HTTP adequados para cada tipo de erro
- Validação de integridade referencial (usuários e categorias)
- Atualização cascata de rateios ao modificar transação
- Validação de nomes duplicados em categorias

#### Testes
- ✅ 49 casos de teste executados e aprovados (100%)
- ✅ Cobertura completa de CREATE e UPDATE
- ✅ Testes de validação de dados e regras de negócio
- ✅ Testes de atualização parcial (PATCH)

#### Pendente
- Implementação de autenticação JWT
- Testes unitários automatizados
- Filtros e paginação nas listagens
- Implementação de soft delete
- Deploy em ambiente de produção
- Relatórios e dashboard
- Upload de anexos (notas fiscais)

## Próximas Melhorias

- [x] Autenticação e autorização (JWT) ✅ v1.1.0
- [ ] CredencialController (alterar email/senha pelo usuário)
- [ ] Migração de InMemory para SQL Server (Migrations)
- [ ] Testes unitários automatizados
- [ ] Soft delete
- [ ] Logs estruturados
- [ ] Cache de dados
- [ ] Filtros e paginação nas listagens
- [ ] Validação de CPF
- [ ] Upload de anexos
- [ ] Relatórios financeiros
- [ ] Dashboard com gráficos
- [ ] OAuth via Google (GoogleId em Credencial)

## Licença

Este projeto está sob a licença MIT.

## Contribuidores

- Gabriel Henrique - Desenvolvimento e Testes