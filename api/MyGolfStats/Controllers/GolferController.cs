#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGolfStats.Data;
using MyGolfStats.Models;

namespace MyGolfStats.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class GolferController : ControllerBase
    {
        private readonly MyGolfStatsContext _context;

        public GolferController(MyGolfStatsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Golfer>>> GetGolfer()
        {
            return await _context.Golfer.ToListAsync();
        }

        [HttpGet("{golferID}")]
        public async Task<ActionResult<Golfer>> GetGolfer(int golferID)
        {
            var golfer = await _context.Golfer.FindAsync(golferID);
            if (golfer == null)
            {
                return NotFound();
            }

            return golfer;
        }

        [HttpPut("{golferID}")]
        public async Task<ActionResult<Golfer>> PutGolfer(int golferID, Golfer golfer)
        {
            if (golferID != golfer.GolferID)
            {
                return BadRequest();
            }

            _context.Entry(golfer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.GolferExists(golferID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

			return golfer;
        }

        [HttpPost]
        public async Task<ActionResult<Golfer>> PostGolfer(Golfer golfer)
        {
            _context.Golfer.Add(golfer);
            await _context.SaveChangesAsync();
            return golfer;
		}

        [HttpDelete("{golferID}")]
        public async Task<IActionResult> DeleteGolfer(int golferID)
        {
            var golfer = await _context.Golfer.FindAsync(golferID);
            if (golfer == null)
            {
                return NotFound();
            }

            _context.Golfer.Remove(golfer);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool GolferExists(int golferID)
        {
            return _context.Golfer.Any(e => e.GolferID == golferID);
        }
    }
}
