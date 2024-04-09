using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmitEasy.API.Controllers
{
    [Route("api/acesso")]
    [ApiController]
    public class AcessoController: ControllerBase
    {

        [HttpGet]
        [Authorize]
        public IActionResult Get() 
        {
            return Ok("Acesso Permitido!");
        }
    }
}
