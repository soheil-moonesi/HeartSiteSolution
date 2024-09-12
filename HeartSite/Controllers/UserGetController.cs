﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGetController : ControllerBase
    {
        //todo: p1 create method for search and find user info by name
        //Todo: p2 create Plan for adding and getting User Data
        //todo: px error handelling for client input

        [HttpGet("{index}")]
        //[HttpGet("{index}/{detail}")]  //template for getting more info from route
        public IActionResult UserGet([FromRoute]string index)
        {
            
            return Ok(UserManager.users[int.Parse(index)].Name);
        }
    }
}
