using GP.SS.Infrastructure.SaldeoSmart.ResponseModels;

namespace GP.SS.Infrastructure.SaldeoSmart.ResponseDto
{
    public class DocumentsDto
    {
        public ContractorOnDocument[] ContractorsList { get; set; }
        public Document[] DocumentsList { get; set; }
    }
}