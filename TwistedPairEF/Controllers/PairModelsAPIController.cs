﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TwistedPairEF.Data;
using TwistedPairEF.Models;

namespace TwistedPairEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PairModelsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PairModelsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PairModelsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PairModel>>> GetPairsModel()
        {
          if (_context.PairsModel == null)
          {
              return NotFound();
          }
            return await _context.PairsModel.ToListAsync();
        }

        // GET: api/PairModelsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PairModel>> GetPairModel(int id)
        {
          if (_context.PairsModel == null)
          {
              return NotFound();
          }
            var pairModel = await _context.PairsModel.FindAsync(id);

            if (pairModel == null)
            {
                return NotFound();
            }

            return pairModel;
        }

        // PUT: api/PairModelsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPairModel(int id, PairModel pairModel)
        {
            if (id != pairModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(pairModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PairModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PairModelsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PairModel>> PostPairModel(PairModel pairModel)
        {
          if (_context.PairsModel == null)
          {
              return Problem("Entity set 'ApplicationDbContext.PairsModel'  is null.");
          }
            _context.PairsModel.Add(pairModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPairModel", new { id = pairModel.Id }, pairModel);
        }

        // DELETE: api/PairModelsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePairModel(int id)
        {
            if (_context.PairsModel == null)
            {
                return NotFound();
            }
            var pairModel = await _context.PairsModel.FindAsync(id);
            if (pairModel == null)
            {
                return NotFound();
            }

            _context.PairsModel.Remove(pairModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PairModelExists(int id)
        {
            return (_context.PairsModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}