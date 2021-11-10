using controllermodelviewDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace controllermodelviewDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [ViewData]
        public string Title { get; set; }
        public IActionResult Index()
        {
            Title = "HomePage";

            return View();
        }

        public IActionResult AboutUs()
        {
            Title = "AbutusPage";

            return View();
        }

        public IActionResult ContactUs()
        {
            Title = "ContactusPage";
            return View();
        }
    }
}
