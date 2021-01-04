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
    public class Gin2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Gin2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Gin2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gin2>>> GetGin2s()
        {
            return await _context.Gin2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Gin2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Gin2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gin2>> PostGin2(Gin2 gin2)
        {
            _context.Gin2s.Add(gin2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGin2s", new { id = gin2.Id }, gin2);
        }

        // DELETE: api/Gin2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Gin2s.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Gin2s.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}
