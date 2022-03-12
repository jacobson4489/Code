#nullable disable
using System.ComponentModel.DataAnnotations;

namespace MyGolfStats.Models
{
	public class Golfer
	{
		[Key]
		public int GolferId { get; set; }

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

		public int? HomeCourseId { get; set; }

		[Required]
		public bool IsActive { get; set; }
	}
}