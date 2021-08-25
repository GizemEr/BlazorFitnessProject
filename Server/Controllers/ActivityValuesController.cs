using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blazorapp.Shared.Models;

namespace Blazorapp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityValuesController : ControllerBase
    {
        private readonly BlazorContext _context;

        public ActivityValuesController(BlazorContext context)
        {
            _context = context;
        }

        // GET: api/ActivityValues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityValue>>> GetActivityValue()
        {
            return await _context.ActivityValue.ToListAsync();
        }

        // GET: api/ActivityValues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityValue>> GetActivityValue(int id)
        {
            var activityValue = await _context.ActivityValue.FindAsync(id);

            if (activityValue == null)
            {
                return NotFound();
            }

            return activityValue;
        }

        // PUT: api/ActivityValues/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityValue(int id, ActivityValue activityValue)
        {
            if (id != activityValue.Id)
            {
                return BadRequest();
            }

            _context.Entry(activityValue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityValueExists(id))
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

        // POST: api/ActivityValues
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ActivityValue>> PostActivityValue(ActivityValue activityValue)
        {
            _context.ActivityValue.Add(activityValue);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ActivityValueExists(activityValue.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActivityValue", new { id = activityValue.Id }, activityValue);
        }

        // DELETE: api/ActivityValues/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ActivityValue>> DeleteActivityValue(int id)
        {
            var activityValue = await _context.ActivityValue.FindAsync(id);
            if (activityValue == null)
            {
                return NotFound();
            }

            _context.ActivityValue.Remove(activityValue);
            await _context.SaveChangesAsync();

            return activityValue;
        }

        private bool ActivityValueExists(int id)
        {
            return _context.ActivityValue.Any(e => e.Id == id);
        }
    }
}