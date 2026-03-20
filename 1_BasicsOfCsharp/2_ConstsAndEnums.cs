using System;

public class ConstsAndEnums
{
    public static void Run()
    {
        // const ile sabit bir değer tanımlıyoruz (program boyunca değişmez).
        const string constantValue = "This is a constant string.";
        // enum ile anlamlı bir değer kümesi kuruyoruz.
        DaysOfWeek today = DaysOfWeek.Monday;
        
        Console.WriteLine("Day of Week: " + today);
        Console.WriteLine("Constant Value: " + constantValue);
    }

    // Gün adları için enum: sadece önceden tanımlı değerler seçilebilir.
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