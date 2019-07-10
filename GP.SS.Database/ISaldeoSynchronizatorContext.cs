using Microsoft.EntityFrameworkCore.Infrastructure;

namespace GP.SS.Database
{
    public interface ISaldeoSynchronizatorContext
    {
        DatabaseFacade Database { get; }
    }
}