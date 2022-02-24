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

        // GET: truck/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: truck/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("truckId,truckName,homeCity,homeState,foodStyle,priceRange,tagLine,truckURL,timeStamp")] truck truck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(truck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(truck);
        }

        // GET: truck/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truck = await _context.trucks.FindAsync(id);
            if (truck == null)
            {
                return NotFound();
            }
            return View(truck);
        }

        // POST: truck/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("truckId,truckName,homeCity,homeState,foodStyle,priceRange,tagLine,truckURL,timeStamp")] truck truck)
        {
            if (id != truck.truckId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(truck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!truckExists(truck.truckId))
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
            return View(truck);
        }

        // GET: truck/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: truck/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var truck = await _context.trucks.FindAsync(id);
            _context.trucks.Remove(truck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool truckExists(int id)
        {
            return _context.trucks.Any(e => e.truckId == id);
        }
    }
}
