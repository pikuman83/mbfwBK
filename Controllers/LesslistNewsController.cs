using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mbfwAPI.Models;

namespace mbfwAPI.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    public class LesslistNewsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public LesslistNewsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/LesslistNews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LesslistNew>>> GetLesslistNew()
        {
            return await _context.LesslistNews.ToListAsync();
        }


        [HttpGet("mb/lessByPgroup/{date}/{code}")]
        public async Task<ActionResult<IEnumerable<int>>> GetRateByProductAndDate(DateTime date, string code)
        {
          var rate = await _context.LesslistNews.Where(p => p.Pname == code && p.Vdate <= date).OrderBy(d => d.Vdate).FirstOrDefaultAsync();
          if (rate != null)
          {
            return Ok(rate.Prate);
          }
          return Ok(null);
        }



    // GET: api/LesslistNews/5
    [HttpGet("{id}")]
        public async Task<ActionResult<LesslistNew>> GetLesslistNew(int id)
        {
            var lesslistNew = await _context.LesslistNews.FindAsync(id);

            if (lesslistNew == null)
            {
                return NotFound();
            }

            return lesslistNew;
        }

        // POST: api/LesslistNews
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LesslistNew>> PostLesslistNew(LesslistNew lesslistNew)
        {
            _context.LesslistNews.Add(lesslistNew);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLesslistNew", new { id = lesslistNew.Id }, lesslistNew);
        }

        // DELETE: api/LesslistNews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LesslistNew>> DeleteLesslistNew(int id)
        {
            var lesslistNew = await _context.LesslistNews.FindAsync(id);
            if (lesslistNew == null)
            {
                return NotFound();
            }

            _context.LesslistNews.Remove(lesslistNew);
            await _context.SaveChangesAsync();

            return lesslistNew;
        }

        private bool LesslistNewExists(int id)
        {
            return _context.LesslistNews.Any(e => e.Id == id);
        }
    }
}
