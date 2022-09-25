using Microsoft.AspNetCore.Mvc;

namespace MyBudgetPal.Api.Controllers;

[ApiController]
[Route("budget")]
public class BudgetController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<BudgetController> _logger;

    public BudgetController(ILogger<BudgetController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("category")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
