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
    }
}