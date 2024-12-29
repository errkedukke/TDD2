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

    public string GetMinutesRow1(int minutes)
    {
        var lampsOn = minutes / 5;
        return GetLampRow("Y", 11, lampsOn).Replace("YYY", "YYR");
    }

    public string GetMinutesRow2(int minutes)
    {
        var lampsOn = minutes % 5;
        return GetLampRow("Y", 4, lampsOn);
    }

    private string GetLampRow(string lampColor, int totalLamps, int lampsOn)
    {
        return new string(lampColor[0], lampsOn).PadRight(totalLamps, 'O');
    }
}
