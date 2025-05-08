using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using WeatherForecast.Services;
using WeatherForecast.Exceptions;
using WeatherForecast.Contracts;


namespace WeatherForecast.Tests
{
    [TestClass]
    public class CityWeatherServiceShould
    {
        private readonly CityWeatherService _cityWeatherService;

        public CityWeatherServiceShould()
        {
            _cityWeatherService = new CityWeatherService();
        }

        [TestMethod]
        public void ThrowsArgumentNullException_IfCityIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => _cityWeatherService.GetWeather(null));
        }

        [TestMethod]
        public void ThrowsCityNotFoundException_IfCityIsFormentera()
        {
            Assert.ThrowsException<CityNotFoundException>(() => _cityWeatherService.GetWeather("Formentera"));
        }

        [TestMethod]
        public void ReturnsWeatherSunny_IfRainProbabilityIsLessThan20()
        {
            var mock = new Mock<IWeatherService>();
            mock.Setup(weatherService => weatherService.RainProbability()).Returns(10);

            var cityWeatherService = new CityWeatherService(mock.Object);
            var result = cityWeatherService.GetWeather("Málaga");
            Assert.AreEqual(Weather.Sunny, result);

        }

        [TestMethod]
        public void ReturnsWeatherCloudy_IfRainProbabiltyIsInRange20And49()
        {
            var mock = new Mock<IWeatherService>();
            mock.Setup(weatherService => weatherService.RainProbability()).Returns(45);

            var cityWeatherService = new CityWeatherService(mock.Object);
            var result = cityWeatherService.GetWeather("Málaga");
            Assert.AreEqual(Weather.Cloudy, result);
        }

        [TestMethod]
        public void ReturnsWeatherRainy_IfRainProbabilityIsInRange50And79()
        {
            var mock = new Mock<IWeatherService>();
            mock.Setup(weatherService => weatherService.RainProbability()).Returns(70);
            var cityWeatherService = new CityWeatherService(mock.Object);
            var result = cityWeatherService.GetWeather("Málaga");
            Assert.AreEqual(Weather.Rainy, result);
        }

        [TestMethod]
        public void ReturnsWeatherStormy_IfRainProbabiltyIs80OrGreater()
        {
            var mock = new Mock<IWeatherService>();
            mock.Setup(weatherService => weatherService.RainProbability()).Returns(80);
            var cityWeatherService = new CityWeatherService(mock.Object);
            var result = cityWeatherService.GetWeather("Málaga");
            Assert.AreEqual(Weather.Stormy, result);
        }
    }
}
