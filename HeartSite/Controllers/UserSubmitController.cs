using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSubmitController : ControllerBase
    {
        //todo: it must use user class for getting user info and return submit string
        [HttpPost]
        public IActionResult UserSubmit([FromQuery] string name)
        {
            return Ok(name);
        }
    }
}
