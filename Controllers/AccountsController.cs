using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mbfwAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mbfw_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly Mbfwcontext _context;

        public AccountsController(Mbfwcontext context)
        {
            _context = context;
        }

        // GET: api/Accounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccount()
        {
            return await _context.Accounts.ToListAsync();
        }

        [HttpGet("reports/accounts")]
        public async Task<ActionResult> GetByNo()
        {
            var x = await _context.Accounts.Select(x => new { x.Acode, x.Aname, extra = x.Atpname}).ToListAsync();

                if (x == null || !x.Any()) { return Ok(new EmptyResult()); }

            return Ok(x);
        }

        [HttpGet("purchases")]
        public async Task<ActionResult> GetPurchaseAccounts()
        {
          return Ok(await _context.Accounts.Where(x => x.Atype == 13).ToListAsync());
        }

        [HttpGet("mb/type10")]
        public async Task<ActionResult> GetSalesAccounts()
        {
            return Ok(await _context.Accounts.Where(x => x.Atype == 10).ToListAsync());
        }

        // GET: api/Accounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccount(string id)
        {
            var account = await _context.Accounts.FindAsync(id);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }

        // PUT: api/Accounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccount(string id, Account account)
        {
            if (id != account.Acode)
            {
                return BadRequest();
            }

            _context.Entry(account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(id))
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

        // POST: api/Accounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Account>> PostAccount(Account account)
        {
            _context.Accounts.Add(account);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AccountExists(account.Acode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAccount", new { id = account.Acode }, account);
        }

        // DELETE: api/Accounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> DeleteAccount(string id)
        {
            var InLgr = _context.Gnrllgrs.Any(x => x.Acode.Equals(id));
            var account = await _context.Accounts.FindAsync(id);
            if (account == null || InLgr)
            {
                return NotFound();
            }

            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();

            return account;
        }

        private bool AccountExists(string id)
        {
            return _context.Accounts.Any(e => e.Acode == id);
        }
    }
}
