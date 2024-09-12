using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDeleteController : ControllerBase
    {
        [HttpDelete("{name}")]
        public IActionResult DeleteUser(string name)
        {
           int UserIndex = UserManager.SearchIdByName(name);
           UserManager.users.RemoveAt(UserIndex);
           return Ok($"User '{name}' has been deleted.");
        }
    }   
}
