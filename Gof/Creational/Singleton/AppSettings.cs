using DesignPattern.Creational.Builder;

namespace DesignPattern.Creational.Singleton;

public class AppSettings
{
    public string Key { get; set; }

    private AppSettings()
    {

    }

    public static readonly Lazy<AppSettings> Instance = new(() => new AppSettings());

    public string ApplicationName { get; set; } = "MyApp";

}


public class Caller
{
    public void Call()
    {
        var settings1 = AppSettings.Instance.Value;
        var settings2 = AppSettings.Instance.Value;
        Console.WriteLine(ReferenceEquals(settings1, settings2));  
    }
}
