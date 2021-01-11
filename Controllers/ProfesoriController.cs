using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProiectMaster3.Data;
using ProiectMaster3.Models;
using ProiectMaster3.Models.FacultateViewModels;

namespace ProiectMaster3.Controllers
{
    public class ProfesoriController : Controller
    {
        private readonly ContextFacultate _context;

        public ProfesoriController(ContextFacultate context)
        {
            _context = context;
        }

        // GET: Profesori
        public async Task<IActionResult> Index(int? id, string searchString)
        {

            ViewData["CurrentFilter"] = searchString;
            var viewModel = new ProfesorIndexData();
            viewModel.Profesori = await _context.Profesori
                             .Include(i => i.Cursuri)
                             .Include(i => i.Carti)
                             .AsNoTracking()
                             .ToListAsync();
            if (id != null)
            {
                ViewData["CursID"] = id.Value;
                Profesor profesor = viewModel.Profesori.Where(
                i => i.ID == id.Value).Single();
                viewModel.Cursuri = profesor.Cursuri;
                viewModel.Carti = profesor.Carti;
            }

            return View(viewModel);
        }

        // GET: Profesori/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesori
                .FirstOrDefaultAsync(m => m.ID == id);
            if (profesor == null)
            {
                return NotFound();
            }

            return View(profesor);
        }

        // GET: Profesori/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profesori/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nume,Prenume,Email")] Profesor profesor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profesor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profesor);
        }

        // GET: Profesori/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesori.FindAsync(id);
            if (profesor == null)
            {
                return NotFound();
            }
            return View(profesor);
        }

        // POST: Profesori/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nume,Prenume,Email")] Profesor profesor)
        {
            if (id != profesor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesorExists(profesor.ID))
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
            return View(profesor);
        }

        // GET: Profesori/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesori
                .FirstOrDefaultAsync(m => m.ID == id);
            if (profesor == null)
            {
                return NotFound();
            }

            return View(profesor);
        }

        // POST: Profesori/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profesor = await _context.Profesori.FindAsync(id);
            _context.Profesori.Remove(profesor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesorExists(int id)
        {
            return _context.Profesori.Any(e => e.ID == id);
        }
    }
}
