﻿using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProject.Test
{
    [TestClass]
    public class RainBotTest
    {
        [TestMethod]
        public void Test_Update_Method()
        {
            //Arange
            var rainBot = RainBot.GetRainBot();
            var fixture = new Fixture();
            var weatherData = fixture.Create<WeatherData>();
            //Act
            //Assert
            rainBot.Update(weatherData);
        }
        [TestMethod]
        public void Test_GetRainBot_Returns_Instance()
        {
            // Arrange & Act
            var bot = RainBot.GetRainBot();
            var type = bot.GetType();
            // Assert
            Assert.IsNotNull(bot);
            Assert.IsInstanceOfType(bot, type);
        }
    }
}
