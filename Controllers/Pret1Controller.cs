using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mbfwAPI.Models;

namespace mbfwAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pret1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Pret1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Pret1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pret1>>> GetPret1s()
        {
            return await _context.Pret1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Pret1s.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        // GET: api/Pret1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pret1>> GetPret1(int id)
        {
            var pret1 = await _context.Pret1s.FindAsync(id);

            if (pret1 == null)
            {
                return NotFound();
            }

            return pret1;
        }

        // POST: api/Pret1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pret1>> PostPret1(Pret1 pret1)
        {
            _context.Pret1s.Add(pret1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Pret1Exists(pret1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPret1s", new { id = pret1.No }, pret1);
        }

        // DELETE: api/Pret1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePret1(int id)
        {
            var pret1 = await _context.Pret1s.FindAsync(id);
            if (pret1 == null)
            {
                return NotFound();
            }

            _context.Pret1s.Remove(pret1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Pret1Exists(int id)
        {
            return _context.Pret1s.Any(e => e.No == id);
        }
    }
}
