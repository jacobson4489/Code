using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyGolfStats.Controllers
{
	[ApiController]
	[Route("Golfers")]
	public class GolfersController : ControllerBase
	{
		private readonly ILogger<GolfersController> _logger;

		public GolfersController(ILogger<GolfersController> logger)
		{
			_logger = logger;
		}

		[AllowAnonymous]
		[HttpGet("GetAll")]
		public List<Golfer> GetAll()
		{
			List<Golfer> golfers = new List<Golfer>();

			golfers.Add(new Golfer
			{
				Id = 1,
				FirstName = "Tony",
				LastName = "Jacobson",
				BirthDate = new DateTime(1982, 6, 26)
			});

			golfers.Add(new Golfer
			{
				Id = 2,
				FirstName = "Mark",
				LastName = "Jacobson",
				BirthDate = new DateTime(1982, 6, 26)
			});

			golfers.Add(new Golfer
			{
				Id = 3,
				FirstName = "Eric",
				LastName = "Leonardson",
				BirthDate = new DateTime(1980, 5, 1)
			});

			return golfers;
		}

		[AllowAnonymous]
		[HttpGet("GetById/{id}")]
		public Golfer GetById([FromRoute] int id)
		{
			Golfer golfer = new Golfer()
			{
				Id = id,
				FirstName = "Tony",
				LastName = "Jacobson",
				BirthDate = new DateTime(1982, 6, 26)
			};

			return golfer;
		}
	}
}