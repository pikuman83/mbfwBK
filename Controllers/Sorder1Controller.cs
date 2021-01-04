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
    public class Sorder1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Sorder1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Sorder1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sorder1>>> GetSorder1s()
        {
            return await _context.Sorder1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Sorder1s.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        // GET: api/Sorder1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sorder1>> GetSorder1(int id)
        {
            var sorder1 = await _context.Sorder1s.FindAsync(id);

            if (sorder1 == null)
            {
                return NotFound();
            }

            return sorder1;
        }

        // POST: api/Sorder1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sorder1>> PostSorder1(Sorder1 sorder1)
        {
            _context.Sorder1s.Add(sorder1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Sorder1Exists(sorder1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSorder1s", new { id = sorder1.No }, sorder1);
        }

        // DELETE: api/Sorder1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSorder1(int id)
        {
            var sorder1 = await _context.Sorder1s.FindAsync(id);
            if (sorder1 == null)
            {
                return NotFound();
            }

            _context.Sorder1s.Remove(sorder1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Sorder1Exists(int id)
        {
            return _context.Sorder1s.Any(e => e.No == id);
        }
    }
}
