using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// namespace is a grouping method for organization and scoping
namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //?name=mike
        public IActionResult About(string name, string lastname)
        {
            ViewData["Message"] = name + lastname;
			// ViewData["Message"] = lastname;

			//  /Home/About/?name=seth&lastname=harden

			return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
		public IActionResult Login()
		{
			ViewData["Message"] = "Your Login page.";

			return View();
		}

		public IActionResult Register(string first, string last)
		{
            ViewData["Message"] = "Your name is " + first;
            ViewData["More"] = "Your lastname is " + last;

			return View();
		}

        public IActionResult Error()
        {
            return View();
        }
    }
}
