using Microsoft.EntityFrameworkCore;

namespace CoFinanceControl.Infrastructure.Data
{
    public class CoFinanceDbContext : DbContext
    {
        public CoFinanceDbContext(DbContextOptions<CoFinanceDbContext> options) : base(options)
        {
            
        }
    }
}