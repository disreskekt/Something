using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Something.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Something.API.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly Context _context;

        public TestController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("test")]
        public void Test()
        {
            _context.Users.ToList();
            _context.Users.Include(user => user.UserRole).ToList();
        }
    }
}
