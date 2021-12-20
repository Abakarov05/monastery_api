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
    public class ScheduleWorksController : ControllerBase
    {
        private readonly db_a7d9cd_jojonikilisContext _context;

        public ScheduleWorksController(db_a7d9cd_jojonikilisContext context)
        {
            _context = context;
        }

        // GET: api/ScheduleWorks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleWork>>> GetScheduleWorks()
        {
            return await _context.ScheduleWorks.ToListAsync();
        }

        // GET: api/ScheduleWorks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleWork>> GetScheduleWork(int id)
        {
            var scheduleWork = await _context.ScheduleWorks.FindAsync(id);

            if (scheduleWork == null)
            {
                return NotFound();
            }

            return scheduleWork;
        }

        // PUT: api/ScheduleWorks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScheduleWork(int id, ScheduleWork scheduleWork)
        {
            if (id != scheduleWork.Id)
            {
                return BadRequest();
            }

            _context.Entry(scheduleWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScheduleWorkExists(id))
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

        // POST: api/ScheduleWorks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ScheduleWork>> PostScheduleWork(ScheduleWork scheduleWork)
        {
            _context.ScheduleWorks.Add(scheduleWork);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScheduleWork", new { id = scheduleWork.Id }, scheduleWork);
        }

        // DELETE: api/ScheduleWorks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScheduleWork(int id)
        {
            var scheduleWork = await _context.ScheduleWorks.FindAsync(id);
            if (scheduleWork == null)
            {
                return NotFound();
            }

            _context.ScheduleWorks.Remove(scheduleWork);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScheduleWorkExists(int id)
        {
            return _context.ScheduleWorks.Any(e => e.Id == id);
        }
    }
}
