using CoFinanceControl.Application.Categorias.Services;
using CoFinanceControl.Application.EntidadeFinanceiraApp.Services;
using CoFinanceControl.Application.Transacoes.Services;
using CoFinanceControl.Application.Usuarios.Services;
using CoFinanceControl.Infrastructure.Extensions;
using CoFinanceControl.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Registrar App
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ITransacaoService, TransacaoService>();
builder.Services.AddScoped<IEntidadeFinanceiraService, EntidadeFinanceiraService>();

//Registrar Infra
builder.Services.AddInfrastructure(builder.Configuration);

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlerMiddleware>();
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.MapControllers();
app.Run();
