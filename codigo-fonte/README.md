# Instruções de utilização

## Estrutura do Projeto

O projeto segue os princípios de **Clean Architecture**, com separação clara de responsabilidades em camadas:

```
codigo-fonte/
└─ src/
   ├─ CoFinanceControl.Domain/        # Entidades e Value Objects
   │  ├─ Models/
   │  │  ├─ Usuario/
   │  │  ├─ Categoria/
   │  │  ├─ Transacao/
   │  │  └─ Rateios/
   │
   ├─ CoFinanceControl.Application/   # Casos de uso, DTOs e contratos
   │  ├─ Usuarios/
   │  │  ├─ Services/
   │  │  ├─ DTOs/
   │  │  └─ Repositories/
   │  ├─ Categorias/
   │  ├─ Transacoes/
   │  └─ Rateios/
   │
   ├─ CoFinanceControl.Infrastructure/ # Repositórios e acesso a dados
   │  ├─ Data/
   │  │  └─ CoFinanceDbContext.cs
   │  ├─ Repositories/
   │  └─ Extensions/
   │     └─ InjecaoDependencia.cs
   │
   └─ CoFinanceControl.WebApi/         # Controllers e configuração da API
      ├─ Controllers/
      ├─ Program.cs
      └─ appsettings*.json
```

## Padrões e Convenções

| Padrões | Descrição | Implementação |
| --- | --- | --- |
| Arquitetura | Clean Architecture com DDD | Separação em Domain, Application, Infrastructure e WebApi |
| Versionamento de API | `/api/[controller]` | Preparado para versionamento futuro |
| Formato de resposta | `JSON` | Padronizado via controllers |
| Validação | Value Objects no Domain | Validações encapsuladas (ex: `PrimeiroNome`, `TransacaoValor`) |
| Persistência | Entity Framework Core | In-Memory para desenvolvimento, PostgreSQL para produção |
| Documentação | Swagger/OpenAPI | Disponível em `/swagger` |
| Injeção de Dependência | Nativa do .NET | Configurada em `InjecaoDependencia.cs` |

## Instalação da aplicação

**Pré-requisitos**

- .NET SDK 8.0 ou superior
- (Opcional) PostgreSQL para ambiente de produção
- (Opcional) Docker para containerização

**Execução local**

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/CoFinanceControl.git
cd CoFinanceControl/codigo-fonte
```

2. Restaure as dependências:
```bash
dotnet restore
```

3. Execute a aplicação:
```bash
cd src/CoFinanceControl.WebApi
dotnet run
```

4. Acesse o Swagger:
```
https://localhost:5001/swagger
```

**Configuração do Banco de Dados**

- **Desenvolvimento**: Utiliza In-Memory Database (configurado por padrão)
- **Produção**: Descomente as linhas no `InjecaoDependencia.cs` e configure a connection string no `appsettings.json`

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=cofinance;Username=seu_usuario;Password=sua_senha"
  }
}
```

**Execução remota**

- Provedores sugeridos: Azure App Service, Render, Railway, Fly.io
- Banco de dados: PostgreSQL (Supabase, ElephantSQL, Azure Database)
- URL pública: [insira aqui após a publicação]

## Módulos Implementados

| Módulo | Responsável | Status | Endpoints |
| --- | --- | --- | --- |
| Usuários | Gabriel Henrique | ✅ Concluído | POST, GET, PUT, DELETE `/api/Usuario` |
| Categorias | Gabriel Henrique | ✅ Concluído | POST, GET, PUT, DELETE `/api/Categoria` |
| Transações | Gabriel Henrique | 🚧 Em desenvolvimento | POST, GET `/api/Transacao` |
| Rateios | Gabriel Henrique | 🚧 Em desenvolvimento | Vinculado a Transações |

## Funcionalidades Principais

### 1. Gestão de Usuários
- Cadastro de usuários com validação de dados
- Value Objects: `PrimeiroNome`, `Sobrenome`, `DataNascimento`

### 2. Gestão de Categorias
- Categorias personalizadas por usuário
- Value Object: `CategoriaNome`

### 3. Gestão de Transações
- Registro de receitas e despesas
- Rateio de transações entre múltiplas categorias
- Value Objects: `TransacaoValor`, `TransacaoDescricao`

### 4. Sistema de Rateios
- Divisão proporcional de valores
- Value Objects: `ValorRateio`, `DestinoRateio`

## Testes

**Execução de testes** (quando implementados):
```bash
dotnet test
```

**Testes manuais via Swagger:**
1. Acesse `https://localhost:5001/swagger`
2. Execute os endpoints seguindo a ordem:
   - Criar Usuário
   - Criar Categoria
   - Criar Transação com Rateio

## Documentação da API

A documentação completa está disponível via Swagger após executar a aplicação:
- **URL local**: `https://localhost:5001/swagger`
- **Especificação OpenAPI**: Gerada automaticamente

## Histórico de versões

### [1.0.0] - 05/02/2026
#### Adicionado
- Implementação do Domain com Value Objects
- CRUD completo de Usuários
- CRUD completo de Categorias
- Cadastro de Transações com Rateio
- Configuração de Clean Architecture
- Documentação Swagger/OpenAPI
- Suporte a In-Memory Database para desenvolvimento

#### Pendente
- Implementação de autenticação JWT
- Endpoints de atualização e exclusão de Transações
- Validação de soma dos rateios
- Migrations para PostgreSQL
- Testes unitários e de integração