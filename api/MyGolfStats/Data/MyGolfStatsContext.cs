#nullable disable
using Microsoft.EntityFrameworkCore;
using MyGolfStats.Models;

namespace MyGolfStats.Data
{
	public class MyGolfStatsContext : DbContext
    {
        public MyGolfStatsContext (DbContextOptions<MyGolfStatsContext> options)
            : base(options)
        {
        }

        public DbSet<Golfer> Golfer { get; set; }

        public DbSet<Course> Course { get; set; }
    }
}
