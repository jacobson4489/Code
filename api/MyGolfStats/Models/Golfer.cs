#nullable disable
using System.ComponentModel.DataAnnotations;

namespace MyGolfStats
{
	public class Golfer
	{
		[Key]
		public int GolferID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string EmailAddress { get; set; }

		public DateTime? BirthDate { get; set; }

		public int? Age
		{
			get
			{
				return !this.BirthDate.HasValue ? null : Convert.ToInt32(Math.Truncate(DateTime.Now.Subtract(this.BirthDate.Value).TotalDays * (1 / 365.242199)));
			}
		}

		public bool IsActive { get; set; }

		public DateTime WhenCreated { get; set; }

		public DateTime WhenModified { get; set; }
	}
}