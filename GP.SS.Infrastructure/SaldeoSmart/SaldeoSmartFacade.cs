using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GP.SS.Common;
using GP.SS.Infrastructure.SaldeoSmart.Configuration;
using GP.SS.Infrastructure.SaldeoSmart.Helpers;
using GP.SS.Infrastructure.SaldeoSmart.ResponseDto;
using GP.SS.Infrastructure.SaldeoSmart.ResponseModels;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Serialization.Xml;

namespace GP.SS.Infrastructure.SaldeoSmart
{
    public class SaldeoSmartFacade : ISaldeoSmartFacade
    {
        private readonly IOptions<SaldeoSmartSettings> _saldeoSmartSettings;
        private readonly ISaldeoSmartAuthorizationHelper _saldeoSmartAuthorizationHelper;

        public SaldeoSmartFacade(IOptions<SaldeoSmartSettings> saldeoSmartSettings, ISaldeoSmartAuthorizationHelper saldeoSmartAuthorizationHelper)
        {
            _saldeoSmartSettings = saldeoSmartSettings;
            _saldeoSmartAuthorizationHelper = saldeoSmartAuthorizationHelper;
        }

        public async Task<ResponseDto<CompaniesDto>> GetCompanies()
        {
            var client = new RestClient(_saldeoSmartSettings.Value.ApiUrl);
            var request = new RestRequest(_saldeoSmartSettings.Value.GetCompaniesResource, Method.GET);

            var requestId = Guid.NewGuid().ToString();
            var parameters = new Dictionary<string, string>
            {
                { "username", _saldeoSmartSettings.Value.Username },
                { "req_id", requestId }
            };
            var signatureHash = _saldeoSmartAuthorizationHelper.GenerateRequestSignatureHash(parameters, _saldeoSmartSettings.Value.ApiKey);

            request.AddParameter("req_id", requestId);
            request.AddParameter("username", _saldeoSmartSettings.Value.Username);
            request.AddParameter("req_sig", signatureHash);

            client.UseDotNetXmlSerializer();

            var response = await client.ExecuteTaskAsync<CompaniesResponse>(request);

            if (response.Data == null)
            {
                return new ResponseDto<CompaniesDto>(false, "Response Data is null");
            }

            if (response.Data.Status != "OK")
            {
                return new ResponseDto<CompaniesDto>(false, response.Data.Status);
            }

            return new ResponseDto<CompaniesDto>(true,
                new CompaniesDto()
                {
                    Companies = response.Data.Companies.Company
                });
        }

        public async Task<ResponseDto<ContractorsDto>> GetContractors(string companyProgramId)
        {
            var client = new RestClient(_saldeoSmartSettings.Value.ApiUrl);
            var request = new RestRequest(_saldeoSmartSettings.Value.GetContractorsResource, Method.GET);

            var requestId = Guid.NewGuid().ToString();
            var parameters = new Dictionary<string, string>
            {
                { "username", _saldeoSmartSettings.Value.Username },
                { "req_id", requestId },
                { "company_program_id", companyProgramId }
            };
            var signatureHash = _saldeoSmartAuthorizationHelper.GenerateRequestSignatureHash(parameters, _saldeoSmartSettings.Value.ApiKey);

            request.AddParameter("company_program_id", companyProgramId);
            request.AddParameter("req_id", requestId);
            request.AddParameter("username", _saldeoSmartSettings.Value.Username);
            request.AddParameter("req_sig", signatureHash);

            client.UseDotNetXmlSerializer();

            var response = await client.ExecuteTaskAsync<ContractorsResponse>(request);

            if (response.Data == null)
            {
                return new ResponseDto<ContractorsDto>(false, "Response Data is null");
            }

            if (response.Data.Status != "OK")
            {
                return new ResponseDto<ContractorsDto>(false, response.Data.Status);
            }

            return new ResponseDto<ContractorsDto>(true,
                new ContractorsDto
                {
                    Contractors = response.Data.Contractors.ContractorsList
                });
        }

        public async Task<ResponseDto<DocumentsDto>> GetDocuments(string companyProgramId)
        {
            var client = new RestClient(_saldeoSmartSettings.Value.ApiUrl);
            var request = new RestRequest(_saldeoSmartSettings.Value.GetDocumentsResource, Method.GET);

            var requestId = Guid.NewGuid().ToString();
            var parameters = new Dictionary<string, string>
            {
                { "username", _saldeoSmartSettings.Value.Username },
                { "req_id", requestId },
                { "company_program_id", companyProgramId },
                { "policy", "LAST_10_DAYS" }
            };
            var signatureHash = _saldeoSmartAuthorizationHelper.GenerateRequestSignatureHash(parameters, _saldeoSmartSettings.Value.ApiKey);

            request.AddParameter("company_program_id", companyProgramId);
            request.AddParameter("req_id", requestId);
            request.AddParameter("username", _saldeoSmartSettings.Value.Username);
            request.AddParameter("req_sig", signatureHash);
            request.AddParameter("policy", "LAST_10_DAYS");

            client.UseDotNetXmlSerializer();

            var response = await client.ExecuteTaskAsync<DocumentsResponse>(request);

            if (response.Data == null)
            {
                return new ResponseDto<DocumentsDto>(false, "Response Data is null");
            }

            if (response.Data.Status != "OK")
            {
                return new ResponseDto<DocumentsDto>(false, response.Data.Status);
            }

            return new ResponseDto<DocumentsDto>(true);
            throw new NotImplementedException();
            //return new ResponseDto<DocumentsDto>(true,
            //    new DocumentsDto
            //    {
            //        Contractors = response.Data.Contractors.ContractorsList
            //    });
        }
    }
}