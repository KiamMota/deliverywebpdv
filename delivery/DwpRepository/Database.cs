using Delivery.Web.Pdv.Core;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Web.Pdv.Database
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options) { }
        {



        }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
