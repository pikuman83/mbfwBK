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
    public class GpricesController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public GpricesController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Gprices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gprice>>> GetGprice()
        {
            return await _context.Gprices.ToListAsync();
        }

        [HttpGet("mb/rate/{code}/{vcode}/{date}")]
        public async Task<ActionResult<IEnumerable<int>>> GetRateByProductAndDate(string code, string vcode, DateTime date)
        {
            var rate = await _context.Gprices.Where(p => p.Pcode == code && p.Vdate <= date).OrderBy(d => d.Vdate).FirstOrDefaultAsync();
                if (rate != null){
                    return Ok(rate.Srate);
                }
                else if (rate == null){
                    var rate1 = await _context.Prlists.Where(p => p.Pcode == code && p.Vcode == vcode && p.Vdate <= date).OrderBy(d => d.Vdate).FirstOrDefaultAsync();
                    if (rate1 != null){
                        return Ok(rate1.Srate);
                }
                else if (rate1 == null){
                    var rate2 = await _context.Products.Where(p => p.Pcode == code).FirstOrDefaultAsync();
                    if (rate2 != null){
                        return Ok(rate2.Srate);
                    }
                    else { return null; }
                }
            }
          return null;
    }

        // GET: api/Gprices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gprice>> GetGprice(int id)
        {
            var gprice = await _context.Gprices.FindAsync(id);

            if (gprice == null)
            {
                return NotFound();
            }

            return gprice;
        }

        // PUT: api/Gprices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGprice(int id, Gprice gprice)
        {
            if (id != gprice.Id)
            {
                return BadRequest();
            }

            _context.Entry(gprice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GpriceExists(id))
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

        // POST: api/Gprices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Gprice>> PostGprice(Gprice gprice)
        {
            _context.Gprices.Add(gprice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGprice", new { id = gprice.Id }, gprice);
        }

        // DELETE: api/Gprices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gprice>> DeleteGprice(int id)
        {
            var gprice = await _context.Gprices.FindAsync(id);
            if (gprice == null)
            {
                return NotFound();
            }

            _context.Gprices.Remove(gprice);
            await _context.SaveChangesAsync();

            return gprice;
        }

        private bool GpriceExists(int id)
        {
            return _context.Gprices.Any(e => e.Id == id);
        }
    }
}
