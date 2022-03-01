#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGolfStats.Data;

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

        [HttpGet("{golferId}")]
        public async Task<ActionResult<Golfer>> GetGolfer(int golferId)
        {
            var golfer = await _context.Golfer.FindAsync(golferId);
            if (golfer == null)
            {
                return NotFound();
            }

            return golfer;
        }

        [HttpPut("{golferId}")]
        public async Task<IActionResult> PutGolfer(int golferId, Golfer golfer)
        {
            if (golferId != golfer.GolferID)
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
                if (!this.GolferExists(golferId))
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

        [HttpPost]
        public async Task<ActionResult<Golfer>> PostGolfer(Golfer golfer)
        {
            _context.Golfer.Add(golfer);
            await _context.SaveChangesAsync();
            return CreatedAtAction("PostGolfer", new { id = golfer.GolferID }, golfer);
        }

        [HttpDelete("{golferId}")]
        public async Task<IActionResult> DeleteGolfer(int golferId)
        {
            var golfer = await _context.Golfer.FindAsync(golferId);
            if (golfer == null)
            {
                return NotFound();
            }

            _context.Golfer.Remove(golfer);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool GolferExists(int golferId)
        {
            return _context.Golfer.Any(e => e.GolferID == golferId);
        }
    }
}
