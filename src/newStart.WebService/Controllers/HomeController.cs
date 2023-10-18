using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travix.demo.WebService.Controllers
{
    // [controller] will be relaced by the controller name and [action] will be replaced by the method name
    [Route("api/[controller]")]
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("hello-cxl")]
        public IActionResult Hello()
        {
            return Ok("hello-cxl");
        }


        [HttpGet]
        [Route("hello-xxx")]
        public IActionResult Hello(string x)
        {
            return Ok($"hello-{x}");
        }

        [HttpGet]
        [Route("HomeView")]
        public IActionResult HomeView()
        {
            return View("Index");//the name is correspond with the View File Name
        }
    }
}