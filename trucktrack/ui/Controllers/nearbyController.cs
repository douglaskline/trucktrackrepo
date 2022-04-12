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
    public class nearbyController : Controller
    {
        private readonly trucktrackContext _context;

        public nearbyController(trucktrackContext context)
        {
            _context = context;
        }

        // GET: truck
        public async Task<IActionResult> Index()
        {
            return View(await _context.trucks.ToListAsync());
        }       
}
}
