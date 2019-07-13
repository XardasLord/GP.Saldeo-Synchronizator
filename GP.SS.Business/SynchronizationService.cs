using System;
using System.Collections.Generic;
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

            foreach (var company in entityCompanies)
            {
                if (await _context.Companies.AnyAsync(x => x.Id == company.Id))
                {
                    continue;
                }

                _context.Companies.Add(company);
            }

            await _context.SaveChangesAsync();
        }

        public async Task SyncContractorsFromSaldeo()
        {
            var contractors = await _saldeoSmartFacade.GetContractors();

            // TODO: Update DB
        }
    }
}