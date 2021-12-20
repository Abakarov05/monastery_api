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
    public class TypeItemsController : ControllerBase
    {
        private readonly db_a7d9cd_jojonikilisContext _context;

        public TypeItemsController(db_a7d9cd_jojonikilisContext context)
        {
            _context = context;
        }

        // GET: api/TypeItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeItem>>> GetTypeItems()
        {
            return await _context.TypeItems.ToListAsync();
        }

        // GET: api/TypeItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeItem>> GetTypeItem(int id)
        {
            var typeItem = await _context.TypeItems.FindAsync(id);

            if (typeItem == null)
            {
                return NotFound();
            }

            return typeItem;
        }

        // PUT: api/TypeItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeItem(int id, TypeItem typeItem)
        {
            if (id != typeItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeItemExists(id))
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

        // POST: api/TypeItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeItem>> PostTypeItem(TypeItem typeItem)
        {
            _context.TypeItems.Add(typeItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeItem", new { id = typeItem.Id }, typeItem);
        }

        // DELETE: api/TypeItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeItem(int id)
        {
            var typeItem = await _context.TypeItems.FindAsync(id);
            if (typeItem == null)
            {
                return NotFound();
            }

            _context.TypeItems.Remove(typeItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeItemExists(int id)
        {
            return _context.TypeItems.Any(e => e.Id == id);
        }
    }
}
