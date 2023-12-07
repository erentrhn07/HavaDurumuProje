using System;
using System.Net.Http;
using System.Threading.Tasks;
using HavaDurumuProjeOdev;
using Newtonsoft.Json;

namespace HavaDurumuProjeOdev
{
    class Program
    {
        public static async Task Main()
        {
            string starttimeup = ("Date: " + DateTime.Now);
            WeatherData istanbulWeather = await GetWeatherData("https://goweather.herokuapp.com/weather/istanbul");
            WeatherData ankaraWeather = await GetWeatherData("https://goweather.herokuapp.com/weather/ankara");
            WeatherData izmirWeather = await GetWeatherData("https://goweather.herokuapp.com/weather/izmir");

            Console.WriteLine("İstanbul Hava Durumu");
            PrintWeather(istanbulWeather);
            Console.WriteLine("\nAnkara Hava Durumu");
            PrintWeather(ankaraWeather);
            Console.WriteLine("\nİzmir Hava Durumu");
            PrintWeather(izmirWeather);
        }

            public static async Task<WeatherData> GetWeatherData(string apiUrl)
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseData);
                        return weatherData;
                    }
                    else
                    {
                        Console.WriteLine($"Veri  Alınamadı. Status Code: {response.StatusCode}");
                        return null;
                    }
                }
            }

            public static void PrintWeather(WeatherData weatherData)
            {
                if (weatherData != null)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToString("dddd"));
                    Console.WriteLine($"Sıcaklık: {weatherData.Temperature}");
                    Console.WriteLine($"Rüzgar: {weatherData.Wind}");
                    Console.WriteLine($"Durum: {weatherData.Description}");
                    Console.WriteLine("\n");
                    Console.WriteLine("Bir sonraki günlerde görülecek tahmini Hava durumu");

                    DateTime currentDate = DateTime.Now;

                    foreach (var forecast in weatherData.Forecast)
                    {
                        currentDate = currentDate.AddDays(1);

                        Console.WriteLine($"{forecast.Day} Day(s) later: {currentDate.ToString("dd MMMM dddd")}: {forecast.Temperature}, {forecast.Description}, Wind: {forecast.Wind}");
                    }

                    Console.WriteLine("\n");
                }
            }
    }
}