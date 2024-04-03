namespace SampleWebApplicationModelView.Infrastructure;

public class TimeService : ITimeService
{
    public string GetTime()
    {
        return System.DateTime.Now.ToString("hh:mm:ss");
    }
}

public interface ITimeService
{
    public string GetTime();
}