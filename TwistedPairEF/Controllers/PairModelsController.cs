using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TwistedPairEF.Data;
using TwistedPairEF.Models;

namespace TwistedPairEF.Controllers
{
    //[Authorize]
    public class PairModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PairModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PairModels
        public async Task<IActionResult> Index()
        {
              return _context.PairsModel != null ? 
                          View(await _context.PairsModel.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PairsModel'  is null.");
        }

        // GET: PairModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PairsModel == null)
            {
                return NotFound();
            }

            var pairModel = await _context.PairsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pairModel == null)
            {
                return NotFound();
            }

            return View(pairModel);
        }

        // GET: PairModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PairModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PairNumber,FirstColor,SecondColor,FirstBinderColor,SecondBinderColor")] PairModel pairModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pairModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pairModel);
        }

        // GET: PairModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PairsModel == null)
            {
                return NotFound();
            }

            var pairModel = await _context.PairsModel.FindAsync(id);
            if (pairModel == null)
            {
                return NotFound();
            }
            return View(pairModel);
        }

        // POST: PairModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PairNumber,FirstColor,SecondColor,FirstBinderColor,SecondBinderColor")] PairModel pairModel)
        {
            if (id != pairModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pairModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PairModelExists(pairModel.Id))
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
            return View(pairModel);
        }

        // GET: PairModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PairsModel == null)
            {
                return NotFound();
            }

            var pairModel = await _context.PairsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pairModel == null)
            {
                return NotFound();
            }

            return View(pairModel);
        }

        // POST: PairModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PairsModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PairsModel'  is null.");
            }
            var pairModel = await _context.PairsModel.FindAsync(id);
            if (pairModel != null)
            {
                _context.PairsModel.Remove(pairModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PairModelExists(int id)
        {
          return (_context.PairsModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
