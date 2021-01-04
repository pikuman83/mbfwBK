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
    public class CashpymsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public CashpymsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Cashpyms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cashpym>>> GetCashpyms()
        {
            return await _context.Cashpyms.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Cashpyms.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Cashpyms.Where(x => x.No == No).ToListAsync());
        }


        // POST: api/Cashpyms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cashpym>> PostCashpym(Cashpym cashpym)
        {
            _context.Cashpyms.Add(cashpym);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCashpyms", new { id = cashpym.Id }, cashpym);
        }

        // DELETE: api/Cashpyms/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Cashpyms.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Cashpyms.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
      }
    }

