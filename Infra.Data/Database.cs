using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;


namespace Infra.Data.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Core.Entities.Pedido> pedidos { get; set; }
        public DbSet<Domain.Core.Entities.Estabelecimento> estabelecimentos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}
    }
}
