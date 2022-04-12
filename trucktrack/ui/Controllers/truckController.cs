using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dal;

namespace ui.Controllers
{
    public class truckController : Controller
    {
        private readonly trucktrackContext _context;

        public truckController(trucktrackContext context)
        {
            _context = context;
        }

        // GET: truck
        public async Task<IActionResult> Index()
        {
            return View(await _context.trucks.ToListAsync());
        }

        public IActionResult Index2(double? latitude, double? longitude)
        {
            return View();
        }
        // GET: truck/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truck = await _context.trucks
                .FirstOrDefaultAsync(m => m.truckId == id);
            if (truck == null)
            {
                return NotFound();
            }

            return View(truck);
        }

        

        

        

        

      

        
    }
}
