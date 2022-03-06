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

        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourse()
        {
			return await _context.Course.ToListAsync();
        }

        [HttpGet("GetCourseByCourseID/{courseID}")]
        public async Task<ActionResult<Course>> GetCourse(int courseID)
        {
            var course = await _context.Course.FindAsync(courseID);
            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        [HttpPut("UpdateCourseByCourseID/{courseID}")]
        public async Task<ActionResult<Course>> PutCourse(int courseID, Course course)
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

			return course;
        }

        [HttpPost("InsertCourse")]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();
			return course;
        }

        [HttpDelete("DeleteCourseByCourseID/{courseID}")]
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
