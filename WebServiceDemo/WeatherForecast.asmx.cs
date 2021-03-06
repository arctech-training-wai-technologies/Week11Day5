using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for WeatherForecast
    /// </summary>
    [WebService(Namespace = "http://worldline.com/myservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherForecast : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string WelcomeMessage(string name)
        {
            return $"Welcome Dear {name}";
        }

        [WebMethod]
        public string GetRainForecastForCity(string cityName)
        {
            return $"Rain of 2 in is forecast in {cityName} today";
        }

        [WebMethod]
        public double GetHumidityForCity(string cityName)
        {
            var random = new Random();
            return random.Next(10, 75);
        }
    }
}
