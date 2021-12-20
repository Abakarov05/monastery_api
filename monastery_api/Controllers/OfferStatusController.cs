using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using monastery_api.Context;
using monastery_api.Models;

namespace monastery_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferStatusController : ControllerBase
    {
        private readonly db_a7d9cd_jojonikilisContext _context;

        public OfferStatusController(db_a7d9cd_jojonikilisContext context)
        {
            _context = context;
        }

        // GET: api/OfferStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfferStatus>>> GetOfferStatuses()
        {
            return await _context.OfferStatuses.ToListAsync();
        }

        // GET: api/OfferStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OfferStatus>> GetOfferStatus(int id)
        {
            var offerStatus = await _context.OfferStatuses.FindAsync(id);

            if (offerStatus == null)
            {
                return NotFound();
            }

            return offerStatus;
        }

        // PUT: api/OfferStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOfferStatus(int id, OfferStatus offerStatus)
        {
            if (id != offerStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(offerStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfferStatusExists(id))
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

        // POST: api/OfferStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OfferStatus>> PostOfferStatus(OfferStatus offerStatus)
        {
            _context.OfferStatuses.Add(offerStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOfferStatus", new { id = offerStatus.Id }, offerStatus);
        }

        // DELETE: api/OfferStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfferStatus(int id)
        {
            var offerStatus = await _context.OfferStatuses.FindAsync(id);
            if (offerStatus == null)
            {
                return NotFound();
            }

            _context.OfferStatuses.Remove(offerStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfferStatusExists(int id)
        {
            return _context.OfferStatuses.Any(e => e.Id == id);
        }
    }
}
