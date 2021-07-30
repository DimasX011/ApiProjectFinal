using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("api/metrics/ram/available/from/{ram_volume}")]
        public IActionResult GetMetricsFromRam([FromRoute] int ram_volume)
        {
            return Ok();
        }
    }
}
