namespace BrilinClock;

public class BerlinClock
{
    public string GetSecondsLamp(int seconds)
    {
        return seconds % 2 == 0 ? "Y" : "O";
    }
}
