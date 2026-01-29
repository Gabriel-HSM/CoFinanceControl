using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Application.Usuarios.Services;
using CoFinanceControl.Infrastructure.Data;
using CoFinanceControl.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Registrar App + infra
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>(); 

//Conexão com banco
builder.Services.AddDbContext<CoFinanceDbContext>(options =>
{

});

var app = builder.Build();

//Swagger
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.MapControllers();
app.Run();
