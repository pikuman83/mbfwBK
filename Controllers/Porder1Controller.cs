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
    public class Porder1Controller : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public Porder1Controller(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Porder1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Porder1>>> GetPorder1s()
        {
            return await _context.Porder1s.ToListAsync();
        }

        [HttpGet("max")]
        public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
        {
          int maxNo = await _context.Porder1s.MaxAsync(x => (int?)x.No) ?? 0;
          return Ok(maxNo);
        }
        //[HttpGet("{No}")]
        //public async Task<ActionResult> GetByNo(int No)
        //{
        //  return Ok(await _context.Porder1s.Where(x => x.No.Equals(No)).ToListAsync());
        //}
        // GET: api/Porder1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Porder1>> GetPorder1(int id)
        {
            var porder1 = await _context.Porder1s.FindAsync(id);

            if (porder1 == null)
            {
                return NotFound();
            }

            return porder1;
        }

        // PUT: api/Porder1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPorder1(int id, Porder1 porder1)
        {
            if (id != porder1.No)
            {
                return BadRequest();
            }

            _context.Entry(porder1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Porder1Exists(id))
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

        // POST: api/Porder1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Porder1>> PostPorder1(Porder1 porder1)
        {
            _context.Porder1s.Add(porder1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Porder1Exists(porder1.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPorder1s", new { id = porder1.No }, porder1);
        }

        // DELETE: api/Porder1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePorder1(int id)
        {
            var porder1 = await _context.Porder1s.FindAsync(id);
            if (porder1 == null)
            {
                return NotFound();
            }

            _context.Porder1s.Remove(porder1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Porder1Exists(int id)
        {
            return _context.Porder1s.Any(e => e.No == id);
        }
    }
}
