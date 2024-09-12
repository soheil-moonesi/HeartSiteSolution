using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //todo: px create structure for first login and then activate routs for that user
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }   
    }
}
