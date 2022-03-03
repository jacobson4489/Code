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

		public bool IsActive { get; set; }

		public int? WhoCreatedID { get; set; }

		public DateTime WhenCreated { get; set; }

		public int? WhoModifiedID { get; set; }

		public DateTime WhenModified { get; set; }
	}
}
