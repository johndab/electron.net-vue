using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace electron.net_vue.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet("hello")]
        public IActionResult Index()
        {
            return StatusCode(200, new { message = "Hello World!" });
        }
    }
}
