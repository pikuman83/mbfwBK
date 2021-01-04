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
    public class CashrcpsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public CashrcpsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Cashrcps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cashrcp>>> GetCashrcps()
        {
            return await _context.Cashrcps.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Cashrcps.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        // GET: api/Bankjvs/5
        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Cashrcps.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Cashrcps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cashrcp>> PostCashrcp(Cashrcp cashrcp)
        {
            _context.Cashrcps.Add(cashrcp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCashrcps", new { id = cashrcp.Id }, cashrcp);
        }

        // DELETE: api/Cashrcps/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Cashrcps.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Cashrcps.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}
