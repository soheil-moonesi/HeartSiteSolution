using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGetController : ControllerBase
    {
        //todo: px error handelling for client input
        //todo: p1 create structure for filter user names with words

        [HttpGet("GetByName/{name}")]
        //[HttpGet("{index}/{detail}")]  //template for getting more info from route
        public IActionResult UserGet([FromRoute]string name)
        {
           var UserIndex = UserManager.SearchIdByName(name);

            return Ok(UserManager.users[UserIndex].Age);
        }

        [HttpGet("GetAll/all")]
        public IActionResult AllUserGet()
        {
          return  Ok(UserManager.users);
        }

        [HttpGet("FilterByWord/{word}")]
        public IActionResult UserFilter([FromRoute]string word)
        {
           UserManager.UserNameFilterByWords(word);
           return Ok(UserManager.users);
        }

    }
}
