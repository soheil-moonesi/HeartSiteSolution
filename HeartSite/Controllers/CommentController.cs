﻿using HeartSite.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeartSite.Controllers
{

    //todo: p1 Rest all Database because Tables is not sync with structure
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly HeartSiteDataBase _heartSiteDataBase;

        public CommentController(DbContextOptions<HeartSiteDataBase> options)
        {
            _heartSiteDataBase = new HeartSiteDataBase(options);
        }

        [HttpPost]
        public IActionResult AddComment([FromBody] Comment comment)
        {
            _heartSiteDataBase.Comments.Add(comment);
            _heartSiteDataBase.SaveChanges();
            return Ok(comment);
        }
    }
}   
        









