using Microsoft.AspNetCore.Mvc;
using modusapi.Models;
using modusapi.Data;

namespace modusapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly ModusDbContext _modusDbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger , ModusDbContext modusDbContext)
        {
            _logger = logger;
            _modusDbContext = modusDbContext;
    }

       /* [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }*/


        [HttpPost(Name = "CreateEmployee")]
       
        public bool Create(employees employee)
        {
            _modusDbContext.Add(employee);
            _modusDbContext.SaveChanges();
            return true;
        }



    }
}