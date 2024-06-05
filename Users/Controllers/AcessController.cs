using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DepositoDeBebidas.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class AcessController : ControllerBase
    {
        [HttpGet]       
        //Create a policy to test the user
        public ActionResult Get() 
        {
            return Ok("Acess allow");
        }


    }
}
