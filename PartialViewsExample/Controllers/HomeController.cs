﻿using Microsoft.AspNetCore.Mvc;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>() { "Mumabi", "Pune" }; 
            return View();
        }
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
