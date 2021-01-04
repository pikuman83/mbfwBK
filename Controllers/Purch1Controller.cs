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
    public class Purch1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Purch1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Purch1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Purch1>>> GetPurch1s()
        {
            return await _context.Purch1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Purch1s.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        // GET: api/Purch1/5
        [HttpGet("{No}")]
        public async Task<ActionResult<Purch1>> GetPurch1(int No)
        {
            var purch1 = await _context.Purch1s.FindAsync(No);

            if (purch1 == null)
            {
                return NotFound();
            }

            return purch1;
        }

        // POST: api/Purch1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Purch1>> PostPurch1(Purch1 purch1)
        {
            _context.Purch1s.Add(purch1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Purch1Exists(purch1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPurch1s", new { id = purch1.No }, purch1);
        }

        // DELETE: api/Purch1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurch1(int id)
        {
            var purch1 = await _context.Purch1s.FindAsync(id);
            if (purch1 == null)
            {
                return NotFound();
            }

            _context.Purch1s.Remove(purch1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Purch1Exists(int id)
        {
            return _context.Purch1s.Any(e => e.No == id);
        }
    }
}
