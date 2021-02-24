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
    public class Mprodtn2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Mprodtn2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Mprodtn2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mprodtn2>>> GetMprodtn2s()
        {
            return await _context.Mprodtn2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
            return Ok(await _context.Mprodtn2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Mprodtn2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mprodtn2>> PostMprodtn2(Mprodtn2 mprodtn2)
        {
            _context.Mprodtn2s.Add(mprodtn2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMprodtn2s", new { id = mprodtn2.Id }, mprodtn2);
        }

        // DELETE: api/Mprodtn2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Mprodtn2s.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Mprodtn2s.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
