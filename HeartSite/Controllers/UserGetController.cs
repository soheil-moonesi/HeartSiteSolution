using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGetController : ControllerBase
    {
        [HttpGet]
        public IActionResult UserGet()
        {
            return Ok(UserManager.users[0].Name);
        }
    }
}
