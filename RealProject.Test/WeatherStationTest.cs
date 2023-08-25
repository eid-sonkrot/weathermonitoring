using AutoFixture;
using Moq;

namespace RealProject.Test
{
    [TestClass]
    public class WeatherStationTest
    {
        [TestMethod]
        public void Test_Subscribe_Method()
        {
            //Arange
            var weatherStationMock = new Mock<WeatherStation> ();
            var weatherStation = weatherStationMock.Object;
            var observer=(IObserver)null;
            //Act
            //Assert
            weatherStation.Subscribe(observer);
        }
        [TestMethod]
        public void Test_Unsubscribe_Method()
        {
            //Arange
            var weatherStationMock = new Mock<WeatherStation>();
            var weatherStation = weatherStationMock.Object;
            var observer = (IObserver)null;
            //Act
            //Assert
            weatherStation.Unsubscribe(observer);
        }
        [TestMethod]
        public void Test_NotifyObservers_Method()
        {
            //Arange
            var weatherStationMock = new Mock<WeatherStation>();
            var weatherStation = weatherStationMock.Object;
            var fixture = new Fixture();
            var weatherData= fixture.Create<WeatherData>();
            //Act
            //Assert
            weatherStation.NotifyObservers(weatherData);
        }
        [TestMethod]
        public void Test_UpdateWeatherData_Method()
        {
            //Arange
            var weatherStationMock = new Mock<WeatherStation>();
            var weatherStation = weatherStationMock.Object;
            var fixture = new Fixture();
            var weatherData = fixture.Create<WeatherData>();
            //Act
            //Assert
            weatherStation.UpdateWeatherData(weatherData);
        }
    }
}
