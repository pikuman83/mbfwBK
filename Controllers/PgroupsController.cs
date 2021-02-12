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
    public class PgroupsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public PgroupsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Pgroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pgroup>>> GetPgroup()
        {
            return await _context.Pgroups.ToListAsync();
        }

        [HttpGet("reports/pgname")]
        public async Task<ActionResult> GetByNo()
        {
            List<string> x = await _context.Pgroups.Select(x => x.Pgname).ToListAsync();

            if (x == null || !x.Any()) { return Ok(new List<string>());}

            else { return Ok(x); }
        }


        // GET: api/Pgroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pgroup>> GetPgroup(int id)
        {
            var pgroup = await _context.Pgroups.FindAsync(id);

            if (pgroup == null)
            {
                return NotFound();
            }

            return pgroup;
        }

        // PUT: api/Pgroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPgroup(int id, Pgroup pgroup)
        {
            if (id != pgroup.Pgrp)
            {
                return BadRequest();
            }

            _context.Entry(pgroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PgroupExists(id))
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

        // POST: api/Pgroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pgroup>> PostPgroup(Pgroup pgroup)
        {
            _context.Pgroups.Add(pgroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PgroupExists(pgroup.Pgrp))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPgroup", new { id = pgroup.Pgrp }, pgroup);
        }

        // DELETE: api/Pgroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pgroup>> DeletePgroup(int id)
        {
            var pgroup = await _context.Pgroups.FindAsync(id);
            if (pgroup == null)
            {
                return NotFound();
            }

            _context.Pgroups.Remove(pgroup);
            await _context.SaveChangesAsync();

            return pgroup;
        }

        private bool PgroupExists(int id)
        {
            return _context.Pgroups.Any(e => e.Pgrp == id);
        }
    }
}
