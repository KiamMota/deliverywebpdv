using Domain.Core.Entities;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra.Data.Repositories.Base
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        /* isso aqui é uma factory, ele é necessário para o migrations do ef. */
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
        #region ModelRules
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* PEDIDO */
            modelBuilder.Entity<Pedido>
            (
                PedidoFields => PedidoFields.HasKey(p => p.Id)
            );
        }
        #endregion
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
