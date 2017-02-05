using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class RootController : Controller
    {
        [ActionName("index")]
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("about-this-site")]
        public IActionResult AboutThisSite(bool throwEx)
        {
            if (throwEx)
            {
                throw new Exception("Here's your exception.");
            }

            return View();
        }

        [ActionName("resume")]
        public IActionResult Resume()
        {
            return View();
        }

        [ActionName("error")]
        public IActionResult Error(int statusCode)
        {
            if(statusCode == 404) 
            {
                return View("page-not-found");
            }

            return View();
        }
    }
}
