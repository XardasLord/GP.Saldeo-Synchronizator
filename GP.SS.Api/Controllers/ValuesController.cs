using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GP.SS.Business;
using Microsoft.AspNetCore.Mvc;

namespace GP.SS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
	    private readonly ISynchronizationService _synchronizationService;

	    public ValuesController(ISynchronizationService synchronizationService)
	    {
		    _synchronizationService = synchronizationService;
	    }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            await _synchronizationService.SyncCompaniesFromSaldeo();
            await _synchronizationService.SyncContractorsFromSaldeo();
            await _synchronizationService.SyncDocumentsFromSaldeo();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
