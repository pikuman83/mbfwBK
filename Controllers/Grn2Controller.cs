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
    public class Grn2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Grn2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Grn2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grn2>>> GetGrn2s()
        {
            return await _context.Grn2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Grn2s.Where(x => x.No == No).ToListAsync());
        }
        
        // POST: api/Grn2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Grn2>> PostGrn2(Grn2 grn2)
        {
            _context.Grn2s.Add(grn2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrn2s", new { id = grn2.Id }, grn2);
        }

        // DELETE: api/Grn2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Grn2s.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Grn2s.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}
