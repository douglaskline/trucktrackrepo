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

          public async Task<IActionResult> Index()
        {
            return View(await _context.locations.ToListAsync());
        }
        
        public async Task<ActionResult> Details(double? latitude, double? longitude)
        {
          if (latitude == null || longitude == null) 
          {
            return NotFound();
          }

          var location = await _context.locations
              .FirstOrDefaultAsync(m => m.longitude == longitude && m.latitude == latitude);

          if(location == null)
          {
            return NotFound();
          }
          return(View(location));
        }
        
    }
}
