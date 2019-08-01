using System.Threading.Tasks;
using Coravel.Pro.Features.Metrics;
using GP.SS.Database;
using Microsoft.EntityFrameworkCore;

namespace GP.SS.Api.Coravel.Metrics
{
    public class CompanyCountMetric : IMetricCard
    {
        private readonly SaldeoSynchronizatorContext _context;

        public CompanyCountMetric(SaldeoSynchronizatorContext context)
        {
            _context = context;
        }

        public string Value { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public bool IsPositiveMetric { get; set; }
        public bool IncludeArrow { get; set; }

        public async Task ExecuteAsync()
        {
            var count = await _context.Companies.CountAsync();

            Value = $"{count} firm";
            Title = "Ilość firm";
            IsPositiveMetric = true;
            IncludeArrow = true;
        }
    }
}
