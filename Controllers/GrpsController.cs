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
    public class GrpsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public GrpsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Grps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grp>>> GetGrp()
        {
            return await _context.Grps.ToListAsync();
        }

        // GET: api/Grps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grp>> GetGrp(int id)
        {
            var grp = await _context.Grps.FindAsync(id);

            if (grp == null)
            {
                return NotFound();
            }

            return grp;
        }

        // PUT: api/Grps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrp(int id, Grp grp)
        {
            if (id != grp.Grp1)
            {
                return BadRequest();
            }

            _context.Entry(grp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrpExists(id))
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

        // POST: api/Grps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Grp>> PostGrp(Grp grp)
        {
            _context.Grps.Add(grp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GrpExists(grp.Grp1))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGrp", new { id = grp.Grp1 }, grp);
        }

        // DELETE: api/Grps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Grp>> DeleteGrp(int id)
        {
            var grp = await _context.Grps.FindAsync(id);
            if (grp == null)
            {
                return NotFound();
            }

            _context.Grps.Remove(grp);
            await _context.SaveChangesAsync();

            return grp;
        }

        private bool GrpExists(int id)
        {
            return _context.Grps.Any(e => e.Grp1 == id);
        }
    }
}
