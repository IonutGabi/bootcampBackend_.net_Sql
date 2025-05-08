using WeatherForecast.Services;

var randomService = new DefaultRandomService();
var cityWeatherService = new CityWeatherService(new RandomWeatherService(randomService));
var weather = cityWeatherService.GetWeather("Madrid");

Console.WriteLine($"The weather in Madrid is {weather}");
