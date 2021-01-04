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
    public class StocksController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public StocksController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Stocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStocks()
        {
            return await _context.Stocks.ToListAsync();
        }

        [HttpGet("{No}")]
        public async Task<ActionResult> GetByNo(int No)
        {
          return Ok(await _context.Stocks.Where(x => x.No == No).ToListAsync());
        }

        [HttpGet("mb/getOaBal/{pcode}/{gdcode}/{vdate}")]
        public object GetOaBal(string pcode, string gdcode, DateTime vdate)
        {
            //var filteredRecoreds = await _context.Stocks.Where(x => x.Pcode == pcode && x.Gdcode == gdcode && x.Vdate <= vdate).ToListAsync();
            var availability = _context.Stocks.Where(x => x.Pcode == pcode && x.Gdcode == gdcode && x.Vdate <= vdate);
            var tInqt = availability.Sum(s => s.Inqt);
            var tOutqt = availability.Sum(s => s.Outqt);
            var result = tInqt - tOutqt;
            if (result != null) { return Ok(result); }
            else { return new EmptyResult(); }
    }

        // POST: api/Stocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stock>> PostStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStocks", new { id = stock.Id }, stock);
        }

        // DELETE: api/Stocks/5
        [HttpDelete("del/{id1:int}/{id2}")]
        public async Task<IActionResult> DeleteGnrllgr1(int? id1, string id2)
        {
          var gnrllgr = await _context.Stocks.Where(x => x.No == id1 & x.Jo == id2).ToListAsync();
          if (gnrllgr == null)
          {
            return NotFound();
          }
          for (int i = 0; i < gnrllgr.Count; i++)
          {
            _context.Stocks.Remove(gnrllgr[i]);
          }

          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}
