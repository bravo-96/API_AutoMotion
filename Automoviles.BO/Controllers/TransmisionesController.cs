using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Automoviles.DataAccess;
using Automoviles.Models.Entities;

namespace Automoviles.BO.Controllers
{
    public class TransmisionesController : Controller
    {
        private readonly AutoDbContext _context;

        public TransmisionesController(AutoDbContext context)
        {
            _context = context;
        }

        // GET: Transmisiones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transmision.ToListAsync());
        }

        // GET: Transmisiones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transmision = await _context.Transmision
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transmision == null)
            {
                return NotFound();
            }

            return View(transmision);
        }

        // GET: Transmisiones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transmisiones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TransmisionDTO transmision)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transmision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transmision);
        }

        // GET: Transmisiones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transmision = await _context.Transmision.FindAsync(id);
            if (transmision == null)
            {
                return NotFound();
            }
            return View(transmision);
        }

        // POST: Transmisiones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TransmisionDTO transmision)
        {
            if (id != transmision.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transmision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransmisionExists(transmision.Id))
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
            return View(transmision);
        }

        // GET: Transmisiones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transmision = await _context.Transmision
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transmision == null)
            {
                return NotFound();
            }

            return View(transmision);
        }

        // POST: Transmisiones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transmision = await _context.Transmision.FindAsync(id);
            _context.Transmision.Remove(transmision);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransmisionExists(int id)
        {
            return _context.Transmision.Any(e => e.Id == id);
        }
    }
}
