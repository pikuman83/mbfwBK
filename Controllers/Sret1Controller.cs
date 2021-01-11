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
    public class Sret1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Sret1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Sret1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sret1>>> GetSret1s()
        {
            return await _context.Sret1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
            int maxNo = await _context.Sret1s.MaxAsync(x => (int?)x.No) ?? 0;
            return Ok(maxNo);
        }

        // GET: api/Sret1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sret1>> GetSret1(int id)
        {
            var sret1 = await _context.Sret1s.FindAsync(id);

            if (sret1 == null)
            {
                return NotFound();
            }

            return sret1;
        }
        // POST: api/Sret1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sret1>> PostSret1(Sret1 sret1)
        {
            _context.Sret1s.Add(sret1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Sret1Exists(sret1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSret1s", new { id = sret1.No }, sret1);
        }

        // DELETE: api/Sret1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSret1(int id)
        {
            var sret1 = await _context.Sret1s.FindAsync(id);
            if (sret1 == null)
            {
                return NotFound();
            }

            _context.Sret1s.Remove(sret1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Sret1Exists(int id)
        {
            return _context.Sret1s.Any(e => e.No == id);
        }
    }
}
