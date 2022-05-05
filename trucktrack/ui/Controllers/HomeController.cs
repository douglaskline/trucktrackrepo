using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using dal;

using ui.Models;

namespace ui.Controllers
{
    public class HomeController : Controller
    {

        private readonly trucktrackContext _context;



        public HomeController(trucktrackContext context)
        {
            _context = context;
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
            
            
            var model = new reportViewModel();

            List<truck> trucks =  await _context.trucks.ToListAsync();
            foreach (truck t in trucks){
                model.trucks.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(t.truckName,t.truckId.ToString()));
            }
            List<location> locations = await _context.locations.ToListAsync();
            model.locations.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem("unknown","-1"));
            foreach (location l in locations){
                model.locations.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(l.locationName,l.locationId.ToString()));
            }

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Report([BindAttribute("truckId, locationId, minutesLonger")] reportViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                dal.report r = new report();
                r.locationId = rvm.locationId;
                r.truckId = rvm.truckId;
                r.startTime = DateTime.Now;
                r.endTime = r.startTime.AddMinutes(rvm.minutesLonger);
                r.reportTime = r.startTime;
                
                _context.reports.Add(r);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Nearby));
            }
            return View(rvm);
            
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
