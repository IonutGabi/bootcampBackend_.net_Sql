using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Services;
using Moq;
using WeatherForecast.Contracts;

namespace WeatherForecast.Tests
{
    [TestClass]
    public class RandomWeatherServiceShould
    {
        private readonly RandomWeatherService _randomWeatherService;

        public RandomWeatherServiceShould()
        {
            _randomWeatherService = new RandomWeatherService();
        }

        [TestMethod]
        public void ReturnsANumber_IfRainProbabiltyIsInRange0And100()
        {
            var mock = new Mock<IRandomService>();
            mock.Setup(r => r.Next(0, 101)).Returns(20);
            var weatherService = new RandomWeatherService(mock.Object);
            var result = weatherService.RainProbability();
            Assert.AreEqual(20, result);
        }
    }
}
