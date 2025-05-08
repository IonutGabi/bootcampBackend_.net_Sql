using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Contracts;

namespace WeatherForecast.Services
{
    public class RandomWeatherService : IWeatherService
    {
        private readonly IRandomService _randomService;

        public RandomWeatherService()
        {
        }

        public RandomWeatherService(IRandomService randomService)
        {
            _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
        }
        public int RainProbability()
        {
            return _randomService.Next(0, 101);
        }
    }
}
