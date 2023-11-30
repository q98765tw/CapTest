using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace CapTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly YourService _yourService;
        public WeatherForecastController(YourService yourService)
        {
            
            _yourService = yourService;
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