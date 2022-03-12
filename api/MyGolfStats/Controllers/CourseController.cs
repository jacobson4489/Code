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

        [HttpGet("GetCourseByCourseId/{courseId}")]
        public async Task<ActionResult<Course>> GetCourse(int courseId)
        {
            var course = await _context.Course.FindAsync(courseId);
            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        [HttpPut("UpdateCourseByCourseId/{courseId}")]
        public async Task<ActionResult<Course>> PutCourse(int courseId, Course course)
        {
            if (courseId != course.CourseId)
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
                if (!this.CourseExists(courseId))
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

        [HttpDelete("DeleteCourseByCourseId/{courseId}")]
        public async Task<IActionResult> DeleteCourse(int courseId)
        {
            var course = await _context.Course.FindAsync(courseId);
            if (course == null)
            {
                return NotFound();
            }

            _context.Course.Remove(course);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool CourseExists(int courseId)
        {
            return _context.Course.Any(e => e.CourseId == courseId);
        }
    }
}
