using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaDurumuProjeOdev
{
    public class WeatherData
    {
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Description { get; set; }
        public ForecastData[] Forecast { get; set; }
    }
}