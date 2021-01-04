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
    public class SljournalsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public SljournalsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Sljournals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sljournal>>> GetSljournals()
        {
            return await _context.Sljournals.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Sljournals.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }


    // GET: api/Bankjvs/5
    [HttpGet("{No}")]
    public async Task<ActionResult> GetBankjv(int No)
    {
      return Ok(await _context.Sljournals.Where(x => x.No == No).ToListAsync());
    }

    // POST: api/Sljournals
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
        public async Task<ActionResult<Sljournal>> PostSljournal(Sljournal sljournal)
        {
            _context.Sljournals.Add(sljournal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSljournals", new { id = sljournal.Id }, sljournal);
        }

    // DELETE: api/Sljournals/5
    [HttpDelete("{No}")]
    public async Task<IActionResult> DeleteBankjv(int No)
    {
      var bankjv = await _context.Sljournals.Where(x => x.No == No).ToListAsync();

      if (bankjv == null)
      {
        return NotFound();
      }
      for (int i = 0; i < bankjv.Count; i++)
      {
        _context.Sljournals.Remove(bankjv[i]);
      }
      await _context.SaveChangesAsync();

      return NoContent();
    }
  }
}
