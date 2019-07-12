using GP.SS.Domain;
using Microsoft.EntityFrameworkCore;

namespace GP.SS.Database
{
    public class SaldeoSynchronizatorContext : DbContext, ISaldeoSynchronizatorContext
    {
        public SaldeoSynchronizatorContext(DbContextOptions<SaldeoSynchronizatorContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}