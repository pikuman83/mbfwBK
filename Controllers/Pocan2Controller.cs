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
    public class Pocan2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Pocan2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Pocan2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pocan2>>> GetPocan2s()
        {
            return await _context.Pocan2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Pocan2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Pocan2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pocan2>> PostPocan2(Pocan2 pocan2)
        {
            _context.Pocan2s.Add(pocan2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPocan2s", new { id = pocan2.Id }, pocan2);
        }

        // DELETE: api/Pocan2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Pocan2s.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Pocan2s.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}

