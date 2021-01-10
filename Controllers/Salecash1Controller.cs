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
    public class Salecash1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Salecash1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Salecash1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Salecash1>>> GetSalecash1s()
        {
            return await _context.Salecash1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
            int maxNo = await _context.Salecash1s.MaxAsync(x => (int?)x.No) ?? 0;
            return Ok(maxNo);
        }

        // GET: api/Salecash1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Salecash1>> GetSalecash1(int id)
        {
            var salecash1 = await _context.Salecash1s.FindAsync(id);

            if (salecash1 == null)
            {
                return NotFound();
            }

            return salecash1;
        }

        // POST: api/Salecash1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Salecash1>> PostSalecash1(Salecash1 salecash1)
        {
            _context.Salecash1s.Add(salecash1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Salecash1Exists(salecash1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSalecash1s", new { id = salecash1.No }, salecash1);
        }

        // DELETE: api/Salecash1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalecash1(int id)
        {
            var salecash1 = await _context.Salecash1s.FindAsync(id);
            if (salecash1 == null)
            {
                return NotFound();
            }

            _context.Salecash1s.Remove(salecash1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Salecash1Exists(int id)
        {
            return _context.Salecash1s.Any(e => e.No == id);
        }
    }
}
