using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DepositoDeBebidas.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class AcessController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public ActionResult Get() 
        {
            return Ok("Acess allow");
        }


    }
}
