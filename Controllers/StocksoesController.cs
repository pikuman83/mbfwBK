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
    public class StocksoesController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public StocksoesController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Stocksoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stockso>>> GetStocksos()
        {
            return await _context.Stocksos.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Stocksos.Where(x => x.No == No).ToListAsync());
        }

        [HttpGet("mb/pendingRecords/{date}")] //used in Goods Receipt's F1 lookup
        public async Task<ActionResult> GetpendingRecords(DateTime date)
        {
           return Ok(await _context.PendingordersSO.FromSqlRaw<PendingOrdersSO>("pendingOrdersSO {0}", date).ToListAsync());
        }

        // POST: api/Stocksoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stockso>> PostStockso(Stockso stockso)
        {
            _context.Stocksos.Add(stockso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStocksos", new { id = stockso.Id }, stockso);
        }

        // DELETE: api/Stocksoes/5
        [HttpDelete("delete/{id1:int}/{id2}/{pcode}")]
        public async Task<IActionResult> DeleteGnrllgr1(int? id1, string id2, string pcode)
        {
          var product = await _context.Stocksos.Where(x => x.No == id1 & x.Jo == id2 & x.Pcode == pcode).ToListAsync();
          if (product == null)
          {
            return NotFound();
          }
            _context.Stocksos.Remove(product[0]);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Stocksoes/5
        [HttpDelete("del/{id1:int}/{id2}")]
        public async Task<IActionResult> DeleteGnrllgr2(int? id1, string id2)
        {
          var product = await _context.Stocksos.Where(x => x.No == id1 & x.Jo == id2).ToListAsync();
          if (product == null)
          {
            return NotFound();
          }
          for (int i = 0; i < product.Count; i++)
          {
          _context.Stocksos.Remove(product[i]);
          }

          await _context.SaveChangesAsync();

          return NoContent();
        }

    }

}
