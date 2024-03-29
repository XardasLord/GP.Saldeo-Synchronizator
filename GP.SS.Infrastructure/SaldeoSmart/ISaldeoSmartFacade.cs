﻿using System.Threading.Tasks;
using GP.SS.Common;
using GP.SS.Infrastructure.SaldeoSmart.ResponseDto;

namespace GP.SS.Infrastructure.SaldeoSmart
{
    public interface ISaldeoSmartFacade
    {
	    Task<ResponseDto<CompaniesDto>> GetCompanies();
        Task<ResponseDto<ContractorsDto>> GetContractors(string companyProgramId);
        Task<ResponseDto<DocumentsDto>> GetDocuments(string companyProgramId);
        Task SetCompanyProgramId(string companyId, string companyProgramIdToSet);
    }
}