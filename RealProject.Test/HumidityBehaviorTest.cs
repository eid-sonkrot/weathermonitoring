using Moq;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProject.Test
{
    [TestClass]
    public class HumidityBehaviorTest
    {
        [TestMethod]
        public void Test_Humidity_Execute_Behavior()
        {
            //Arange
            var weatherData = new WeatherData()
            {
                Temperature = 90,
                Humidity = 1000
            };
            var botBehaviorMock = new Mock<HumidityBehavior>();
            var botBehavior =botBehaviorMock.Object;
            var threshold = 50;
            var message = "wewew";
            //Act
            //Assert
            botBehavior.Execute(message,threshold, weatherData);
        }
    }
}
