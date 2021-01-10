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
    public class Salecash2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Salecash2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Salecash2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Salecash2>>> GetSalecash2s()
        {
            return await _context.Salecash2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
            return Ok(await _context.Salecash2s.Where(x => x.No == No).ToListAsync());
        }

        // GET: api/Salecash2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Salecash2>> GetSalecash2(int id)
        {
            var salecash2 = await _context.Salecash2s.FindAsync(id);

            if (salecash2 == null)
            {
                return NotFound();
            }

            return salecash2;
        }

        // POST: api/Salecash2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Salecash2>> PostSalecash2(Salecash2 salecash2)
        {
            _context.Salecash2s.Add(salecash2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalecash2s", new { id = salecash2.Id }, salecash2);
        }

        // DELETE: api/Salecash2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Salecash2s.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Salecash2s.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
