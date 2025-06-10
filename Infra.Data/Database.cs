using Domain.Core.Entities.Pedido;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;


namespace Infra.Data.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Core.Entities.Pedido.Domain> Pedidos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}
    }
}
