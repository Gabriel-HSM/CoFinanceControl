using CoFinanceControl.Application.Usuarios.Services;
using CoFinanceControl.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Registrar App
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
//Registrar Infra
builder.Services.AddInfrastructure(builder.Configuration);

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.MapControllers();
app.Run();
