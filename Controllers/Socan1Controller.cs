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
    public class Socan1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Socan1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Socan1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Socan1>>> GetSocan1s()
        {
            return await _context.Socan1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
            int maxNo = await _context.Socan1s.MaxAsync(x => (int?)x.No) ?? 0;
            return Ok(maxNo);
        }

        // GET: api/Socan1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Socan1>> GetSocan1(int id)
        {
            var socan1 = await _context.Socan1s.FindAsync(id);

            if (socan1 == null)
            {
                return NotFound();
            }

            return socan1;
        }

        // POST: api/Socan1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Socan1>> PostSocan1(Socan1 socan1)
        {
            _context.Socan1s.Add(socan1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Socan1Exists(socan1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSocan1s", new { id = socan1.No }, socan1);
        }

        // DELETE: api/Socan1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocan1(int id)
        {
            var socan1 = await _context.Socan1s.FindAsync(id);
            if (socan1 == null)
            {
                return NotFound();
            }

            _context.Socan1s.Remove(socan1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Socan1Exists(int id)
        {
            return _context.Socan1s.Any(e => e.No == id);
        }
    }
}
