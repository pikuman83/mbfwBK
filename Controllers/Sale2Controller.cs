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
    public class Sale2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Sale2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Sale2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale2>>> GetSale2()
        {
            return await _context.Sale2s.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
            return Ok(await _context.Sale2s.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Sale2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sale2>> PostSale2(Sale2 sale2)
        {
            _context.Sale2s.Add(sale2);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Sale2Exists(sale2.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSale2", new { id = sale2.Id }, sale2);
        }

        // DELETE: api/Sale2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Sale2s.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Sale2s.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Sale2Exists(int id)
        {
            return _context.Sale2s.Any(e => e.Id == id);
        }
    }
}
