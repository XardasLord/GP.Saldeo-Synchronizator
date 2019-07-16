using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using GP.SS.Domain;

namespace GP.SS.Database
{
    public interface ISaldeoSynchronizatorContext
    {
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync();

        DbSet<Company> Companies { get; set; }
        DbSet<Contractor> Contractors { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<DocumentItem> DocumentItems { get; set; }
        DbSet<DocumentVatRegistry> DocumentVatRegistries { get; set; }
    }
}