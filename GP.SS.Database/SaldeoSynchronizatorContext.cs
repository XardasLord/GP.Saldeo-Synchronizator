using Microsoft.EntityFrameworkCore;

namespace GP.SS.Database
{
    public class SaldeoSynchronizatorContext : DbContext, ISaldeoSynchronizatorContext
    {
        protected SaldeoSynchronizatorContext(DbContextOptions<SaldeoSynchronizatorContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}