#nullable disable
using System.ComponentModel.DataAnnotations;

namespace MyGolfStats.Models
{
	public class Address
	{
		[Key]
		public int AddressID { get; set; }

		[Required]
		[MaxLength(100)]
		public string Address1 { get; set; }

		[MaxLength(100)]
		public string Address2 { get; set; }

		[Required]
		[MaxLength(100)]
		public string City { get; set; }

		[Required]
		[MaxLength(2)]
		public string State { get; set; }

		[Required]
		[MaxLength(50)]
		public string PostalCode { get; set; }

		[Required]
		[MaxLength(100)]
		public string Country { get; set; }

		[Required]
		public bool IsActive { get; set; }
	}
}
