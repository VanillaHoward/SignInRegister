using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public List<User> Users { get; set; }
        public List<Entry> Entries { get; set; }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult SignInUser(long mobile)
        {
            var user = Users.FirstOrDefault(u => u.Number == mobile);

            if (user == null) return BadRequest();

            var newEntry = new Entry()
            {
                SignInTime = DateTimeOffset.Now,
                UserId = user.Id,
                Active = true
            };

            Entries.Add(newEntry);

            return null;
        }

        [HttpPost]
        public IActionResult SignOut(long mobile)
        {
            var user = Users.FirstOrDefault(u => u.Number == mobile);
            var entry = Entries.FirstOrDefault(u => u.UserId == user.Id);

            entry.Active = false;



            return null;
        }

        [HttpPost]
        public IActionResult RegisterUser(User user)
        {
            return null;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }

}