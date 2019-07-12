using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GP.SS.Database;
using GP.SS.Domain;
using GP.SS.Infrastructure.SaldeoSmart;

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

            // TODO: Add or Update
            _context.Companies.AddRange(entityCompanies);
            await _context.SaveChangesAsync();
        }

        public async Task SyncContractorsFromSaldeo()
        {
            var contractors = await _saldeoSmartFacade.GetContractors();

            // TODO: Update DB
        }
    }
}