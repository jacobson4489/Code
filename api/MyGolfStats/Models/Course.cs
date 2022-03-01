#nullable disable
using System.ComponentModel.DataAnnotations;

namespace MyGolfStats.Models
{
	public class Course
	{
		[Key]
		public int CourseID { get; set; }
		
		public string Name { get; set; }
		
		public string Address1 { get; set; }
		
		public string Address2 { get; set; }
		
		public string City { get; set; }
		
		public string State {get; set; }
		
		public string PostalCode { get; set; }
		
		public string Country { get; set; }
		
		public bool IsActive { get; set; }
		
		public DateTime WhenCreated { get; set; }
		
		public DateTime WhenModified { get; set; }
	}
}
