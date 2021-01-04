using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("search/{No}")]

        public async Task<ActionResult<IEnumerable<Sale2>>> ListByNumber(short No)
        {
            return await _context.Sale2s.Where(x => x.No.Equals(No)).ToListAsync();
        }

        // GET: api/Sale2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sale2>> GetSale2(int id)
        {
            var sale2 = await _context.Sale2s.FindAsync(id);

            if (sale2 == null)
            {
                return NotFound();
            }

            return sale2;
        }

        // PUT: api/Sale2/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale2(int id, Sale2 sale2)
        {
            if (id != sale2.Id)
            {
                return BadRequest();
            }

            _context.Entry(sale2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sale2Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Sale2
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Sale2>> PostSale2(Sale2 sale2)
        {
            _context.Sale2s.Add(sale2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSale2", new { id = sale2.Id }, sale2);
        }

        // DELETE: api/Sale2/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sale2>> DeleteSale2(int id)
        {
            var sale2 = await _context.Sale2s.FindAsync(id);
            if (sale2 == null)
            {
                return NotFound();
            }

            _context.Sale2s.Remove(sale2);
            await _context.SaveChangesAsync();

            return sale2;
        }

        private bool Sale2Exists(int id)
        {
            return _context.Sale2s.Any(e => e.Id == id);
        }
    }
}
