using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using WeatherForecast.Services;
using WeatherForecast.Contracts;

namespace WeatherForecast.Tests
{
    [TestFixture]
    public class RandomWeatherServiceShould
    {
        private RandomWeatherService _randomWeatherService;

        [OneTimeSetUp]
        public void Setup()
        {
            _randomWeatherService = new RandomWeatherService();
        }

        [Test]
        public void ReturnsANumber_IfRainProbabilityIsInRange0And100()
        {
            var mock = new Mock<IRandomService>();
            mock.Setup(m => m.Next(0, 101)).Returns(30);
            var weatherService = new RandomWeatherService(mock.Object);
            var result = weatherService.RainProbability();
            Assert.That(result, Is.EqualTo(30));
        }
    }
}
