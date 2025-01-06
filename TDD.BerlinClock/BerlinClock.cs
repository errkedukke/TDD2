namespace BrilinClock;

public class BerlinClock
{
    public string GetSecondsLamp(int seconds)
    {
        return seconds % 2 == 0 ? "Y" : "O";
    }

    public string GetHoursRow1(int hours)
    {
        throw new NotImplementedException();
    }

    public string GetHoursRow2(int hours)
    {
        throw new NotImplementedException();
    }
}
