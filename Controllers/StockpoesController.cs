using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mbfwAPI.Models;
using System.Text;
using Microsoft.Data.SqlClient;

namespace mbfwAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StockpoesController : ControllerBase
  {
    private readonly Mbfwcontext _context;

    public StockpoesController(Mbfwcontext context)
    {
      _context = context;
    }

    // GET: api/Stockpoes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Stockpo>>> GetStockpos()
    {
      return await _context.Stockpos.ToListAsync();
    }

    // GET: api/Stockpoes/5
    [HttpGet("{No}")]
    public async Task<ActionResult> GetByNo(int No)
    {
      return Ok(await _context.Stockpos.Where(x => x.No == No).ToListAsync());
    }

    [HttpGet("mb/pendingRecords/{date}")] //used in Goods Receipt's F1 lookup
    public async Task<ActionResult> GetpendingRecords(DateTime date)
    {
      var po = await _context.PendingOrdersPO.FromSqlRaw<PendingOrdersPO>("pendingOrdersPO {0}", date).ToListAsync();
      return Ok(po);
    }

    // POST: api/Stockpoes
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Stockpo>> PostStockpo(Stockpo stockpo)
    {
        _context.Stockpos.Add(stockpo);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetStockpos", new { id = stockpo.Id }, stockpo);
    }

      // DELETE: api/Stockpoes/5
      [HttpDelete("del/{id1}/{id2}")]
      public async Task<IActionResult> DeleteGnrllgr1(int? id1, string id2)
      {
        var gnrllgr = await _context.Stockpos.Where(x => x.No == id1 & x.Jo == id2).ToListAsync();
        if (gnrllgr == null)
        {
          return NotFound();
        }
        for (int i = 0; i < gnrllgr.Count; i++)
        {
          _context.Stockpos.Remove(gnrllgr[i]);
        }

        await _context.SaveChangesAsync();

        return NoContent();
      }
  }

}
