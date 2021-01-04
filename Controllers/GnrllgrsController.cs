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
    public class GnrllgrsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public GnrllgrsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Gnrllgrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gnrllgr>>> GetGnrllgrs()
        {
            return await _context.Gnrllgrs.ToListAsync();
        }

       // GET: api/Gnrllgrs/5
       [HttpGet("{id}")]
        public async Task<ActionResult<Gnrllgr>> GetGnrllgr(int id)
        {
            var gnrllgr = await _context.Gnrllgrs.FindAsync(id);

            if (gnrllgr == null)
            {
                return NotFound();
            }

            return gnrllgr;
        }

        // PUT: api/Gnrllgrs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGnrllgr(int id, Gnrllgr gnrllgr)
        {
            if (id != gnrllgr.Id)
            {
                return BadRequest();
            }

            _context.Entry(gnrllgr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GnrllgrExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Gnrllgrs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gnrllgr>> PostGnrllgr(Gnrllgr gnrllgr)
        {
            _context.Gnrllgrs.Add(gnrllgr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGnrllgr", new { id = gnrllgr.Id }, gnrllgr);
        }

        // DELETE: api/Gnrllgrs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGnrllgr(int id)
        {
            var gnrllgr = await _context.Gnrllgrs.FindAsync(id);
            if (gnrllgr == null)
            {
                return NotFound();
            }

            _context.Gnrllgrs.Remove(gnrllgr);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpDelete("del/{id1:int}/{id2}")]
        public async Task<IActionResult> DeleteGnrllgr1(int? id1, string id2)
        {
          var gnrllgr = await _context.Gnrllgrs.Where(x => x.No ==id1 & x.Jo == id2).ToListAsync();
          if (gnrllgr == null)
          {
            return NotFound();
          }
          for (int i = 0; i<gnrllgr.Count; i++)
          {
              _context.Gnrllgrs.Remove(gnrllgr[i]);
           }
          
          await _context.SaveChangesAsync();

          return NoContent();
        }


        private bool GnrllgrExists(int id)
        {
            return _context.Gnrllgrs.Any(e => e.Id == id);
        }
    }
}
