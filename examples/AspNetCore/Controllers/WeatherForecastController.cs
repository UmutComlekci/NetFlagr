using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetFlagr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly NetFlagrApiClient _netFlagrService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(NetFlagrApiClient netFlagrService, ILogger<WeatherForecastController> logger)
        {
            _netFlagrService = netFlagrService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var flag = await _netFlagrService.FlagApiService.GetFlagAsync(0);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
