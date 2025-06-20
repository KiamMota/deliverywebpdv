using Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql;

namespace Infra.Data.Database
{
    public class AppDbContext : DbContext
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var conectionString = "server=localhost/user=root;password=1234;database=sevenvirtual";
            services.AddDbContext<AppDbContext>(DbContextOptions =>
            DbContextOptions.UseMySql(conectionString, ServerVersion.AutoDetect(conectionString))
            );
        }
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
