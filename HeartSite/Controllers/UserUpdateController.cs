using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserUpdateController : ControllerBase
    {
        //todo: p3 create plan for getting index and updating user data
        [HttpPost]
        public IActionResult UserUpdate([FromBody] User userinfo)
        {
            UserManager.users[0] = userinfo;
            return Ok($"{userinfo.Name} {userinfo.Age}");
        }   
    }
}
