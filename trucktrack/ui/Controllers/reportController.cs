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
    public class reportController : Controller
    {
        private readonly trucktrackContext _context;

        public reportController(trucktrackContext context)
        {
            _context = context;
        }

        // GET: report
        public async Task<IActionResult> Index()
        {
            var trucktrackContext = _context.reports.Include(r => r.location).Include(r => r.truck).Include(r => r.user);
            return View(await trucktrackContext.ToListAsync());
        }

        // GET: report/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.reports
                .Include(r => r.location)
                .Include(r => r.truck)
                .Include(r => r.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // GET: report/Create
        public IActionResult Create()
        {
            ViewData["locationId"] = new SelectList(_context.locations, "locationId", "locationName");
            ViewData["truckId"] = new SelectList(_context.trucks, "truckId", "foodStyle");
            ViewData["userId"] = new SelectList(_context.users, "Id", "email");
            return View();
        }

        // POST: report/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,reportTime,truckId,locationId,startTime,endTime,userId,timeStamp")] report report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(report);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["locationId"] = new SelectList(_context.locations, "locationId", "locationName", report.locationId);
            ViewData["truckId"] = new SelectList(_context.trucks, "truckId", "foodStyle", report.truckId);
            ViewData["userId"] = new SelectList(_context.users, "Id", "email", report.userId);
            return View(report);
        }

        // GET: report/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.reports.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }
            ViewData["locationId"] = new SelectList(_context.locations, "locationId", "locationName", report.locationId);
            ViewData["truckId"] = new SelectList(_context.trucks, "truckId", "foodStyle", report.truckId);
            ViewData["userId"] = new SelectList(_context.users, "Id", "email", report.userId);
            return View(report);
        }

        // POST: report/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,reportTime,truckId,locationId,startTime,endTime,userId,timeStamp")] report report)
        {
            if (id != report.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!reportExists(report.Id))
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
            ViewData["locationId"] = new SelectList(_context.locations, "locationId", "locationName", report.locationId);
            ViewData["truckId"] = new SelectList(_context.trucks, "truckId", "foodStyle", report.truckId);
            ViewData["userId"] = new SelectList(_context.users, "Id", "email", report.userId);
            return View(report);
        }

        // GET: report/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.reports
                .Include(r => r.location)
                .Include(r => r.truck)
                .Include(r => r.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // POST: report/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var report = await _context.reports.FindAsync(id);
            _context.reports.Remove(report);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool reportExists(int id)
        {
            return _context.reports.Any(e => e.Id == id);
        }
    }
}
