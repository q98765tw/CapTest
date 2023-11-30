using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace CapTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly YourService _yourService;
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICapSubscribe capSubscribe;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, YourService yourService)
        {
            _logger = logger;
            _yourService = yourService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost("publish")]
        public async Task<IActionResult> PublishEvent()
        {
            // 在控制器中调用服务层来发布事件
            await _yourService.PublishEvent();

            return Ok("Event published successfully");
        }
    }
}