using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // declare lambda function
        Func<int, bool> isDivBy = (divBy) =>  year % divBy == 0;      
        return isDivBy(4) && (!isDivBy(100) || isDivBy(400));
        
    }
}