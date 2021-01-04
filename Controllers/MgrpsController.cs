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
    public class MgrpsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public MgrpsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Mgrps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mgrp>>> GetMgrp()
        {
            return await _context.Mgrps.ToListAsync();
        }

        // GET: api/Mgrps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mgrp>> GetMgrp(int id)
        {
            var mgrp = await _context.Mgrps.FindAsync(id);

            if (mgrp == null)
            {
                return NotFound();
            }

            return mgrp;
        }

        // PUT: api/Mgrps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMgrp(int id, Mgrp mgrp)
        {
            if (id != mgrp.Grp)
            {
                return BadRequest();
            }

            _context.Entry(mgrp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MgrpExists(id))
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

        // POST: api/Mgrps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Mgrp>> PostMgrp(Mgrp mgrp)
        {
            _context.Mgrps.Add(mgrp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MgrpExists(mgrp.Grp))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMgrp", new { id = mgrp.Grp }, mgrp);
        }

        // DELETE: api/Mgrps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mgrp>> DeleteMgrp(int id)
        {
            var mgrp = await _context.Mgrps.FindAsync(id);
            if (mgrp == null)
            {
                return NotFound();
            }

            _context.Mgrps.Remove(mgrp);
            await _context.SaveChangesAsync();

            return mgrp;
        }

        private bool MgrpExists(int id)
        {
            return _context.Mgrps.Any(e => e.Grp == id);
        }
    }
}
