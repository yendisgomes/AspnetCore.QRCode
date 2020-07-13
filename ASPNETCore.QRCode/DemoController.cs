using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.QRCode.Tags
{

    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("generate")]
        public IActionResult Generate(string content)
        {
            ViewBag.content = content;
            return View("Index");
        }
    }
}
