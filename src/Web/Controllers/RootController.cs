using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class RootController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
