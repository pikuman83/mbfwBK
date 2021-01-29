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
    public class Claim1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Claim1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Claim1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Claim1>>> GetClaim1s()
        {
            return await _context.Claim1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
            int maxNo = await _context.Claim1s.MaxAsync(x => (int?)x.No) ?? 0;
            return Ok(maxNo);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Claim1>> GetClaim1(int id)
        {
            var Claim1 = await _context.Claim1s.FindAsync(id);

            if (Claim1 == null)
            {
                return NotFound();
            }

            return Claim1;
        }

        // POST: api/Claim1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Claim1>> PostClaim1(Claim1 claim1)
        {
            _context.Claim1s.Add(claim1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Claim1Exists(claim1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClaim1s", new { id = claim1.No }, claim1);
        }

        // DELETE: api/Claim1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClaim1(int id)
        {
            var claim1 = await _context.Claim1s.FindAsync(id);
            if (claim1 == null)
            {
                return NotFound();
            }

            _context.Claim1s.Remove(claim1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Claim1Exists(int id)
        {
            return _context.Claim1s.Any(e => e.No == id);
        }
    }
}
