using GolfStats.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading;

namespace GolfStats.Controllers
{
  [ApiController]
  [Route("golfers")]
  public class GolfersController : ControllerBase
  {
    private readonly ILogger<GolfersController> _logger;

    public GolfersController(ILogger<GolfersController> logger)
    {
      _logger = logger;
    }

    [HttpGet("GetGolferById")]
    public string GetGolfer(int golferId, CancellationToken cancellationToken)
    {
      Golfer golfer = new Golfer {
        Id = golferId,
        FirstName = "Tony",
        LastName = "Jacobson"
      };

      return JsonSerializer.Serialize(golfer);
    }
  }
}
