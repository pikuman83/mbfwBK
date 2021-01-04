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
    public class DebitsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public DebitsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Debits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Debit>>> GetDebits()
        {
            return await _context.Debits.ToListAsync();
        }

        // GET: api/Debits/5
        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Debits.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        // GET: api/Bankjvs/5
        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Debits.Where(x => x.No == No).ToListAsync());
        }


        // POST: api/Debits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Debit>> PostDebit(Debit debit)
        {
            _context.Debits.Add(debit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDebits", new { id = debit.Id }, debit);
        }

        // DELETE: api/Debits/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Debits.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Debits.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}
