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
    public class AgroupsubsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public AgroupsubsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Agroupsubs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agroupsub>>> GetAgroupsub()
        {
            return await _context.Agroupsubs.ToListAsync();
        }

        // GET: api/Agroupsubs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agroupsub>> GetAgroupsub(int id)
        {
            var agroupsub = await _context.Agroupsubs.FindAsync(id);

            if (agroupsub == null)
            {
                return NotFound();
            }

            return agroupsub;
        }

        // PUT: api/Agroupsubs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgroupsub(int id, Agroupsub agroupsub)
        {
            if (id != agroupsub.Pgrp)
            {
                return BadRequest();
            }

            _context.Entry(agroupsub).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgroupsubExists(id))
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

        // POST: api/Agroupsubs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Agroupsub>> PostAgroupsub(Agroupsub agroupsub)
        {
            _context.Agroupsubs.Add(agroupsub);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AgroupsubExists(agroupsub.Pgrp))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAgroupsub", new { id = agroupsub.Pgrp }, agroupsub);
        }

        // DELETE: api/Agroupsubs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Agroupsub>> DeleteAgroupsub(int id)
        {
            var agroupsub = await _context.Agroupsubs.FindAsync(id);
            if (agroupsub == null)
            {
                return NotFound();
            }

            _context.Agroupsubs.Remove(agroupsub);
            await _context.SaveChangesAsync();

            return agroupsub;
        }

        private bool AgroupsubExists(int id)
        {
            return _context.Agroupsubs.Any(e => e.Pgrp == id);
        }
    }
}
