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
    public class Sret2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Sret2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Sret2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sret2>>> GetSret2s()
        {
            return await _context.Sret2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult<Sret2>> GetByNo(int No)
        {
            return Ok(await _context.Sret2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Sret2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sret2>> PostSret2(Sret2 sret2)
        {
            _context.Sret2s.Add(sret2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSret2s", new { id = sret2.Id }, sret2);
        }

        // DELETE: api/Sret2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Sret2s.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Sret2s.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
