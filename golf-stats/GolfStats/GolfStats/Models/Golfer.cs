namespace GolfStats.Models
{
  public class Golfer
  {
    public Golfer() { }
    public string? AspNetUserId { get; set; } = String.Empty;
    public string? FirstName { get; set; } = String.Empty;
    public string? LastName { get; set; } = String.Empty;
    public DateTime? BirthDate { get; set; } = DateTime.MinValue;
    public bool? IsActive { get; set; } = true;
  }
}
