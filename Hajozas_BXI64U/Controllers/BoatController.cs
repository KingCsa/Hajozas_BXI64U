using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hajozas_BXI64U.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/{sorszám}")]
        public ActionResult M1(int sorszám)
        {
            Models.HajosContext context = new Models.HajosContext();
            var kérdés = (from x in context.Questions where x.QuestionId == sorszám select x).FirstOrDefault();

            if (kérdés == null) return BadRequest("Nincs ilyen sorszámú kérdés");

            return Ok(kérdés);
        }

    }
}
