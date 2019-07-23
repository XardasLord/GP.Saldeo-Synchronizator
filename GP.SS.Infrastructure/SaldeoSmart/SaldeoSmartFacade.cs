using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
        private const string SaldeoPolicy = "SALDEO";

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
                    Companies = response.Data.Companies?.Company
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
                    Contractors = response.Data.Contractors?.ContractorsList
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
                { "policy", SaldeoPolicy }
            };
            var signatureHash = _saldeoSmartAuthorizationHelper.GenerateRequestSignatureHash(parameters, _saldeoSmartSettings.Value.ApiKey);

            request.AddParameter("company_program_id", companyProgramId);
            request.AddParameter("req_id", requestId);
            request.AddParameter("username", _saldeoSmartSettings.Value.Username);
            request.AddParameter("req_sig", signatureHash);
            request.AddParameter("policy", SaldeoPolicy);

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

            return new ResponseDto<DocumentsDto>(true,
                new DocumentsDto
                {
                    ContractorsList = response.Data.Contractors?.ContractorsList,
                    DocumentsList = response.Data.Documents?.DocumentsList
                });
        }

        public async Task SetCompanyProgramId(string companyId, string companyProgramIdToSet)
        {
            var client = new RestClient(_saldeoSmartSettings.Value.ApiUrl);
            var request = new RestRequest("api/xml/1.0/company/synchronize", Method.POST);

            var xmlCommand = $"<?xml version='1.0' encoding='UTF-8' standalone='no' ?><ROOT><COMPANIES><COMPANY><COMPANY_ID>{companyId}</COMPANY_ID><COMPANY_PROGRAM_ID>{companyProgramIdToSet}</COMPANY_PROGRAM_ID></COMPANY></COMPANIES></ROOT>";
            var outputBase64 = CompressGzipAndBase64(xmlCommand);

            var requestId = Guid.NewGuid().ToString();
            var parameters = new Dictionary<string, string>
            {
                { "username", _saldeoSmartSettings.Value.Username },
                { "req_id", requestId },
                { "command", outputBase64 }
            };
            var signatureHash = _saldeoSmartAuthorizationHelper.GenerateRequestSignatureHash(parameters, _saldeoSmartSettings.Value.ApiKey);

            request.AddParameter("command", outputBase64);
            request.AddParameter("req_id", requestId);
            request.AddParameter("username", _saldeoSmartSettings.Value.Username);
            request.AddParameter("req_sig", signatureHash);

            var response = await client.ExecuteTaskAsync(request);
        }

        private static string CompressGzipAndBase64(string xmlCommand)
        {
            string outputBase64;

            byte[] inputBytes = Encoding.UTF8.GetBytes(xmlCommand);

            using (var outputStream = new MemoryStream())
            {
                using (var gZipStream = new GZipStream(outputStream, CompressionMode.Compress))
                    gZipStream.Write(inputBytes, 0, inputBytes.Length);

                var outputBytes = outputStream.ToArray();

                outputBase64 = Convert.ToBase64String(outputBytes);
            }

            return outputBase64;
        }
    }
}