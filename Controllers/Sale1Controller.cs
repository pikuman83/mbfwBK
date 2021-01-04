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
    public class Sale1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Sale1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Sale1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale1>>> GetSale1s()
        {
            return await _context.Sale1s.ToListAsync();
        }

        [HttpGet("max/{No}")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
            int maxNo = await _context.Sale1s.MaxAsync(x => (int?)x.No) ?? 0;
            return Ok(maxNo);
        }

         // GET: api/Sale1/5
         [HttpGet("{id}")]
        public async Task<ActionResult<Sale1>> GetSale1(int id)
        {
            var sale1 = await _context.Sale1s.FindAsync(id);

            if (sale1 == null)
            {
                return NotFound();
            }

            return sale1;
        }

        // PUT: api/Sale1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale1(int id, Sale1 sale1)
        {
            if (id != sale1.No)
            {
                return BadRequest();
            }

            _context.Entry(sale1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sale1Exists(id))
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

        // POST: api/Sale1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sale1>> PostSale1(Sale1 sale1)
        {
            _context.Sale1s.Add(sale1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Sale1Exists(sale1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSale1", new { id = sale1.No }, sale1);
        }

        // DELETE: api/Sale1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale1(int id)
        {
            var sale1 = await _context.Sale1s.FindAsync(id);
            if (sale1 == null)
            {
                return NotFound();
            }

            _context.Sale1s.Remove(sale1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Sale1Exists(int id)
        {
            return _context.Sale1s.Any(e => e.No == id);
        }
    }
}
