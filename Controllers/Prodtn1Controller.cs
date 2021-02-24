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
    public class Prodtn1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Prodtn1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Prodtn1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prodtn1>>> GetProdtn1s()
        {
            return await _context.Prodtn1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
            int maxNo = await _context.Prodtn1s.MaxAsync(x => (int?)x.No) ?? 0;
            return Ok(maxNo);
        }

        // GET: api/Prodtn1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prodtn1>> GetProdtn1(int id)
        {
            var prodtn1 = await _context.Prodtn1s.FindAsync(id);

            if (prodtn1 == null)
            {
                return NotFound();
            }

            return prodtn1;
        }

        // POST: api/Prodtn1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prodtn1>> PostProdtn1(Prodtn1 prodtn1)
        {
            _context.Prodtn1s.Add(prodtn1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Prodtn1Exists(prodtn1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProdtn1s", new { id = prodtn1.No }, prodtn1);
        }

        // DELETE: api/Prodtn1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdtn1(int id)
        {
            var prodtn1 = await _context.Prodtn1s.FindAsync(id);
            if (prodtn1 == null)
            {
                return NotFound();
            }

            _context.Prodtn1s.Remove(prodtn1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Prodtn1Exists(int id)
        {
            return _context.Prodtn1s.Any(e => e.No == id);
        }
    }
}
