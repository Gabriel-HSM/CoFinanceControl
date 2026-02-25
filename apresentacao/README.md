# Apresentação do Projeto — CoFinance Control

## Conjunto de Slides

A apresentação do projeto consiste na geração de um conjunto de slides em um arquivo no formato ppt, pptx ou pdf, contemplando os seguintes itens:

> - Contexto (Problema, Público-alvo)
> - Requisitos
> - Solução Implementada (funcionalidades de software)
> - Conclusão da elaboração do projeto (pontos positivos, desafios, aprendizado).

**Tópicos sugeridos para os slides:**
1. Problema: controlar finanças pessoais e corporativas de forma centralizada e segura
2. Público-alvo: pessoas físicas (Solo/Família) e jurídicas (Empresa)
3. Solução: API RESTful com Clean Architecture, autenticação JWT, RBAC e múltiplos perfis por entidade financeira
4. Principais funcionalidades: Registro/Login, Transações, Categorias, Rateios, Entidade Financeira com tipos (Solo/Família/Empresa)
5. Stack técnica: .NET 8, ASP.NET Core, EF Core, BCrypt, JWT Bearer, Swagger

[Adicione pdf de apresentação.]

> **Links Úteis**:
> - [A regra 10-20-30 para apresentações de sucesso](https://revistapegn.globo.com/Noticias/noticia/2014/07/regra-10-20-30-para-apresentacoes-de-sucesso.html)
> - [Top Tips for Effective Presentations](https://www.skillsyouneed.com/present/presentation-tips.html)
> - [How to make a great presentation](https://www.ted.com/playlists/574/how_to_make_a_great_presentation)

## Vídeo de apresentação

A equipe também deverá gravar um vídeo de, no máximo, três minutos, com a apresentação da solução. Abrir a aplicação no Swagger (`https://localhost:7138/swagger`), demonstrar o fluxo completo:
1. `POST /api/Autentificacao/registrar` — criar conta e receber token
2. Autorizar no Swagger com o token recebido
3. `GET /api/entidadefinanceira` — visualizar dados da entidade
4. `POST /api/users` — adicionar usuário à entidade
5. `POST /api/transacoes` — registrar transação com rateio

> Especificações técnicas do vídeo:
> - tamanho do arquivo limitado a 90Mb
> - taxa de FPS limitada a 30 quadros por segundo
> - resolução HD (720p) ou Full HD (1080p)
> - formato mp4.

[Adicione vídeo de apresentação.]

## Hospedagem

[Adicione o endereço eletrônico público onde o site encontra-se hospedado.]
