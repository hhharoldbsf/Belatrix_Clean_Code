namespace SOLID._05_Dependency_Inversion
{
    public interface IEmailer
    {
        string generateWeatherAlert(string weatherConditions);
    }
}

