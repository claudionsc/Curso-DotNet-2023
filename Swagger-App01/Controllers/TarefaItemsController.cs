using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swagger_App01.Contexts;
using Swagger_App01.Model;

namespace Swagger_App01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaItemsController : ControllerBase
    {
        private readonly TarefaContexto _context;

        public TarefaItemsController(TarefaContexto context)
        {
            _context = context;
        }

        // GET: api/TarefaItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TarefaItem>>> GetTarefaItems()
        {
          if (_context.TarefaItems == null)
          {
              return NotFound();
          }
            return await _context.TarefaItems.ToListAsync();
        }

        // GET: api/TarefaItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TarefaItem>> GetTarefaItem(long id)
        {
          if (_context.TarefaItems == null)
          {
              return NotFound();
          }
            var tarefaItem = await _context.TarefaItems.FindAsync(id);

            if (tarefaItem == null)
            {
                return NotFound();
            }

            return tarefaItem;
        }

        // PUT: api/TarefaItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarefaItem(long id, TarefaItem tarefaItem)
        {
            if (id != tarefaItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(tarefaItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarefaItemExists(id))
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

        // POST: api/TarefaItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TarefaItem>> PostTarefaItem(TarefaItem tarefaItem)
        {
          if (_context.TarefaItems == null)
          {
              return Problem("Entity set 'TarefaContexto.TarefaItems'  is null.");
          }
            _context.TarefaItems.Add(tarefaItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarefaItem", new { id = tarefaItem.ID }, tarefaItem);
        }

        // DELETE: api/TarefaItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarefaItem(long id)
        {
            if (_context.TarefaItems == null)
            {
                return NotFound();
            }
            var tarefaItem = await _context.TarefaItems.FindAsync(id);
            if (tarefaItem == null)
            {
                return NotFound();
            }

            _context.TarefaItems.Remove(tarefaItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TarefaItemExists(long id)
        {
            return (_context.TarefaItems?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
