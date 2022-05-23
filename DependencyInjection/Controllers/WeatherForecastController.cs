using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly INumGenerator2 numGenerator2;

        public WeatherForecastController(INumGenerator2 NumGenerator2)
        {
            
            numGenerator2 = NumGenerator2;
        }

        [HttpGet]
        public string Get()
        {
            int random1 = numGenerator2.RandomValue;
            int random2 = numGenerator2.GetNumGeneratorRandomNumber();


            return $"NumGenerator2.RandomValue={random1}, NumGenerator.RandomValue={random2}";
        }
    }
}
