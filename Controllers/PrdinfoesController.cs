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
    public class PrdinfoesController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public PrdinfoesController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Prdinfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prdinfo>>> GetPrdinfos()
        {
            return await _context.Prdinfos.ToListAsync();
        }

        [HttpGet("{pcode}/{color}")]
        public async Task<ActionResult> GetByNo(string pcode, string color)
        {
            return Ok(await _context.Prdinfos.Where(x => x.Fcode == pcode && x.Funit == color).ToListAsync());
        }

        // POST: api/Prdinfoes
        [HttpPost]
        public async Task<ActionResult<Prdinfo>> PostPrdinfo(Prdinfo prdinfo)
        {
            _context.Prdinfos.Add(prdinfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrdinfos", new { id = prdinfo.Id }, prdinfo);
        }

        // DELETE: api/Prdinfoes/5
        [HttpDelete("{pcode}/{color}")]
        public async Task<IActionResult> DeleteBankjv(string pcode, string color)
        {
            var bankjv = await _context.Prdinfos.Where(x => x.Fcode == pcode && x.Funit == color).ToListAsync();

            if (bankjv == null)
            {
                return NotFound();
            }
            for (int i = 0; i < bankjv.Count; i++)
            {
                _context.Prdinfos.Remove(bankjv[i]);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
