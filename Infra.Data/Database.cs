using Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;


namespace Infra.Data.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Core.Entities.User> Users { get; set; }
        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(UserFields =>
            {
                UserFields.HasKey(f =>  f.Id);
                UserFields.Property(f => f.Prop).IsRequired();
                UserFields.Property(f => f.Nome).IsRequired();
                UserFields.Property(f => f.Password).IsRequired();
            }
            );
        }
        #endregion

        public DbSet<Domain.Core.Entities.Pedido> pedidos { get; set; }
        public DbSet<Domain.Core.Entities.Estabelecimento> estabelecimentos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}
    }
}
