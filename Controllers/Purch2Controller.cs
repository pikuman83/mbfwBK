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
    public class Purch2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Purch2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Purch2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Purch2>>> GetPurch2s()
        {
            return await _context.Purch2s.ToListAsync();
        }

        // GET: api/Purch2/5
        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Purch2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Purch2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Purch2>> PostPurch2(Purch2 purch2)
        {
            _context.Purch2s.Add(purch2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurch2s", new { id = purch2.Id }, purch2);
        }

        // DELETE: api/Purch2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Purch2s.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Purch2s.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }

        private bool Purch2Exists(int id)
        {
            return _context.Purch2s.Any(e => e.Id == id);
        }
    }
}
