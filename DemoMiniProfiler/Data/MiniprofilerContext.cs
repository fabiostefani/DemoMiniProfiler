using DemoMiniProfiler.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMiniProfiler.Data
{
    public class MiniprofilerContext : DbContext
    {
        public MiniprofilerContext(DbContextOptions<MiniprofilerContext> dbContext)
            : base(dbContext)
        {

        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Item> Itens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MiniprofilerContext).Assembly);
        }
    }
}
