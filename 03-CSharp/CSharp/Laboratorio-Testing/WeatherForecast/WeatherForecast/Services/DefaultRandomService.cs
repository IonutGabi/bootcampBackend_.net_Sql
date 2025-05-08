using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Contracts;

namespace WeatherForecast.Services
{
    public class DefaultRandomService: IRandomService
    {
        private readonly Random _random = new Random();

        public int Next(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
