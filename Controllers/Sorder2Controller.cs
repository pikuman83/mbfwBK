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
    public class Sorder2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Sorder2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Sorder2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sorder2>>> GetSorder2()
        {
            return await _context.Sorder2s.ToListAsync();
        }

        [HttpGet("mb/rate/{pcode}/{No}")] //used in salesorder
        public async Task<ActionResult<IEnumerable<Sorder2>>> GetProductRate(string pcode, int No)
        {
            return Ok(await _context.Sorder2s.Where(x => x.No == No && x.Pcode == pcode).FirstAsync());
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Sorder2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Sorder2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sorder2>> PostSorder2(Sorder2 sorder2)
        {
            _context.Sorder2s.Add(sorder2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSorder2", new { id = sorder2.Id }, sorder2);
        }

        // DELETE: api/Sorder2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Sorder2s.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Sorder2s.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();

        }
    }
}
