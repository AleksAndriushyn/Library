using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Controllers
{
    public class Readers_CardController : Controller
    {
        private readonly LibraryContext _context;

        public Readers_CardController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Readers_Card
        public async Task<IActionResult> Index()
        {
            return View(await _context.Readers_Cards.ToListAsync());
        }

        // GET: Readers_Card/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readers_Card = await _context.Readers_Cards
                .FirstOrDefaultAsync(m => m.ID == id);
            if (readers_Card == null)
            {
                return NotFound();
            }

            return View(readers_Card);
        }

        // GET: Readers_Card/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Readers_Card/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,firstName,lastName,date,book_title")] Readers_Card readers_Card)
        {
            if (ModelState.IsValid)
            {
                _context.Add(readers_Card);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(readers_Card);
        }

        // GET: Readers_Card/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readers_Card = await _context.Readers_Cards.FindAsync(id);
            if (readers_Card == null)
            {
                return NotFound();
            }
            return View(readers_Card);
        }

        // POST: Readers_Card/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,firstName,lastName,date,book_title")] Readers_Card readers_Card)
        {
            if (id != readers_Card.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(readers_Card);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Readers_CardExists(readers_Card.ID))
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
            return View(readers_Card);
        }

        // GET: Readers_Card/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readers_Card = await _context.Readers_Cards
                .FirstOrDefaultAsync(m => m.ID == id);
            if (readers_Card == null)
            {
                return NotFound();
            }

            return View(readers_Card);
        }

        // POST: Readers_Card/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var readers_Card = await _context.Readers_Cards.FindAsync(id);
            _context.Readers_Cards.Remove(readers_Card);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Readers_CardExists(int id)
        {
            return _context.Readers_Cards.Any(e => e.ID == id);
        }
    }
}
