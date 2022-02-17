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
    public class locationController : Controller
    {
        private readonly trucktrackContext _context;

        public locationController(trucktrackContext context)
        {
            _context = context;
        }

        // GET: location
        public async Task<IActionResult> Index()
        {
            return View(await _context.locations.ToListAsync());
        }

        // GET: location/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.locations
                .FirstOrDefaultAsync(m => m.locationId == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // GET: location/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: location/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("locationId,locationName,latitude,longitude,geocode,locationDescription,timeStamp")] location location)
        {
            if (ModelState.IsValid)
            {
                _context.Add(location);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        // GET: location/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }
            return View(location);
        }

        // POST: location/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("locationId,locationName,latitude,longitude,geocode,locationDescription,timeStamp")] location location)
        {
            if (id != location.locationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(location);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!locationExists(location.locationId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        // GET: location/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.locations
                .FirstOrDefaultAsync(m => m.locationId == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var location = await _context.locations.FindAsync(id);
            _context.locations.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool locationExists(int id)
        {
            return _context.locations.Any(e => e.locationId == id);
        }
    }
}
