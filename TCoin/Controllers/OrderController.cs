using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TCoin.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return new JsonResult(new {name="igor",age=23 });
            //return View();
        }
        
    }
}