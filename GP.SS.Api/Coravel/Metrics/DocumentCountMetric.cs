using System.Threading.Tasks;
using Coravel.Pro.Features.Metrics;
using GP.SS.Database;
using Microsoft.EntityFrameworkCore;

namespace GP.SS.Api.Coravel.Metrics
{
    public class DocumentCountMetric : IMetricCard
    {
        private readonly SaldeoSynchronizatorContext _context;

        public DocumentCountMetric(SaldeoSynchronizatorContext context)
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
            var count = await _context.Documents.CountAsync();

            Value = $"{count} dokumentów";
            Title = "Ilość dokumentów";
            IsPositiveMetric = true;
            IncludeArrow = true;
        }
    }
}