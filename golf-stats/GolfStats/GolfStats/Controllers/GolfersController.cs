using GolfStats.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GolfStats.Controllers
{
  [Authorize]
  [ApiController]
  [Route("golfers")]
  public class GolfersController : ControllerBase
  {
    private readonly ILogger<GolfersController> _logger;

    public GolfersController(ILogger<GolfersController> logger)
    {
      _logger = logger;
    }

    [HttpGet("get-all-golfers")]
    public IEnumerable<Golfer> GetAllGolfers()
    {
      List<Golfer> golfers = new List<Golfer>
      {
        new Golfer
        {
          AspNetUserId = Guid.NewGuid().ToString(),
          FirstName = "Tony",
          LastName = "Jacobson",
          BirthDate = new DateTime(1982, 6, 26),
          IsActive = true
        },

        new Golfer
        {
          AspNetUserId = Guid.NewGuid().ToString(),
          FirstName = "Mark",
          LastName = "Jacobson",
          BirthDate = new DateTime(1982, 6, 26),
          IsActive = true
        },

        new Golfer
        {
          AspNetUserId = Guid.NewGuid().ToString(),
          FirstName = "Eric",
          LastName = "Leonardson",
          BirthDate = new DateTime(1979, 8, 26),
          IsActive = true
        },

        new Golfer
        {
          AspNetUserId = Guid.NewGuid().ToString(),
          FirstName = "Igli",
          LastName = "Arapi",
          BirthDate = new DateTime(1988, 7, 4),
          IsActive = true
        }
      };

      return golfers.ToArray();
    }
  }
}
