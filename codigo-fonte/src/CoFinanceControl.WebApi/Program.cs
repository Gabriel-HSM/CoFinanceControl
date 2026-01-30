using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Application.Usuarios.Services;
using CoFinanceControl.Infrastructure.Data;
using CoFinanceControl.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Conexão com banco
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CoFinanceDbContext>(options => options.UseNpgsql(connectionString));

//Registrar App + infra
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>(); 

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.MapControllers();
app.Run();
