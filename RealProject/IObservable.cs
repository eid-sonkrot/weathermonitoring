﻿namespace RealProject
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void NotifyObservers(WeatherData weatherData);
    }
}