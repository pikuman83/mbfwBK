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
    public class Prodtn2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Prodtn2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Prodtn2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prodtn2>>> GetProdtn2s()
        {
            return await _context.Prodtn2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
            return Ok(await _context.Prodtn2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Prodtn2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prodtn2>> PostProdtn2(Prodtn2 prodtn2)
        {
            _context.Prodtn2s.Add(prodtn2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdtn2s", new { id = prodtn2.Id }, prodtn2);
        }

        // DELETE: api/Prodtn2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Prodtn2s.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Prodtn2s.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
