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
  public class JournalsController : ControllerBase
  {
    private readonly Mbfwcontext _context;

    public JournalsController(Mbfwcontext context)
    {
      _context = context;
    }

    // GET: api/Journals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Journal>>> GetJournals()
    {
      return await _context.Journals.ToListAsync();
    }

    [HttpGet("max")]
    public async Task<ActionResult<IEnumerable<int>>> GetmaxNo()
    {
      int maxNo = await _context.Journals.MaxAsync(x => (int?)x.No) ?? 0;
      return Ok(maxNo);
    }

    // GET: api/Bankjvs/5
    [HttpGet("{No}")]
    public async Task<ActionResult> GetBankjv(int No)
    {
      return Ok(await _context.Bankjvs.Where(x => x.No == No).ToListAsync());
    }

    // POST: api/Journals
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Journal>> PostJournal(Journal journal)
    {
      _context.Journals.Add(journal);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetJournals", new { id = journal.Id }, journal);
    }

    // DELETE: api/Bankjvs/5
    [HttpDelete("{No}")]
    public async Task<IActionResult> DeleteBankjv(int No)
    {
      var bankjv = await _context.Journals.Where(x => x.No == No).ToListAsync();

      if (bankjv == null)
      {
        return NotFound();
      }
      for (int i = 0; i < bankjv.Count; i++)
      {
        _context.Journals.Remove(bankjv[i]);
      }
      await _context.SaveChangesAsync();

      return NoContent();
      }
    }
  }
