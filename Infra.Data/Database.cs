using Domain.Core.Entities;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra.Data.Database
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            string connectionString = "server=localhost;port=3306;database=sevenvirtual;user=appuser;password=1234";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            return new AppDbContext(optionsBuilder.Options);

        }
    }
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Core.Entities.User> Users { get; set; }
        public DbSet<Domain.Core.Entities.Pedido> pedidos { get; set; }
        public DbSet<Domain.Core.Entities.Estabelecimento> estabelecimentos { get; set; }

        #region ModelRules
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* USER */
            modelBuilder.Entity<User>
            (
                UserFields =>
                {
                    UserFields.HasKey(f => f.Id);
                    UserFields.Property(f => f.Email).IsRequired();
                }
            );
            /* PEDIDO */
            modelBuilder.Entity<Pedido>
            (
                PedidoFields => PedidoFields.HasKey(p => p.pedidoId)
            );
            /* ESTABELECIMENTO */
            modelBuilder.Entity<Estabelecimento>
            (
                EstabelecimentoFields => EstabelecimentoFields.HasKey(e => e.estabId)
            );
        }
        #endregion
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
