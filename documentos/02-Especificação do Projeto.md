# Especificação do Projeto

## Perfis de Usuários

<br>
<table>
<tbody>
<tr align=center>
<th colspan="2">Perfil Usuário </th>
</tr>
<tr>
<td width="150px"><b>Descrição</b></td>
<td width="600px">Pessoa física que deseja controlar suas finanças pessoais</td>
</tr>
<tr>
<td><b>Necessidades</b></td>
<td>
- Registrar transações financeiras (receitas e despesas)<br>
- Organizar gastos por categorias<br>
- Dividir transações em múltiplas categorias (rateio)<br>
- Visualizar histórico de transações<br>
- Acompanhar para onde está indo seu dinheiro
</td>
</tr>
</tbody>
</table>

<br>

<table>
<tbody>
<tr align=center>
<th colspan="2">Perfil Administrador </th>
</tr>
<tr>
<td width="150px"><b>Descrição</b></td>
<td width="600px">Responsável pela gestão do sistema</td>
</tr>
<tr>
<td><b>Necessidades</b></td>
<td>
- Gerenciar categorias padrão do sistema<br>
- Configurar parâmetros globais<br>
- Visualizar relatórios gerenciais<br>
- Criar categorias padrão que todos os usuários podem usar
</td>
</tr>
</tbody>
</table>


## Histórias de Usuários

[Apresente aqui as histórias de usuários que são relevantes para o projeto da solução.]

> **Link Útil**:
> - [Como escrever boas histórias de usuário](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)

[Utilize o modelo de tabela abaixo para apresentar as histórias de usuários.]

|EU COMO... `QUEM`   | QUERO/PRECISO ... `O QUE` |PARA ... `PORQUE`                 |
|--------------------|---------------------------|----------------------------------|
| Usuário | Cadastrar minhas transações financeiras | Ter controle do que entra e sai da minha conta |
| Usuário | Criar categorias personalizadas | Organizar meus gastos de acordo com minha realidade |
| Usuário | Dividir uma transação em múltiplas categorias | Quando um gasto abrange diferentes áreas |
| Usuário | Visualizar histórico de transações | Consultar gastos anteriores e identificar padrões |
| Usuário | Atualizar ou excluir transações | Corrigir erros ou registros duplicados |
| Administrador | Gerenciar categorias padrão | Facilitar o uso inicial para novos usuários |

## Requisitos do Projeto

### Requisitos Funcionais

|ID    | Descrição                | Prioridade |
|-------|---------------------------------|----|
| RF-01 | O sistema deve permitir cadastro de usuários | Alta |
| RF-02 | O sistema deve permitir cadastro de categorias | Alta |
| RF-03 | O sistema deve permitir cadastro de transações | Alta |
| RF-04 | O sistema deve permitir rateio de transações entre múltiplas categorias | Alta |
| RF-05 | O sistema deve permitir visualização do histórico de transações | Alta |
| RF-06 | O sistema deve permitir atualização de transações | Média |
| RF-07 | O sistema deve permitir exclusão de transações | Média |
| RF-08 | O sistema deve permitir exclusão de categorias | Baixa |

### Requisitos não Funcionais

|ID      | Descrição               |Prioridade |
|--------|-------------------------|----|
| RNF-01 | O sistema deve responder requisições em até 2 segundos | Alta |
| RNF-02 | O sistema deve utilizar autenticação segura | Alta |
| RNF-03 | O sistema deve ser desenvolvido em .NET 8 | Alta |
| RNF-04 | O sistema deve usar banco de dados PostgreSQL | Média |
| RNF-05 | O sistema deve seguir princípios de Clean Architecture | Média |
| RNF-06 | A interface deve ser intuitiva e responsiva | Média |
