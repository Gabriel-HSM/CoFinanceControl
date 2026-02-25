using CoFinanceControl.Application.Categorias.Repositories;
using CoFinanceControl.Application.EntidadeFinanceiraApp.Repositories;
using CoFinanceControl.Application.Transacoes.Repositories;
using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Infrastructure.Data;
using CoFinanceControl.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoFinanceControl.Infrastructure.Extensions
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // var connectionString = configuration.GetConnectionString("DefaultConnection");
            // services.AddDbContext<CoFinanceDbContext>(options => options.UseNpgsql(connectionString));


            services.AddDbContext<CoFinanceDbContext>(options => options.UseInMemoryDatabase("InMemory"));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ITransacaoRepository, TransacaoRepository>();
            services.AddScoped<IEntidadeFinanceiraRepository, EntidadeFinanceiraRepository>();

            return services;
        }
    }
}