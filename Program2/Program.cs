using System;

public class Exercise1
{
    public static void Main()
    {
        int num;
        Console.Write("\n\n");
        Console.Write("See if the number is positive or negative:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Enter a number : ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0)
        
     Console.WriteLine("{0} is a positive number.\n", num);
         else
             Console.WriteLine("{0} is a negative number. \n", num);
    }
}

