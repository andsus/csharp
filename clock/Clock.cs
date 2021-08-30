using System;

public class Clock
{

    private const int MinutesInDay = 1440;
    private const double MinutesInHour = 60.0;
    private const int HoursInDay = 24;

    public int Hours { get; }

    public int Minutes { get; }

    public Clock(int hours, int minutes = 0)
    { 
        Hours = Mod((hours * MinutesInHour + minutes) / MinutesInHour, HoursInDay);
        Minutes = Mod(minutes, MinutesInHour);
    }

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);
   
    public Clock Subtract(int minutesToSubtract) => new Clock(Hours, Minutes - minutesToSubtract);
    
    private static int Mod(double x, double y) => (int) ((x % y + y) % y);

    public override string ToString() => $"{Hours:00}:{Minutes:00}";

    public override bool Equals(Object obj)
    {
        Clock otherClock = obj as Clock;

        return otherClock.Hours == Hours && otherClock.Minutes == Minutes;
    }

    public override int GetHashCode() => (HoursInDay * Hours + Minutes) % MinutesInDay;
}
