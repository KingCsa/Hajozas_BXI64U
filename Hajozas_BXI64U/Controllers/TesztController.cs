using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hajozas_BXI64U.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();

            return Ok(pontosIdő);
        }

        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult M2(string szoveg)
        {
            return Ok(szoveg.ToUpper());
        }
    };
}
