using System.Collections.Generic;
using System.Linq;
using GP.SS.Domain;
using Microsoft.EntityFrameworkCore;

namespace GP.SS.Database
{
    public static class DbContextExtensions
    {
        public static void AddOrUpdate<T>(this DbSet<T> dbSet, IEnumerable<T> records)
            where T : DomainEntityBase
        {
            foreach (var data in records)
            {
                var exists = dbSet.AsNoTracking().Any(x => x.Id == data.Id);
                if (exists)
                {
                    dbSet.Update(data);
                    continue;
                }

                dbSet.Add(data);
            }
        }
    }
}