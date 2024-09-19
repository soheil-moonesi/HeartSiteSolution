using HeartSite.DAL;
using HeartSite.TestClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeartSite.Controllers.TestController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonTestController : ControllerBase
    {
        private readonly TestDataBase _context;

        // Constructor injection for DbContext
        public PersonTestController(TestDataBase context)
        {
            _context = context;
        }
      
            [HttpGet]
            public async Task<ActionResult<IEnumerable<PersonTest>>> GetPersonTests()
            {
                // Fetch the data from the database
                var data = await _context.PersonTests.ToListAsync();
                return Ok(data);
            }

        }
    
}
