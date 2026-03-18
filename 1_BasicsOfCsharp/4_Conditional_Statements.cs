using System;

public class ConditionalStatements
{
    public static void Run()
    {
        int num = 10;

        // if - else if - else statement
        if(num > 5)
        {
            Console.WriteLine("Number is greater than 5.");
        }
        else if(num > 0 && num <= 5)
        {
            Console.WriteLine("Number is between 1 and 5.");
        }
        else    
        {
            Console.WriteLine("Number is 5 or less.");
        }

        switch(num)
        {
            case 5:
                Console.WriteLine("Number is 1.");
                break;
            case 10:
                Console.WriteLine("Number is 2.");
                break;
            default:
                Console.WriteLine("Number is not 1 or 2.");
                break;
        }
    }
}