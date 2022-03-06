#nullable disable
using System.ComponentModel.DataAnnotations;

namespace MyGolfStats.Models
{
	public class Course
	{
		[Key]
		public int CourseID { get; set; }
		
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		public int? AddressID { get; set; }

		[Required]
		public bool IsActive { get; set; }
	}
}
