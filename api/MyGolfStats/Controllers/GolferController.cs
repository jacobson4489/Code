using Microsoft.AspNetCore.Mvc;

namespace MyGolfStats.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GolfersController : ControllerBase
	{
		private readonly ILogger<GolfersController> _logger;
		private readonly Golfer golfer = new Golfer
		{
			Id = 1,
			FirstName = "Tony",
			LastName = "Jacobson",
			BirthDate = new DateTime(1982, 6, 26)
		};

		public GolfersController(ILogger<GolfersController> logger)
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