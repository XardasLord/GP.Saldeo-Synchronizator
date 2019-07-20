using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GP.SS.Database;
using GP.SS.Domain;
using GP.SS.Infrastructure.SaldeoSmart;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GP.SS.Business
{
    public class SynchronizationService : ISynchronizationService
    {
        private readonly ISaldeoSmartFacade _saldeoSmartFacade;
        private readonly ISaldeoSynchronizatorContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<SynchronizationService> _logger;

        public SynchronizationService(ISaldeoSmartFacade saldeoSmartFacade, ISaldeoSynchronizatorContext context, IMapper mapper, ILogger<SynchronizationService> logger)
        {
            _saldeoSmartFacade = saldeoSmartFacade;
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task SyncCompaniesFromSaldeo()
        {
            var result = await _saldeoSmartFacade.GetCompanies();

            if (!result.Success)
            {
                _logger.LogError($"Get companies from Saldeo failed - {result.ErrorDescription}");
                return;
            }

            if (result.ResultObject.Companies is null)
            {
                _logger.LogError("There is no companies in Saldeo");
                return;
            }

            _logger.LogInformation($"Companies from Saldeo count: {result.ResultObject.Companies.Length}");

            var entityCompanies = _mapper.Map<IEnumerable<Company>>(result.ResultObject.Companies);

            _context.Companies.AddOrUpdate(entityCompanies);
            await _context.SaveChangesAsync();
        }

        public async Task SyncContractorsFromSaldeo()
        {
            var failed = false;
            var errorMsg = new StringBuilder();

            var companies = await _context.Companies
                .Where(x => x.CompanyProgramId != null)
                .ToListAsync();

            foreach (var company in companies)
            {
                var result = await _saldeoSmartFacade.GetContractors(company.CompanyProgramId);

                if (!result.Success)
                {
                    errorMsg.AppendLine($"Sync contractors failed for company ID {company.Id} ({company.CompanyProgramId}) - {result.ErrorDescription}");
                    failed = true;
                    continue;
                }

                if (result.ResultObject.Contractors is null)
                {
                    _logger.LogInformation($"There is no contractors for company ID: {company.Id} ({company.CompanyProgramId}) in Saldeo");
                    continue;
                }

                _logger.LogInformation($"Contractors count from Saldeo for company ID {company.Id} ({company.CompanyProgramId}): {result.ResultObject.Contractors.Length}");

                var entityContractors = _mapper.Map<List<Contractor>>(result.ResultObject.Contractors);

                entityContractors.ForEach(c => c.CompanyId = company.Id);

                _context.Contractors.AddOrUpdate(entityContractors);
                await _context.SaveChangesAsync();
            }

            if (failed)
            {
                _logger.LogError(errorMsg.ToString());
            }
        }

        public async Task SyncDocumentsFromSaldeo()
        {
            var failed = false;
            var errorMsg = new StringBuilder();

            var companies = await _context.Companies
                .Where(x => x.CompanyProgramId != null)
                .ToListAsync();

            foreach (var company in companies)
            {
                var result = await _saldeoSmartFacade.GetDocuments(company.CompanyProgramId);

                if (!result.Success)
                {
                    errorMsg.AppendLine($"Sync documents failed for company ID: {company.Id} ({company.CompanyProgramId}) - {result.ErrorDescription}");
                    failed = true;
                    continue;
                }

                if (result.ResultObject.DocumentsList is null)
                {
                    _logger.LogInformation($"There is no documents for company ID: {company.Id} ({company.CompanyProgramId}) in Saldeo");
                    continue;
                }

                _logger.LogInformation($"Documents count from Saldeo for company ID {company.Id} ({company.CompanyProgramId}): {result.ResultObject.DocumentsList.Length}");

                var entityDocuments = _mapper.Map<List<Document>>(result.ResultObject.DocumentsList);

                foreach (var entityDocument in entityDocuments)
                {
                    var contractorId = result.ResultObject.DocumentsList.Single(x => x.DocumentId == entityDocument.Id).Contractor?.ContractorId;
                    var contractor = contractorId is null ? null : result.ResultObject.ContractorsList.Single(x => x.ContractorId == contractorId);

                    entityDocument.ContractorFullName = contractor?.FullName;
                    entityDocument.ContractorShortName = contractor?.ShortName;
                    entityDocument.ContractorVatNumber = contractor?.VatNumber;
                    entityDocument.ContractorCity = contractor?.City;
                    entityDocument.ContractorStreet = contractor?.Street;
                    entityDocument.ContractorPostcode = contractor?.Postcode;
                    entityDocument.ContractorTelephone = contractor?.Telephone;
                    entityDocument.ContractorIsSupplier = contractor?.IsSupplier ?? false;
                    entityDocument.ContractorIsCustomer = contractor?.IsCustomer ?? false;
                }

                entityDocuments.ForEach(x => x.CompanyId = company.Id);

                foreach (var entityDocument in entityDocuments)
                {
                    if (await _context.Documents.AnyAsync(x => x.Id == entityDocument.Id) == false)
                    {
                        _context.Documents.Add(entityDocument);
                    }
                }
                
                await _context.SaveChangesAsync();
            }

            if (failed)
            {
                _logger.LogError(errorMsg.ToString());
            }
        }
    }
}