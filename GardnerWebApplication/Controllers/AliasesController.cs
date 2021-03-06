using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GardnerWebApplication.Data;
using GardnerWebApplication.Models;

namespace GardnerWebApplication.Controllers
{
    public class AliasesController : Controller
    {
        private readonly GardnerWebApplicationContext _context;

        public AliasesController(GardnerWebApplicationContext context)
        {
            _context = context;
        }

        // GET: Aliases
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alias.ToListAsync());
        }

        // GET: Aliases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @alias = await _context.Alias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@alias == null)
            {
                return NotFound();
            }

            return View(@alias);
        }

        // GET: Aliases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aliases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AliasName,FirstName,LastName")] Alias @alias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@alias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@alias);
        }

        // GET: Aliases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @alias = await _context.Alias.FindAsync(id);
            if (@alias == null)
            {
                return NotFound();
            }
            return View(@alias);
        }

        // POST: Aliases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AliasName,FirstName,LastName")] Alias @alias)
        {
            if (id != @alias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@alias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AliasExists(@alias.Id))
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
            return View(@alias);
        }

        // GET: Aliases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @alias = await _context.Alias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@alias == null)
            {
                return NotFound();
            }

            return View(@alias);
        }

        // POST: Aliases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @alias = await _context.Alias.FindAsync(id);
            _context.Alias.Remove(@alias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AliasExists(int id)
        {
            return _context.Alias.Any(e => e.Id == id);
        }
    }
}
