using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Hello";
        }   



    }
}
