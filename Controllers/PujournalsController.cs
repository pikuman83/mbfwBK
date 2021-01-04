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
    public class PujournalsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public PujournalsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Pujournals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pujournal>>> GetPujournals()
        {
            return await _context.Pujournals.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Pujournals.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

    // GET: api/Bankjvs/5
    [HttpGet("{No}")]
    public async Task<ActionResult> GetBankjv(int No)
    {
      return Ok(await _context.Pujournals.Where(x => x.No == No).ToListAsync());
    }

    // POST: api/Pujournals
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
        public async Task<ActionResult<Pujournal>> PostPujournal(Pujournal pujournal)
        {
            _context.Pujournals.Add(pujournal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPujournals", new { id = pujournal.Id }, pujournal);
        }

    // DELETE: api/Opjournals/5
    [HttpDelete("{No}")]
    public async Task<IActionResult> DeleteBankjv(int No)
    {
      var bankjv = await _context.Pujournals.Where(x => x.No == No).ToListAsync();

      if (bankjv == null)
      {
        return NotFound();
      }
      for (int i = 0; i < bankjv.Count; i++)
      {
        _context.Pujournals.Remove(bankjv[i]);
      }
      await _context.SaveChangesAsync();

      return NoContent();
    }
  }
}
