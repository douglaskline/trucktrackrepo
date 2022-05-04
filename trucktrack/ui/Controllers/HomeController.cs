using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

using ui.Models;

namespace ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(double? latitude, double? longitude)
        {
            return View();
        }

        public IActionResult Find(double? latitude, double? longitude)
        {
            return View();
        }

        public IActionResult Nearby(double? latitude, double? longitude)
        {
            return View();
        }
        
        // GET: home/Report/45.0/45.0

        public IActionResult GetLocation()
        {
            return View();
        }
        public  async Task<IActionResult> Report(double? latitude, double? longitude)
        {
            if (latitude == null | longitude == null)
            {
                return RedirectToAction(nameof(GetLocation));;
            }

            return View();
        }

        public IActionResult Truck(int? id, double? latitude, double? longitude)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
