using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserUpdateController : ControllerBase
    {
        [HttpPost]
        public IActionResult UserUpdate([FromBody] User userinfo)
        {
           int UserIndex =  UserManager.SearchIdByName(userinfo.Name);

            UserManager.users[UserIndex] = userinfo;

            return Ok($"{userinfo.Name} {userinfo.Age}");
        }   
    }
}
