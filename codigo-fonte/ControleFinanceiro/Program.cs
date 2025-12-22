using ControleFinanceiro.Infrastructure;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(configuracao => configuracao.UseNpgsql(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

app.UseHttpsRedirection();


app.Run();
