indice:
? = duvida de implementação
! = importante
- = lista
* = topicos futuros
✅ = implementado
⏳ = pendente

---

## Módulos Implementados (v1.1.0)

✅ Autentificação (JWT Bearer + BCrypt + RBAC)
✅ EntidadeFinanceira (Criar, Atualizar, Desativar, Reativar, AlterarTipo)
✅ Credencial (Email/Senha com BCrypt hash, OAuth preparado)
✅ JWT com claims: UsuarioId, EntidadeFinanceiraId, Cargo
✅ Autorização baseada em Cargo (Admin, GerenteFinanceiro, AnalistaFinanceiro, Contador, OperadorFinanceiro)
✅ Token gerado automaticamente no registro (POST /registrar)
✅ Middleware de exceções (400, 404, 500)

---

## Pendências

Usuario:
- ⏳ ObterUsuarioPorEmail
- ⏳ trim nos campos de texto

Categoria:
- ⏳ validação se possui numeros em Nome (verificar se faz sentido)
- ⏳ obter categorias por usuário
- ⏳ trim nos campos de texto

Transacao:
- ⏳ validações extras em Valor (além de > 0)
- ⏳ permitir descrição nula

Credencial:
- ⏳ GoogleId (OAuth via Google — futuro)
- ⏳ CredencialController (alterar email/senha pelo usuário autenticado)

Geral:
- ⏳ Testes unitários automatizados
- ⏳ Trim
- ⏳ Migrar de InMemory para SQL Server (Migrations)
- ⏳ Relatórios financeiros
- ⏳ Filtros e paginação nas listagens
- ⏳ Logs estruturados
- ⏳ Deploy em ambiente de produção