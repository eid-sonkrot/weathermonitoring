using System;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RealProject
{
    class RealProject
    {
        public static void Main()
        {
            var realProject= new RealProject();
            var weatherStation=new WeatherStation();

            new BotFactory().CreatBots();
            realProject.SubscribeBot(ref weatherStation);
            realProject.HellowMassge();
            Thread.Sleep(1000);
            while (true)
            {
                var Data = (string)(null);
                var weatherData=new WeatherData();

                Data = realProject.UserInput();
                weatherData = realProject.GetWeatherData(Data);
                if( weatherData == null )
                {
                    realProject.WrongDataFormatteMassge();
                    continue;
                }
                weatherStation.UpdateWeatherData(weatherData);
                realProject.PreesAnyKey();
            }
        }
        public string? UserInput()
        {
            Console.Clear();
            Console.WriteLine("Enter weather data : ");
            var Data =Console.ReadLine();

            Console.Clear();
            return Data;
        }
        public void SubscribeBot(ref WeatherStation  weatherStation)
        {
            weatherStation.Subscribe(SunBot.GetSunBot());
            weatherStation.Subscribe(SnowBot.GetSnowBot());
            weatherStation.Subscribe(RainBot.GetRainBot());
        }
        public void HellowMassge()
        {
            Console.WriteLine("welcome to Foothill station");
        }
        public void WrongDataFormatteMassge()
        {
            Console.WriteLine("Wrong Data input");
            Thread.Sleep(1000);
        }
        public void PreesAnyKey()
        {
            Console.Write("Prees Any Key : ");
            Console.ReadKey();
        }
        public WeatherData GetWeatherData(string Data)
        {
            try
            {
                var dataObject = new DataFormateFactory().CreateDataFormate(Data).GetDocument(Data);

                if ( dataObject.GetType() == typeof(JsonDocument))
                {
                    var jsonObject = (JsonDocument) dataObject;

                    return jsonObject.Deserialize<WeatherData>();
                }
                if(dataObject.GetType()==typeof(XDocument))
                {
                    var xmlDoc = (XDocument) dataObject;
                    var serializer = new XmlSerializer(typeof(WeatherData));
                    var weatherData=new WeatherData();

                    using (XmlReader reader = xmlDoc.CreateReader())
                    {
                         weatherData = (WeatherData)serializer.Deserialize(reader);
                    }
                    return weatherData;
                }
                return null;
            }catch(Exception? ex)
            {
                Console.WriteLine($"Invalid data format {ex.Message}");
                return null;
            }
        }
    }
}