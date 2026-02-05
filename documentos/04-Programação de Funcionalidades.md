# Programação de Funcionalidades

Implementação da aplicação descritas por meio dos requisitos codificados. 

---

### Cadastro de Usuários

#### Requisito atendido

**RF-01**: O sistema deve permitir cadastro de usuários

#### Artefatos da funcionalidade

- `CoFinanceControl.Domain/Models/Usuario/Usuario.cs`
- `CoFinanceControl.Domain/Models/Usuario/ValueObjects/PrimeiroNome.cs`
- `CoFinanceControl.Domain/Models/Usuario/ValueObjects/Sobrenome.cs`
- `CoFinanceControl.Domain/Models/Usuario/ValueObjects/DataNascimento.cs`
- `CoFinanceControl.Application/Usuarios/DTOs/CriarUsuarioDto.cs`
- `CoFinanceControl.Application/Usuarios/DTOs/UsuarioDto.cs`
- `CoFinanceControl.Application/Usuarios/Services/UsuarioService.cs`
- `CoFinanceControl.Application/Usuarios/Repositories/IUsuarioRepository.cs`
- `CoFinanceControl.Infrastructure/Repositories/UsuarioRepository.cs`
- `CoFinanceControl.WebApi/Controllers/UsuarioController.cs`

#### Estrutura de Dados

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "nome": "Gabriel",
  "sobrenome": "Henrique",
  "dataNascimento": "2000-01-15"
}
```

#### Instruções de acesso

1. Execute a aplicação
2. Acesse o Swagger: `https://localhost:5001/swagger`
3. Localize o endpoint `POST /api/Usuario`
4. Clique em "Try it out"
5. Preencha o JSON com os dados do usuário
6. Execute a requisição

#### Responsável

Gabriel Henrique

---

### Cadastro de Categorias

#### Requisito atendido

**RF-02**: O sistema deve permitir cadastro de categorias

#### Artefatos da funcionalidade

- `CoFinanceControl.Domain/Models/Categoria/Categoria.cs`
- `CoFinanceControl.Domain/Models/Categoria/ValueObjects/CategoriaNome.cs`
- `CoFinanceControl.Application/Categorias/DTOs/CriarCategoriaDto.cs`
- `CoFinanceControl.Application/Categorias/DTOs/CategoriaDto.cs`
- `CoFinanceControl.Application/Categorias/Services/CategoriaService.cs`
- `CoFinanceControl.Application/Categorias/Repositories/ICategoriaRepository.cs`
- `CoFinanceControl.Infrastructure/Repositories/CategoriaRepository.cs`
- `CoFinanceControl.WebApi/Controllers/CategoriaController.cs`

#### Estrutura de Dados

```json
{
  "id": 1,
  "usuarioId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "nome": "Alimentação"
}
```

#### Instruções de acesso

1. Execute a aplicação
2. Acesse o Swagger: `https://localhost:5001/swagger`
3. Localize o endpoint `POST /api/Categoria`
4. Clique em "Try it out"
5. Preencha o JSON com os dados da categoria
6. Execute a requisição

#### Responsável

Gabriel Henrique

---

### Cadastro de Transações com Rateio

#### Requisito atendido

**RF-03**: O sistema deve permitir cadastro de transações  
**RF-04**: O sistema deve permitir rateio de transações entre múltiplas categorias

#### Artefatos da funcionalidade

- `CoFinanceControl.Domain/Models/Transacao/Transacao.cs`
- `CoFinanceControl.Domain/Models/Transacao/ValueObjects/TransacaoValor.cs`
- `CoFinanceControl.Domain/Models/Transacao/ValueObjects/TransacaoDescricao.cs`
- `CoFinanceControl.Domain/Models/Rateios/Rateio.cs`
- `CoFinanceControl.Domain/Models/Rateios/ValueObjects/DestinoRateio.cs`
- `CoFinanceControl.Domain/Models/Rateios/ValueObjects/ValorRateio.cs`
- `CoFinanceControl.Application/Transacoes/DTOs/CriarTransacaoDto.cs`
- `CoFinanceControl.Application/Transacoes/DTOs/TransacaoDto.cs`
- `CoFinanceControl.Application/Rateios/DTOs/RateioDto.cs`
- `CoFinanceControl.Application/Transacoes/Services/TransacaoService.cs`
- `CoFinanceControl.Application/Transacoes/Repositories/ITransacaoRepository.cs`
- `CoFinanceControl.Infrastructure/Repositories/TransacaoRepository.cs`
- `CoFinanceControl.WebApi/Controllers/TransacaoController.cs`

#### Estrutura de Dados

```json
{
  "usuarioId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "valorTotal": 150.50,
  "descricao": "Compras do mercado",
  "rateios": [
    {
      "categoriaId": 1,
      "destino": "Alimentação básica",
      "valor": 100.00
    },
    {
      "categoriaId": 2,
      "destino": "Produtos de limpeza",
      "valor": 50.50
    }
  ]
}
```

#### Instruções de acesso

1. Execute a aplicação
2. Acesse o Swagger: `https://localhost:5001/swagger`
3. Localize o endpoint `POST /api/Transacao`
4. Clique em "Try it out"
5. Preencha o JSON com os dados da transação e rateios
6. Execute a requisição

#### Responsável

Gabriel Henrique

---

### Consulta de Transações

#### Requisito atendido

**RF-05**: O sistema deve permitir visualização do histórico de transações

#### Artefatos da funcionalidade

- `CoFinanceControl.Application/Transacoes/Services/TransacaoService.cs`
- `CoFinanceControl.Infrastructure/Repositories/TransacaoRepository.cs`
- `CoFinanceControl.WebApi/Controllers/TransacaoController.cs`

#### Estrutura de Dados

```json
[
  {
    "id": 1,
    "usuarioId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "valorTotal": 150.50,
    "descricao": "Compras do mercado",
    "dataCriacao": "2026-02-05T10:30:00Z",
    "rateios": [
      {
        "categoriaId": 1,
        "destino": "Alimentação básica",
        "valor": 100.00
      }
    ]
  }
]
```

#### Instruções de acesso

1. Execute a aplicação
2. Acesse o Swagger: `https://localhost:5001/swagger`
3. Localize o endpoint `GET /api/Transacao`
4. Clique em "Try it out"
5. Execute a requisição para listar todas as transações

#### Responsável

Gabriel Henrique