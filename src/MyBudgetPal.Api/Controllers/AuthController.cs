using Microsoft.AspNetCore.Mvc;

namespace MyBudgetPal.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("create")]
    // TODO: CREATE NEW USER ENDPOINT
    public Task<IActionResult> CreateNewUser()
    {
        // TODO: CREATE NEW USER ENDPOINT
        return null;
    }

    [HttpGet]
    [Route("login")]
    public Task<IActionResult> Login()
    {
        // TODO: LOG USER IN
        return null;
    }


}
