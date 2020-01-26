using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValidacionCFDI.Models;

namespace ValidacionCFDI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValidarCFDIController : ControllerBase
    {
        [HttpPost]
        public IEnumerable<string> PostJsonString([FromBody] Response request)
        {
            return new string[] { "value1", "value2" };
        }

    }
}
