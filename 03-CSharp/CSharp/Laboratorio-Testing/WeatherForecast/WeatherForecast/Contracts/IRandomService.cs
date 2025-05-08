using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Contracts
{
    public interface IRandomService
    {
        int Next(int min, int max);
    }
}
