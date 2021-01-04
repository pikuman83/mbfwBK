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
    public class Pocan1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Pocan1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Pocan1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pocan1>>> GetPocan1s()
        {
            return await _context.Pocan1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Pocan1s.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        // GET: api/Pocan1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pocan1>> GetPocan1(int id)
        {
            var pocan1 = await _context.Pocan1s.FindAsync(id);

            if (pocan1 == null)
            {
                return NotFound();
            }

            return pocan1;
        }

        // POST: api/Pocan1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pocan1>> PostPocan1(Pocan1 pocan1)
        {
            _context.Pocan1s.Add(pocan1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Pocan1Exists(pocan1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPocan1s", new { id = pocan1.No }, pocan1);
        }

        // DELETE: api/Pocan1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePocan1(int id)
        {
            var pocan1 = await _context.Pocan1s.FindAsync(id);
            if (pocan1 == null)
            {
                return NotFound();
            }

            _context.Pocan1s.Remove(pocan1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Pocan1Exists(int id)
        {
            return _context.Pocan1s.Any(e => e.No == id);
        }
    }
}
