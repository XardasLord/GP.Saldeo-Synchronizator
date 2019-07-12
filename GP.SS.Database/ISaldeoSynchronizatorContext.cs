using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using GP.SS.Domain;

namespace GP.SS.Database
{
    public interface ISaldeoSynchronizatorContext
    {
        DatabaseFacade Database { get; }

        DbSet<Company> Companies { get; set; }
    }
}