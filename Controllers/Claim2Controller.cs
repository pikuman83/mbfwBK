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
    public class Claim2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Claim2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Claim2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Claim2>>> GetClaim2s()
        {
            return await _context.Claim2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
            return Ok(await _context.Claim2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Claim2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Claim2>> PostClaim2(Claim2 claim2)
        {
            _context.Claim2s.Add(claim2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClaim2s", new { id = claim2.Id }, claim2);
        }

        // DELETE: api/Claim2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Claim2s.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Claim2s.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
