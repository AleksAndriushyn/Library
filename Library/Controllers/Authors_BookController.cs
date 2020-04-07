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
    public class Authors_BookController : Controller
    {
        private readonly LibraryContext _context;

        public Authors_BookController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Authors_Book
        public async Task<IActionResult> Index()
        {
            return View(await _context.Authors_Books.ToListAsync());
        }

        // GET: Authors_Book/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors_Book = await _context.Authors_Books
                .FirstOrDefaultAsync(m => m.id == id);
            if (authors_Book == null)
            {
                return NotFound();
            }

            return View(authors_Book);
        }

        // GET: Authors_Book/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Authors_Book/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,firstName,lastName,book_title")] Authors_Book authors_Book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authors_Book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(authors_Book);
        }

        // GET: Authors_Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors_Book = await _context.Authors_Books.FindAsync(id);
            if (authors_Book == null)
            {
                return NotFound();
            }
            return View(authors_Book);
        }

        // POST: Authors_Book/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,firstName,lastName,book_title")] Authors_Book authors_Book)
        {
            if (id != authors_Book.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(authors_Book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Authors_BookExists(authors_Book.id))
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
            return View(authors_Book);
        }

        // GET: Authors_Book/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors_Book = await _context.Authors_Books
                .FirstOrDefaultAsync(m => m.id == id);
            if (authors_Book == null)
            {
                return NotFound();
            }

            return View(authors_Book);
        }

        // POST: Authors_Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authors_Book = await _context.Authors_Books.FindAsync(id);
            _context.Authors_Books.Remove(authors_Book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Authors_BookExists(int id)
        {
            return _context.Authors_Books.Any(e => e.id == id);
        }
    }
}
