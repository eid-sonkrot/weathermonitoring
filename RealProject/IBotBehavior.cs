namespace RealProject
{
    public interface IBotBehavior
    {
        void Execute(string message, double threshold,WeatherData weatherData);
    }
}