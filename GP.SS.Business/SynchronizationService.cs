using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GP.SS.Database;
using GP.SS.Domain;
using GP.SS.Infrastructure.SaldeoSmart;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GP.SS.Business
{
    public class SynchronizationService : ISynchronizationService
    {
        private readonly ISaldeoSmartFacade _saldeoSmartFacade;
        private readonly IMapper _mapper;

        private readonly DbContextOptionsBuilder<SaldeoSynchronizatorContext> _optionsBuilder;

        public SynchronizationService(ISaldeoSmartFacade saldeoSmartFacade, IMapper mapper, IOptions<ConnectionStrings> connectionStringsOptions)
        {
            _saldeoSmartFacade = saldeoSmartFacade;
            _mapper = mapper;

            _optionsBuilder = new DbContextOptionsBuilder<SaldeoSynchronizatorContext>();
            _optionsBuilder.UseOracle(connectionStringsOptions.Value.SaldeoSynchronizatorDB);
        }

        public async Task SyncCompaniesFromSaldeo()
        {
            var result = await _saldeoSmartFacade.GetCompanies();

            if (!result.Success)
            {
                throw new Exception($"Get companies from Saldeo failed - {result.ErrorDescription}");
            }

            var entityCompanies = _mapper.Map<IEnumerable<Company>>(result.ResultObject.Companies);

            using (var context = new SaldeoSynchronizatorContext(_optionsBuilder.Options))
            {
                context.Companies.AddOrUpdate(entityCompanies);
                await context.SaveChangesAsync();
            }
            //_context.Companies.AddOrUpdate(entityCompanies);
            //await _context.SaveChangesAsync();
        }

        public async Task SyncContractorsFromSaldeo()
        {
            //var failed = false;
            //var errorMsg = new StringBuilder();

            //var companies = await _context.Companies
            //    .Where(x => x.CompanyProgramId != null)
            //    .ToListAsync();

            //foreach (var company in companies)
            //{
            //    var result = await _saldeoSmartFacade.GetContractors(company.CompanyProgramId);

            //    if (!result.Success)
            //    {
            //        errorMsg.AppendLine($"Sync contractors failed for company ID: {company.Id} ({company.CompanyProgramId}) - {result.ErrorDescription}");
            //        failed = true;
            //        continue;
            //    }

            //    var entityContractors = _mapper.Map<List<Contractor>>(result.ResultObject.Contractors);

            //    entityContractors.ForEach(c => c.CompanyId = company.Id);

            //    _context.Contractors.AddOrUpdate(entityContractors);
            //    await _context.SaveChangesAsync();
            //}

            //if (failed)
            //{
            //    throw new Exception(errorMsg.ToString());
            //}
        }

        public async Task SyncDocumentsFromSaldeo()
        {
            //var failed = false;
            //var errorMsg = new StringBuilder();

            //var companies = await _context.Companies
            //    .Where(x => x.CompanyProgramId != null)
            //    .ToListAsync();

            //foreach (var company in companies)
            //{
            //    var result = await _saldeoSmartFacade.GetDocuments(company.CompanyProgramId);

            //    if (!result.Success)
            //    {
            //        errorMsg.AppendLine($"Sync documents failed for company ID: {company.Id} ({company.CompanyProgramId}) - {result.ErrorDescription}");
            //        failed = true;
            //        continue;
            //    }

            //    var entityDocuments = _mapper.Map<List<Document>>(result.ResultObject.DocumentsList);

            //    foreach (var entityDocument in entityDocuments)
            //    {
            //        var contractorId = result.ResultObject.DocumentsList.Single(x => x.DocumentId == entityDocument.Id).Contractor.ContractorId;
            //        var contractor = result.ResultObject.ContractorsList.Single(x => x.ContractorId == contractorId);

            //        entityDocument.ContractorFullName = contractor.FullName;
            //        entityDocument.ContractorShortName = contractor.ShortName;
            //        entityDocument.ContractorVatNumber = contractor.VatNumber;
            //        entityDocument.ContractorCity = contractor.City;
            //        entityDocument.ContractorStreet = contractor.Street;
            //        entityDocument.ContractorPostcode = contractor.Postcode;
            //        entityDocument.ContractorTelephone = contractor.Telephone;
            //        entityDocument.ContractorIsSupplier = contractor.IsSupplier;
            //        entityDocument.ContractorIsCustomer = contractor.IsCustomer;
            //    }

            //    entityDocuments.ForEach(x => x.CompanyId = company.Id);
                
            //    _context.Documents.AddRange(entityDocuments);
            //    await _context.SaveChangesAsync();
            //}

            //if (failed)
            //{
            //    throw new Exception(errorMsg.ToString());
            //}
        }
    }
}