using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScaleFinderAPI.Models;

namespace ScaleFinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScaleFinderController : ControllerBase
    {
        private readonly ScaleFinderContext _context;

        public ScaleFinderController(ScaleFinderContext context)
        {
            _context = context;
        }

        // GET: api/ScaleFinder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scale>>> GetScaleItems()
        {
          if (_context.ScaleItems == null)
          {
              return NotFound();
          }
            return await _context.ScaleItems.ToListAsync();
        }

        // GET: api/ScaleFinder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Scale>> GetScale(long id)
        {
          if (_context.ScaleItems == null)
          {
              return NotFound();
          }
            var scale = await _context.ScaleItems.FindAsync(id);

            if (scale == null)
            {
                return NotFound();
            }

            return scale;
        }

        // PUT: api/ScaleFinder/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScale(long id, Scale scale)
        {
            if (id != scale.Id)
            {
                return BadRequest();
            }

            _context.Entry(scale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScaleExists(id))
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

        // POST: api/ScaleFinder
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Scale>> PostScale(Scale scale)
        {
          if (_context.ScaleItems == null)
          {
              return Problem("Entity set 'ScaleFinderContext.ScaleItems'  is null.");
          }
            _context.ScaleItems.Add(scale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScale", new { id = scale.Id }, scale);
        }

        // DELETE: api/ScaleFinder/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScale(long id)
        {
            if (_context.ScaleItems == null)
            {
                return NotFound();
            }
            var scale = await _context.ScaleItems.FindAsync(id);
            if (scale == null)
            {
                return NotFound();
            }

            _context.ScaleItems.Remove(scale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScaleExists(long id)
        {
            return (_context.ScaleItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
