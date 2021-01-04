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
    public class Porder2Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Porder2Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Porder2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Porder2>>> GetPorder2s()
        {
            return await _context.Porder2s.ToListAsync();
        }

        [HttpGet("mb/rate/{pcode}/{No}")]
        public ActionResult<IEnumerable<Product>> GetProductRate(string pcode, int No)
        {

          var rate = (from r in _context.Porder2s
                      where r.Pcode == pcode && r.No == No
                      select r.Rate).FirstOrDefault();
          return Ok(rate);
        }


        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Porder2s.Where(x => x.No.Equals(No)).ToListAsync());
        }

        // POST: api/Porder2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Porder2>> PostPorder2(Porder2 porder2)
        {
            _context.Porder2s.Add(porder2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPorder2s", new { id = porder2.Id }, porder2);
        }

        // DELETE: api/Porder2/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Porder2s.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Porder2s.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
     }
}
