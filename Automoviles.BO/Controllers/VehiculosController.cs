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
    public class VehiculosController : Controller
    {
        private readonly AutoDbContext _context;

        public VehiculosController(AutoDbContext context)
        {
            _context = context;
        }

        // GET: Vehiculos
        public async Task<IActionResult> Index()
        {
            var autoDbContext = _context.Vehiculos.Include(v => v.Color).Include(v => v.Combustible).Include(v => v.Marca).Include(v => v.Modelo).Include(v => v.Pais).Include(v => v.Seguro).Include(v => v.Tipo);
            return View(await autoDbContext.ToListAsync());
        }

        // GET: Vehiculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos
                .Include(v => v.Color)
                .Include(v => v.Combustible)
                .Include(v => v.Marca)
                .Include(v => v.Modelo)
                .Include(v => v.Pais)
                .Include(v => v.Seguro)
                .Include(v => v.Tipo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            return View(vehiculo);
        }

        // GET: Vehiculos/Create
        public IActionResult Create()
        {
            ViewData["ColorId"] = new SelectList(_context.Colores, "Id", "Nombre");
            ViewData["CombustibleId"] = new SelectList(_context.Combustibles, "Id", "Nombre");
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nombre");
            ViewData["ModeloId"] = new SelectList(_context.Set<ModeloDTO>(), "Id", "Nombre");
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre");
            ViewData["SeguroId"] = new SelectList(_context.Seguros, "Id", "Nombre");
            ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "Nombre");
            return View();
        }

        // POST: Vehiculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModeloId,PaisId,ColorId,CombustibleId,SeguroId,TipoId,Precio,anio,MarcaId")] VehiculoDTO vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ColorId"] = new SelectList(_context.Colores, "Id", "Nombre", vehiculo.ColorId);
            ViewData["CombustibleId"] = new SelectList(_context.Combustibles, "Id", "Nombre", vehiculo.CombustibleId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nombre", vehiculo.MarcaId);
            ViewData["ModeloId"] = new SelectList(_context.Set<ModeloDTO>(), "Id", "Nombre", vehiculo.ModeloId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", vehiculo.PaisId);
            ViewData["SeguroId"] = new SelectList(_context.Seguros, "Id", "Nombre", vehiculo.SeguroId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "Nombre", vehiculo.TipoId);
            return View(vehiculo);
        }

        // GET: Vehiculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }
            ViewData["ColorId"] = new SelectList(_context.Colores, "Id", "Nombre", vehiculo.ColorId);
            ViewData["CombustibleId"] = new SelectList(_context.Combustibles, "Id", "Nombre", vehiculo.CombustibleId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nombre", vehiculo.MarcaId);
            ViewData["ModeloId"] = new SelectList(_context.Set<ModeloDTO>(), "Id", "Nombre", vehiculo.ModeloId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", vehiculo.PaisId);
            ViewData["SeguroId"] = new SelectList(_context.Seguros, "Id", "Nombre", vehiculo.SeguroId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "Nombre", vehiculo.TipoId);
            return View(vehiculo);
        }

        // POST: Vehiculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModeloId,PaisId,ColorId,CombustibleId,SeguroId,TipoId,Precio,anio,MarcaId")] VehiculoDTO vehiculo)
        {
            if (id != vehiculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehiculoExists(vehiculo.Id))
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
            ViewData["ColorId"] = new SelectList(_context.Colores, "Id", "Nombre", vehiculo.ColorId);
            ViewData["CombustibleId"] = new SelectList(_context.Combustibles, "Id", "Nombre", vehiculo.CombustibleId);
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "Id", "Nombre", vehiculo.MarcaId);
            ViewData["ModeloId"] = new SelectList(_context.Set<ModeloDTO>(), "Id", "Nombre", vehiculo.ModeloId);
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", vehiculo.PaisId);
            ViewData["SeguroId"] = new SelectList(_context.Seguros, "Id", "Nombre", vehiculo.SeguroId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "Nombre", vehiculo.TipoId);
            return View(vehiculo);
        }

        // GET: Vehiculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos
                .Include(v => v.Color)
                .Include(v => v.Combustible)
                .Include(v => v.Marca)
                .Include(v => v.Modelo)
                .Include(v => v.Pais)
                .Include(v => v.Seguro)
                .Include(v => v.Tipo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            return View(vehiculo);
        }

        // POST: Vehiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculos.Any(e => e.Id == id);
        }
    }
}
