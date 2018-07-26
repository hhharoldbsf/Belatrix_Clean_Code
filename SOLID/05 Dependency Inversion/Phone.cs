using System;

namespace SOLID._05_Dependency_Inversion
{
    public class Phone
    {
        private IWeatherTracker _weatherTracker;
        public Phone(IWeatherTracker weatherTracker)
        {            
            _weatherTracker = weatherTracker;
        }

        public void setCurrentConditions(String currentConditions)
        {
            if (currentConditions == "rainy")
            {
                String alert = _weatherTracker.generateWeatherAlert(currentConditions);
                Console.WriteLine(alert);
            }
            if (currentConditions == "sunny")
            {
                String alert = _weatherTracker.generateWeatherAlert(currentConditions);
                Console.WriteLine(alert);
            }
        }
    }
}
