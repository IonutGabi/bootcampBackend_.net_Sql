using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using WeatherForecast.Contracts;
using WeatherForecast.Exceptions;
using WeatherForecast.Services;

namespace WeatherForecast.Tests
{
    [TestFixture]
    public class CityWeatherServiceShould
    {
        private CityWeatherService _cityWeatherService;

        [OneTimeSetUp]
        public void Setup() 
        {
            _cityWeatherService = new CityWeatherService();
        }

        [Test]
        public void ThrowsNullArgumentExpection_IfCityIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _cityWeatherService.GetWeather(null));
        }

        [Test]
        public void ThrowsCityNotFoundException_IfCityIsLondon()
        {
            Assert.Throws<CityNotFoundException>(() => _cityWeatherService.GetWeather("London"));
        }

        [Test]
        public void ReturnsWeatherSunny_IfRainProbabilityIsLessThan20()
        {
            var mockWeatherService = new Mock<IWeatherService>();
            mockWeatherService.Setup(ws => ws.RainProbability()).Returns(10);

            var cityWeatherService = new CityWeatherService(mockWeatherService.Object);

            var result = cityWeatherService.GetWeather("Madrid");

            Assert.That(result, Is.EqualTo(Weather.Sunny));
        }

        [Test]
        public void ReturnsWeatherCloudy_IfRainProbabilityIsInRange20And49()
        {
            var mockWetherService = new Mock<IWeatherService>();
            mockWetherService.Setup(ws => ws.RainProbability()).Returns(30);

            var cityWeatherService = new CityWeatherService(mockWetherService.Object);

            var result = cityWeatherService.GetWeather("Madrid");

            Assert.That(result, Is.EqualTo(Weather.Cloudy));
        }

        [Test]
        public void ReturnsWeatherRainy_IfRainProbabilityIsInRange50And79()
        {
            var mockWeatherService = new Mock<IWeatherService>();
            mockWeatherService.Setup(ws => ws.RainProbability()).Returns(60);

            var cityWeatherService = new CityWeatherService(mockWeatherService.Object);

            var result = cityWeatherService.GetWeather("Madrid");

            Assert.That(result, Is.EqualTo(Weather.Rainy));
        }

        [Test]
        public void ReturnsWeatherStormy_IfRainProbabilityIsEqualOrGreaterThan80()
        {
            var mockWeatherService = new Mock<IWeatherService>();
            mockWeatherService.Setup(ws => ws.RainProbability()).Returns(80);

            var cityWeatherService = new CityWeatherService(mockWeatherService.Object);

            var result = cityWeatherService.GetWeather("Madrid");

            Assert.That(result, Is.EqualTo(Weather.Stormy));
        }
    }
}
