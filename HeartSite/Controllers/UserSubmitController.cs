﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace HeartSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSubmitController : ControllerBase
    {
        //todo: px create controller for filter user info data 
        [HttpPost]
        public IActionResult UserSubmit([FromQuery] User userinfo)
        {
            UserManager.users.Add(userinfo);
            return Ok($"{userinfo.Name} {userinfo.Age}");
        }
        
    }
}
