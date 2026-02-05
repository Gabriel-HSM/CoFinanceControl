# Metodologia

Esta seção descreve a organização para a execução das tarefas do projeto e as ferramentas utilizadas para a manutenção dos códigos e demais artefatos.

## Gerenciamento de Projeto

O projeto está sendo desenvolvido de forma individual, seguindo uma abordagem iterativa e incremental, com foco na entrega de um MVP (Minimum Viable Product) funcional.

### Divisão de Papéis

- **Desenvolvedor Full Stack**: Gabriel Henrique
  - Responsável por toda a implementação backend (.NET)
  - Responsável pela modelagem de dados e arquitetura
  - Responsável pela documentação técnica

### Processo

O desenvolvimento segue um fluxo simplificado utilizando GitHub Projects para organização das tarefas:

- **Backlog**: Lista de funcionalidades e melhorias identificadas para o projeto
- **To Do**: Tarefas planejadas para a sprint atual (1 semana - finalização do MVP)
- **In Progress**: Tarefas em desenvolvimento
- **Done**: Tarefas finalizadas e testadas

**Meta da Sprint Atual (1 semana)**: Finalizar MVP com funcionalidades básicas de cadastro e consulta de usuários, categorias e transações com rateio.

### Etiquetas

As tarefas são etiquetadas para facilitar a organização:

- **Bug** (Erro no código)
- **Feature** (Nova funcionalidade)
- **Documentation** (Documentação)
- **Refactor** (Refatoração de código)
- **Infrastructure** (Infraestrutura e configuração)
- **Tests** (Testes unitários)

### Ferramentas

Os artefatos do projeto são desenvolvidos utilizando as seguintes ferramentas:

| AMBIENTE                            | PLATAFORMA                         | LINK DE ACESSO                         |
|-------------------------------------|------------------------------------|----------------------------------------|
| Repositório de código fonte         | GitHub                             | https://github.com/usuario/CoFinanceControl |
| Documentos do projeto               | GitHub (pasta documentos)          | https://github.com/usuario/CoFinanceControl/tree/main/documentos |
| Gerenciamento do Projeto            | GitHub Projects                    | https://github.com/usuario/CoFinanceControl/projects |
| IDE de Desenvolvimento              | Visual Studio Code                 | -                                      |
| Testes de API                       | Swagger                    | -                                      |
| Banco de Dados (Dev)                | In-Memory / PostgreSQL             | -                                      |

### Estratégia de Organização de Codificação 

O projeto segue os princípios de **Clean Architecture**, com separação clara de responsabilidades:

```
codigo-fonte/
├── src/
│   ├── CoFinanceControl.Domain/        # Entidades e regras de negócio
│   ├── CoFinanceControl.Application/   # Casos de uso e DTOs
│   ├── CoFinanceControl.Infrastructure/# Repositórios e acesso a dados
│   └── CoFinanceControl.WebApi/        # Controladores e configuração da API
```

**Convenções adotadas**:
- Nomenclatura em português para domínio
- Padrão Repository para acesso a dados
- Value Objects para validações de domínio
- DTOs para comunicação entre camadas
- Injeção de dependência nativa do .NET