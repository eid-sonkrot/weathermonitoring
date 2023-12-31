﻿using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProject.Test
{
    [TestClass]
    public class SunBotTest
    {
        [TestMethod]
        public void Test_Update_Method()
        {
            //Arange
            var sunBot = SunBot.GetSunBot();
            var fixture = new Fixture();
            var weatherData = fixture.Create<WeatherData>();
            //Act
            //Assert
            sunBot.Update(weatherData);
        }
        [TestMethod]
        public void Test_GetSunBot_Returns_Instance()
        {
            // Arrange & Act
            var bot = SunBot.GetSunBot();
            var type = bot.GetType();
            // Assert
            Assert.IsNotNull(bot);
            Assert.IsInstanceOfType(bot, type);
        }
    }
}
