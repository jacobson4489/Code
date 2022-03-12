#nullable disable
using System.ComponentModel.DataAnnotations;

namespace MyGolfStats.Models
{
	public class Course
	{
		[Key]
		public int CourseId { get; set; }
		
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[EmailAddress]
		[MaxLength(100)]
		public string EmailAddress { get; set; }

		[Phone]
		[MaxLength(20)]
		public string Phone { get; set; }

		[MaxLength(100)]
		public string Address1 { get; set; }

		[MaxLength(100)]
		public string Address2 { get; set; }

		[MaxLength(100)]
		public string City { get; set; }

		[MaxLength(2)]
		public string State { get; set; }

		[MaxLength(50)]
		public string PostalCode { get; set; }

		[Required]
		public bool IsActive { get; set; }
	}
}
