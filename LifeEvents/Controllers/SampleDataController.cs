using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeEvents.Models;
using LifeEvents.Services;
using Microsoft.AspNetCore.Mvc;

namespace LifeEvents.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IEventData _eventData;
        private IGreeter _greeter;

        public SampleDataController(IEventData eventData, IGreeter greeter)
        {
            _eventData = eventData;
            _greeter = greeter;
        }
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts(int startDateIndex)
        {
           
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public Event events(int startDateIndex)
        {
            var model = _eventData.Get(startDateIndex);

            return model;

        }
        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
