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
  public class StockColorsController : ControllerBase
  {
    private readonly Mbfwcontext _context;

    public StockColorsController(Mbfwcontext context)
    {
      _context = context;
    }

        // GET: api/StockColors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockColor>>> GetStockColors()
        {
          return await _context.StockColors.ToListAsync();
        }

        [HttpGet("mb/getByNo/{No}/{jo}")]
        public async Task<ActionResult> GetByNo1(int No, string jo)
        {
          return Ok(await _context.StockColors.Where(x => x.No == No && x.Jo == jo).ToListAsync());
        }

        [HttpGet("mb/getAvailability/{pcode}")]
        public object GetColoAvailability(string pcode)
        {
            var pcolor = _context.ProductColors.Where(c => c.Pcode == pcode).ToList();

            var availability = (from colors in _context.ProductColors.Where(c => c.Pcode == pcode)
                                join stk in _context.StockColors on colors.Color equals stk.Color
                                where stk.Pcode == pcode
                                group stk by stk.Color into b
                                select new
                                {
                                    color = b.Key,
                                    avail = b.Sum(x => x.Inqt) - b.Sum(y => y.Outqt)
                                }).ToList();

            if (availability != null && availability.Any() && availability.Count > 0)
            {
                int singleLoop = 0;
                var result = new List<Object>();
                foreach (var clr in availability)
                {
                    result.Add(clr);
                    foreach (var p in pcolor)
                    {
                        if (p.Color != clr.color && singleLoop < pcolor.Count-2)
                        {
                            singleLoop++;
                            result.Add(new
                            {
                                color = p.Color,
                                avail = (double?)0
                            });
                        }
                    }
                };
                return Ok(result.Distinct());
            };
            return Ok(pcolor);
         }
  
        //var sumInqt = (from x in _context.StockColors where x.Color == colors[i].Color && x.Pcode == pcode select x.Inqt).Sum();
        //var sumOutqt = (from x in _context.StockColors where x.Color == colors[i].Color && x.Pcode == pcode select x.Outqt).Sum();
        //var availability = sumInqt - sumOutqt;




        // POST: api/StockColors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StockColor>> PostStockColor(StockColor stockColor)
        {
            _context.StockColors.Add(stockColor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStockColors", new { id = stockColor.Id }, stockColor);
        }

        // DELETE: api/StockColors/5
        [HttpDelete("{Jo}/{No}")]
        public async Task<IActionResult> DeleteBankjv(string Jo, int No)
        {
          var bankjv = await _context.StockColors.Where(x => x.No == No && x.Jo == Jo).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.StockColors.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}
