using Microsoft.AspNetCore.Mvc;

namespace GolfStats.Controllers
{
  [ApiController]
  [Route("golf-stats")]
  public class MainController : ControllerBase
  {

    private readonly ILogger<MainController> _logger;

    public MainController(ILogger<MainController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public string GetMessage()
    {
      return "Welcome to Golf Stats!";
    }
  }
}
