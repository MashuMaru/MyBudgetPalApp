using Microsoft.AspNetCore.Mvc;
using MyBudgetPal.Models;

namespace MyBudgetPal.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("create")]
    public HandlerResultModel<Guid> CreateNewUser(NewUserModel model)
    {
        var specialCode = Guid.NewGuid();
        return new HandlerResultModel<Guid>()
        {
            Data = specialCode,
            Message = "Successfully created user.",
            IsSuccessful = true
        };
    }

    [HttpGet]
    [Route("login")]
    public Task<IActionResult> Login()
    {
        // TODO: LOG USER IN
        return null;
    }


}
