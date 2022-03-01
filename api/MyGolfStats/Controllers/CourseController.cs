#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGolfStats.Data;
using MyGolfStats.Models;

namespace MyGolfStats.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly MyGolfStatsContext _context;

        public CourseController(MyGolfStatsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourse()
        {
            return await _context.Course.ToListAsync();
        }

        [HttpGet("{courseID}")]
        public async Task<ActionResult<Course>> GetCourse(int courseID)
        {
            var course = await _context.Course.FindAsync(courseID);
            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        [HttpPut("{courseID}")]
        public async Task<IActionResult> PutCourse(int courseID, Course course)
        {
            if (courseID != course.CourseID)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.CourseExists(courseID))
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
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();
            return CreatedAtAction("PostCourse", new { courseID = course.CourseID }, course);
        }

        [HttpDelete("{courseID}")]
        public async Task<IActionResult> DeleteCourse(int courseID)
        {
            var course = await _context.Course.FindAsync(courseID);
            if (course == null)
            {
                return NotFound();
            }

            _context.Course.Remove(course);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool CourseExists(int courseID)
        {
            return _context.Course.Any(e => e.CourseID == courseID);
        }
    }
}
