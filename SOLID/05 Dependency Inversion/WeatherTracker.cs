using System;

namespace SOLID._05_Dependency_Inversion
{
    public class WeatherTracker : IWeatherTracker
    { 
        public string generateWeatherAlert(string weatherConditions)
        {
            String alert = "It is " + weatherConditions;
            return alert;
        }
    }
}
