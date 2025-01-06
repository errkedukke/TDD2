namespace BrilinClock;

public class BerlinClock
{
    public string GetSecondsLamp(int seconds)
    {
        return seconds % 2 == 0 ? "Y" : "O";
    }

    public string GetHoursRow1(int hours)
    {
        var lampsOn = hours / 5;
        return GetLampRow("R", 4, lampsOn);
    }

    public string GetHoursRow2(int hours)
    {
        var lampsOn = hours % 5;
        return GetLampRow("R", 4, lampsOn);
    }

    private string GetLampRow(string lampColor, int totalLamps, int lampsOn)
    {
        return new string(lampColor[0], lampsOn).PadRight(totalLamps, 'O');
    }
}
