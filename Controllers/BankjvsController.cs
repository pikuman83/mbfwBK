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
    public class BankjvsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public BankjvsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Bankjvs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bankjv>>> GetBankjvs()
        {
            return await _context.Bankjvs.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Bankjvs.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

    // GET: api/Bankjvs/5
    [HttpGet("{No}")]
    public async Task<ActionResult> GetBankjv(int No)
    {
      return Ok(await _context.Bankjvs.Where(x => x.No == No).ToListAsync());
    }

    // POST: api/Bankjvs
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
        public async Task<ActionResult<Bankjv>> PostBankjv(Bankjv bankjv)
        {
            _context.Bankjvs.Add(bankjv);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankjvs", new { id = bankjv.Id }, bankjv);
        }

        // DELETE: api/Bankjvs/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
            var bankjv = await _context.Bankjvs.Where(x => x.No == No).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
              _context.Bankjvs.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BankjvExists(int id)
        {
            return _context.Bankjvs.Any(e => e.Id == id);
        }
    }
}
