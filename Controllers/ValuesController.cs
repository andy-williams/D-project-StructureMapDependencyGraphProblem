using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace StructureMapDependencyGraph.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IBService _bService;

        public ValuesController(IBService bService)
        {
            _bService = bService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
