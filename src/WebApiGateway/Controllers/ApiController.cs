using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGateway.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
