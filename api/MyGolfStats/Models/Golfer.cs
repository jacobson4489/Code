#nullable disable
using System.ComponentModel.DataAnnotations;

namespace MyGolfStats.Models
{
	public class Golfer
	{
		[Key]
		public int GolferID { get; set; }

		[Required]
		[MaxLength(100)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(100)]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		[MaxLength(100)]
		public string EmailAddress { get; set; }

		public DateTime? BirthDate { get; set; }

		public int? Age
		{
			get
			{
				return !this.BirthDate.HasValue ? null : Convert.ToInt32(Math.Truncate(DateTime.Now.Subtract(this.BirthDate.Value).TotalDays * (1 / 365.242199)));
			}
		}

		[MaxLength(100)]
		public string Nickname { get; set; }

		[Phone]
		[MaxLength(20)]
		public string MobilePhone { get; set; }

		public int? AddressID { get; set; }
		
		public int? HomeCourseID { get; set; }

		[Required]
		public bool IsActive { get; set; }
	}
}