using Microsoft.AspNetCore.Mvc;
using MyBudgetPal.Interfaces;
using MyBudgetPal.Models;

namespace MyBudgetPal.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    public AuthController(
        ILogger<AuthController> logger,
        IAuthHandler authHandler)
    {
        _logger = logger;
        _authHandler = authHandler;
    }
    private readonly IAuthHandler _authHandler;

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateNewUser(NewUserModel model)
    {
        var result = await _authHandler.CreateNewUser(model).ConfigureAwait(false);
        if (!result.IsSuccessful)
        {
            return BadRequest(result.Message);
        }
        return Ok(result.Data);
    }

    [HttpGet]
    [Route("login")]
    public Task<IActionResult> Login()
    {
        // TODO: LOG USER IN
        return null;
    }


}
