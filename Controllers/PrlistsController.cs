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
    public class PrlistsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public PrlistsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Prlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prlist>>> GetPrlist()
        {
            return await _context.Prlists.ToListAsync();
        }

        // GET: api/Prlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prlist>> GetPrlist(int id)
        {
            var prlist = await _context.Prlists.FindAsync(id);

            if (prlist == null)
            {
                return NotFound();
            }

            return prlist;
        }

        // PUT: api/Prlists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrlist(int id, Prlist prlist)
        {
            if (id != prlist.Id)
            {
                return BadRequest();
            }

            _context.Entry(prlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrlistExists(id))
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

        // POST: api/Prlists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Prlist>> PostPrlist(Prlist prlist)
        {
            _context.Prlists.Add(prlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrlist", new { id = prlist.Id }, prlist);
        }

        // DELETE: api/Prlists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Prlist>> DeletePrlist(int id)
        {
            var prlist = await _context.Prlists.FindAsync(id);
            if (prlist == null)
            {
                return NotFound();
            }

            _context.Prlists.Remove(prlist);
            await _context.SaveChangesAsync();

            return prlist;
        }

        private bool PrlistExists(int id)
        {
            return _context.Prlists.Any(e => e.Id == id);
        }
    }
}
