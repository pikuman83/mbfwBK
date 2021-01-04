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
    public class AgroupsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public AgroupsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Agroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agroup>>> GetAgroup()
        {
            return await _context.Agroups.ToListAsync();
        }

        // GET: api/Agroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agroup>> GetAgroup(int id)
        {
            var agroup = await _context.Agroups.FindAsync(id);

            if (agroup == null)
            {
                return NotFound();
            }

            return agroup;
        }

        // PUT: api/Agroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgroup(int id, Agroup agroup)
        {
            if (id != agroup.Pgrp)
            {
                return BadRequest();
            }

            _context.Entry(agroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgroupExists(id))
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

        // POST: api/Agroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Agroup>> PostAgroup(Agroup agroup)
        {
            _context.Agroups.Add(agroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AgroupExists(agroup.Pgrp))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAgroup", new { id = agroup.Pgrp }, agroup);
        }

        // DELETE: api/Agroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Agroup>> DeleteAgroup(int id)
        {
            var agroup = await _context.Agroups.FindAsync(id);
            if (agroup == null)
            {
                return NotFound();
            }

            _context.Agroups.Remove(agroup);
            await _context.SaveChangesAsync();

            return agroup;
        }

        private bool AgroupExists(int id)
        {
            return _context.Agroups.Any(e => e.Pgrp == id);
        }
    }
}
