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
    public class Socan2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Socan2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Socan2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Socan2>>> GetSocan2s()
        {
            return await _context.Socan2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
            return Ok(await _context.Socan2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Socan2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Socan2>> PostSocan2(Socan2 socan2)
        {
            _context.Socan2s.Add(socan2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSocan2s", new { id = socan2.Id }, socan2);
        }

        // DELETE: api/Socan2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Socan2s.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Socan2s.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
