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

namespace GP.SS.Business
{
    public class SynchronizationService : ISynchronizationService
    {
        private readonly ISaldeoSmartFacade _saldeoSmartFacade;
        private readonly IMapper _mapper;
        private readonly ISaldeoSynchronizatorContext _context;

        public SynchronizationService(ISaldeoSmartFacade saldeoSmartFacade, IMapper mapper, ISaldeoSynchronizatorContext context)
        {
            _saldeoSmartFacade = saldeoSmartFacade;
            _mapper = mapper;
            _context = context;
        }

        public async Task SyncCompaniesFromSaldeo()
        {
            var result = await _saldeoSmartFacade.GetCompanies();

            if (!result.Success)
            {
                throw new Exception($"Get companies from Saldeo failed - {result.ErrorDescription}");
            }

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
                    errorMsg.AppendLine($"Sync contractors failed for company ID: {company.Id} ({company.CompanyProgramId}) - {result.ErrorDescription}");
                    failed = true;
                    continue;
                }

                var entityContractors = _mapper.Map<List<Contractor>>(result.ResultObject.Contractors);

                entityContractors.ForEach(c => c.CompanyId = company.Id);

                _context.Contractors.AddOrUpdate(entityContractors);
                await _context.SaveChangesAsync();
            }

            if (failed)
            {
                throw new Exception(errorMsg.ToString());
            }
        }
    }
}