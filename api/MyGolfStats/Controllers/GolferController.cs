using Microsoft.AspNetCore.Mvc;

namespace MyGolfStats.Controllers
{
	[ApiController]
	[Route("Golfer")]
	public class GolferController : ControllerBase
	{
		private readonly ILogger<GolferController> _logger;
		private readonly Golfer golfer = new Golfer
		{
			Id = 1,
			FirstName = "Tony",
			LastName = "Jacobson",
			BirthDate = new DateTime(1982, 6, 26)
		};

		public GolferController(ILogger<GolferController> logger)
		{
			_logger = logger;
		}

		[HttpGet("GetAll")]
		public List<Golfer> GetAll()
		{
			return new List<Golfer>
			{
				golfer
			};
		}

		[HttpGet("GetById/{id}")]
		public Golfer GetById([FromRoute] int id)
		{
			return this.golfer;
		}
	}
}