namespace MyGolfStats
{
	public class Golfer
	{
		public int Id { get; set; }

		public string FirstName { get; set; } = String.Empty;

		public string LastName { get; set; } = String.Empty;

		public string EmailAddress { get; set; } = String.Empty;

		public DateTime? BirthDate { get; set; }

		public int? Age
		{
			get
			{
				return !this.BirthDate.HasValue ? null : Convert.ToInt32(Math.Truncate(DateTime.Now.Subtract(this.BirthDate.Value).TotalDays * (1 / 365.242199)));
			}
		}
	}
}