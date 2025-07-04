using Infra.Data.DataModels;
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
            string connectionString = "server=localhost;port=3306;database=deliverypdv;user=appuser;password=1234";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            return new AppDbContext(optionsBuilder.Options);
        }
    }
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<EnderecoDb> Enderecos { get; set; }
    }
}
