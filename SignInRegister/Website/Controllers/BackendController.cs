using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Website.Controllers
{
    public class BackendController : Controller
    {
        public BackendController()
        {

        }

        public IActionResult Index()
        {
            var five = 5;

            var ten = five * 2;


            return View();
        }

    }
}
