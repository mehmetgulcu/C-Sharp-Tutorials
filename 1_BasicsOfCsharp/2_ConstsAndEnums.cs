using System;

public class ConstsAndEnums
{
    public static void Run()
    {
        const string constantValue = "This is a constant string.";
        DaysOfWeek today = DaysOfWeek.Monday;
        
        Console.WriteLine("Day of Week: " + today);
        Console.WriteLine("Constant Value: " + constantValue);
    }

    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}