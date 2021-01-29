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
    public class Gin1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Gin1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Gin1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gin1>>> GetGin1s()
        {
            return await _context.Gin1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Gin1s.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        [HttpGet("mb/f2Lookup")]
        public async Task<ActionResult> GetpendingRecords()
        {
          return Ok(await _context.Sorder1s.FromSqlRaw("select g.* from SORDER1 g left outer join STOCKSO p on (g.no=p.SONO and p.JO IN('DC','SOC')) where p.SONO is null and g.vcode<>'CUST10191' Order By g.VDATE").ToListAsync());
        }

        [HttpGet("mb/pendingRecords")] //used in SalesCredit voucher
        public async Task<ActionResult> GetpendingRecordsForSalesVoucher()
        {
            return Ok(await _context.Grn1s.FromSqlRaw("select g.* from GIN1 g left outer join SALE1 p on g.no=p.ginno where p.ginno is null AND g.STYPE=0 Order By g.VDATE").ToListAsync());
        }

        // GET: api/Gin1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gin1>> GetGin1(int id)
        {
            var gin1 = await _context.Gin1s.FindAsync(id);

            if (gin1 == null)
            {
                return NotFound();
            }

            return gin1;
        }

        // POST: api/Gin1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gin1>> PostGin1(Gin1 gin1)
        {
            _context.Gin1s.Add(gin1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Gin1Exists(gin1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGin1s", new { id = gin1.No }, gin1);
        }

        // DELETE: api/Gin1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGin1(int id)
        {
            var gin1 = await _context.Gin1s.FindAsync(id);
            if (gin1 == null)
            {
                return NotFound();
            }

            _context.Gin1s.Remove(gin1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Gin1Exists(int id)
        {
            return _context.Gin1s.Any(e => e.No == id);
        }
    }
}
