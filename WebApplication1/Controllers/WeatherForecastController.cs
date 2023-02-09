using Furion;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Profiling.Internal;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public dynamic Get()
        {
            var dbOptions = App.GetOptions<DbConnectionOptions>();
            
            return dbOptions;
        }
    }
}