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
    public class Grn1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Grn1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Grn1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grn1>>> GetGrn1s()
        {
            return await _context.Grn1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Grn1s.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        [HttpGet("mb/pendingRecords")] //used in purchase voucher
        public async Task<ActionResult> GetpendingRecords()
        {
          return Ok(await _context.Grn1s.FromSqlRaw("select g.* from GRN1 g left outer join PURCH1 p on g.NO = p.GRNNO where p.grnno is null ORDER BY g.VDATE, g.[NO]").ToListAsync());
        }


        // GET: api/Grn1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grn1>> GetGrn1(int id)
        {
            var grn1 = await _context.Grn1s.FindAsync(id);

            if (grn1 == null)
            {
                return NotFound();
            }

            return grn1;
        }

        // POST: api/Grn1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Grn1>> PostGrn1(Grn1 grn1)
        {
            _context.Grn1s.Add(grn1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Grn1Exists(grn1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGrn1s", new { id = grn1.No }, grn1);
        }

        // DELETE: api/Grn1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrn1(int id)
        {
            var grn1 = await _context.Grn1s.FindAsync(id);
            if (grn1 == null)
            {
                return NotFound();
            }

            _context.Grn1s.Remove(grn1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Grn1Exists(int id)
        {
            return _context.Grn1s.Any(e => e.No == id);
        }
    }
}
