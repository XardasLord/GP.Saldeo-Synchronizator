using System.Threading.Tasks;
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

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentItem> DocumentItems { get; set; }
        public DbSet<DocumentVatRegistry> DocumentVatRegistries { get; set; }
    }
}