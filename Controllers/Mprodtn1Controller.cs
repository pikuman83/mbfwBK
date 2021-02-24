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
    public class Mprodtn1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Mprodtn1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Mprodtn1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mprodtn1>>> GetMprodtn1s()
        {
            return await _context.Mprodtn1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
            int maxNo = await _context.Mprodtn1s.MaxAsync(x => (int?)x.No) ?? 0;
            return Ok(maxNo);
        }

        // GET: api/Mprodtn1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mprodtn1>> GetMprodtn1(int id)
        {
            var mprodtn1 = await _context.Mprodtn1s.FindAsync(id);

            if (mprodtn1 == null)
            {
                return NotFound();
            }

            return mprodtn1;
        }

        // POST: api/Mprodtn1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mprodtn1>> PostMprodtn1(Mprodtn1 mprodtn1)
        {
            _context.Mprodtn1s.Add(mprodtn1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Mprodtn1Exists(mprodtn1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMprodtn1s", new { id = mprodtn1.No }, mprodtn1);
        }

        // DELETE: api/Mprodtn1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMprodtn1(int id)
        {
            var mprodtn1 = await _context.Mprodtn1s.FindAsync(id);
            if (mprodtn1 == null)
            {
                return NotFound();
            }

            _context.Mprodtn1s.Remove(mprodtn1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Mprodtn1Exists(int id)
        {
            return _context.Mprodtn1s.Any(e => e.No == id);
        }
    }
}
