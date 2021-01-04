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
    public class OpjournalsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public OpjournalsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Opjournals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Opjournal>>> GetOpjournals()
        {
            return await _context.Opjournals.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Opjournals.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }

    //[HttpGet]
    //public object GetService1()
    //{
    //  var result = (from a in _context.Service1s
    //                join b in _context.Customers on a.Vcode equals b.Vcode

    //                select new
    //                {
    //                  a.No,
    //                  a.Vdate,
    //                  a.Sno,
    //                  a.Intime,
    //                  a.Outtime,
    //                  a.Vcode,
    //                  b.Vname,
    //                  b.Address,
    //                  b.Mobileno,
    //                  a.Total,
    //                  a.Prvbal,
    //                  a.Advrcv,
    //                  a.Net,
    //                  a.Prepby
    //                }).ToList();

    //  return result;
    //}
      //    return Ok(await _context.Stockpos.FromSqlRaw(@"SELECT COUNT(*) AS ID, COUNT(*) AS BATCH, COUNT(*) AS DESCR, COUNT(*) AS GDCODE, COUNT(*) AS GDNAME, COUNT(*) AS GRP, PRODUCT.PCODE, PRODUCT.PNAME, PRODUCT.UNIT,PRODUCT.SRATEP,PRODUCT.PTYPE,PRODUCT.GNAME,round(SUM(STOCKPO.INQT-STOCKPO.OUTQT),2) AS QTY,STOCKPO.PONO,STOCKPO.VCODE,PARTY.VNAME FROM PRODUCT, STOCKPO, PARTY Where PRODUCT.PCODE = STOCKPO.PCODE AND STOCKPO.VCODE = PARTY.VCODE And STOCKPO.[VDATE] <= '2020-12-01' GROUP BY  PRODUCT.PCODE, PRODUCT.PNAME, PRODUCT.UNIT,PRODUCT.GNAME,PRODUCT.SRATEP,PRODUCT.PTYPE,STOCKPO.PONO,PARTY.VNAME,STOCKPO.VCODE Having Round(SUM(STOCKPO.INQT-STOCKPO.OUTQT),2) <> 0 AND PRODUCT.PTYPE=0 ORDER BY PRODUCT.PCODE").ToListAsync());

        // GET: api/Bankjvs/5
        [HttpGet("{No}")]
        public async Task<ActionResult> GetBankjv(int No)
        {
          return Ok(await _context.Opjournals.Where(x => x.No == No).ToListAsync());
        }

        // POST: api/Opjournals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Opjournal>> PostOpjournal(Opjournal opjournal)
        {
            _context.Opjournals.Add(opjournal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOpjournals", new { id = opjournal.Id }, opjournal);
        }

        // DELETE: api/Opjournals/5
        [HttpDelete("{No}")]
        public async Task<IActionResult> DeleteBankjv(int No)
        {
          var bankjv = await _context.Opjournals.Where(x => x.No == No).ToListAsync();

          if (bankjv == null)
          {
            return NotFound();
          }
          for (int i = 0; i < bankjv.Count; i++)
          {
            _context.Opjournals.Remove(bankjv[i]);
          }
          await _context.SaveChangesAsync();

          return NoContent();
        }
    }
}

