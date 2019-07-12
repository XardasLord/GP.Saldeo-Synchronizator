﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GP.SS.Infrastructure.SaldeoSmart.Configuration;
using GP.SS.Infrastructure.SaldeoSmart.Helpers;
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

		public async Task<object> GetCompanies()
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

			throw new System.NotImplementedException();
		}

		public async Task<object> GetContractors()
		{
			var client = new RestClient(_saldeoSmartSettings.Value.ApiUrl);
			var request = new RestRequest(_saldeoSmartSettings.Value.GetContractorsResource, Method.GET);

			var requestId = Guid.NewGuid().ToString();
			var companyId = "SYMFONIA::ASPODATK";
			var parameters = new Dictionary<string, string>
			{
				{ "username", _saldeoSmartSettings.Value.Username },
				{ "req_id", requestId },
				{ "company_program_id", companyId }
			};
			var signatureHash = _saldeoSmartAuthorizationHelper.GenerateRequestSignatureHash(parameters, _saldeoSmartSettings.Value.ApiKey);

			request.AddParameter("company_program_id", companyId);
			request.AddParameter("req_id", requestId);
			request.AddParameter("username", _saldeoSmartSettings.Value.Username);
			request.AddParameter("req_sig", signatureHash);

			var response = await client.ExecuteTaskAsync(request);

			throw new System.NotImplementedException();
		}
	}
}