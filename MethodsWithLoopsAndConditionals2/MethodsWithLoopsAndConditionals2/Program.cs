

using MethodsWithLoopsAndConditionals2;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, welcome to my program!");
        Console.WriteLine("Press the Enter key to see a range of numbers from 1000 to -1000. ");      
        Console.ReadLine();       
        Methods.PrintNumberRange();
        Console.WriteLine();
       
        Console.WriteLine("Next you'll see counting by 3 from 3 to 999.");
        Console.WriteLine("Press Enter key to continue...");
        Console.ReadLine();
        Methods.ThreeByThree();
        Console.WriteLine();        

        Console.WriteLine("Now we're comparing 8 and 7634 see if they're equal.");
        Console.WriteLine("Press Enter key to continue...");
        Console.ReadLine();
        Methods.TwoIntegers(8, 7634);
        Console.WriteLine();

        Console.WriteLine("Here we're checking to see if a number is even or odd.");
        Console.WriteLine("Press Enter key to continue...");
        Console.ReadLine();
        Methods.EvenOrOddCheck();
        Console.WriteLine();

        Console.WriteLine("Next we're checking to see if a number is positive or negative" );
        Console.WriteLine("Press Enter key to continue...");
        Console.ReadLine();
        Methods.PosOrNegCheck();
        Console.WriteLine();

        Console.WriteLine("Now we're checking to see if you're old enough to vote");
        Console.WriteLine("Press Enter key to continue...");
        Console.ReadLine();
        Methods.VotingEligibility();
        Console.WriteLine();

        Console.WriteLine("Next we're checking to see if your number is within the range of -10 : 10");    
        Methods.TenToTenCheck();
        Console.WriteLine();

        Console.WriteLine("Finally we're writing out the multiplication table from 1 : 12 for a number you provide");
        Console.WriteLine("Press Enter key to continue...");
        Console.ReadLine();
        Methods.DisplayMultiplicationTable();
        Console.WriteLine();
        Console.WriteLine("Thanks for using my program, have a good one!");

    }
    
 
}

