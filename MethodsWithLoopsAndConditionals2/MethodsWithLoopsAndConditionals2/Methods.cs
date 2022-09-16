using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MethodsWithLoopsAndConditionals2
{
    internal class Methods
    {
        public static void PrintNumberRange()
        {
            for (var range = 1000; range >= -1000; range--)
            {
                Console.WriteLine(range);               
            }
        }

        public static void ThreeByThree()
        {
            for (var triplicate = 3; triplicate <= 999; triplicate += 3)
            {
                Console.WriteLine(triplicate);               
            }
        }

        public static void TwoIntegers(int integerOne, int integerTwo)
        {

            if (integerOne == integerTwo)
            {
                Console.WriteLine("The numbers are equal");
                            }
            else
            {
                Console.WriteLine("The numbers are not equal");
                
            }
        }
        public static void EvenOrOddCheck()
        {
            Console.WriteLine("Please enter a number and we'll check if it's even or odd.\nPress Enter after you've entered the number to see the result");
           
            int input = Convert.ToInt32(Console.ReadLine());

            if ((input % 2) == 0)
            {
               
                Console.WriteLine("The number is even");          
            }
            else
            {
                Console.WriteLine("The number is odd");                
            }

        }

        public static void PosOrNegCheck()
        {
            Console.WriteLine("Please enter a number to check if it's positive or negative then press enter to see the result!");

            int posOrNeg = Convert.ToInt32(Console.ReadLine());

            if (posOrNeg > 0)
            {
                Console.WriteLine("The number is positive");                
            }
            else if (posOrNeg < 0)
            {
                Console.WriteLine("The number is negative");              
            }
            else
            {
                Console.WriteLine("The jokes on you! 0 is neither positive or negative!");
                            }
        }

        public static void VotingEligibility()
        {
            Console.WriteLine("Please enter your age then press Enter to see if you're eligible to vote.");

            int currentAge = Convert.ToInt32(Console.ReadLine());

            if (currentAge > 18)
            {
                Console.WriteLine("statistically, you've used up at least a quarter of your lifespan. \nAlso, if you're a US citizen, you're old enough to vote!");              
            }
            else
            {
                Console.WriteLine("Sorry, you're not quite there yet");              
            }
        }

        public static void TenToTenCheck()
        {
            Console.WriteLine("Please enter a number then press enter and we'll let you know if it's within the range.");
            Console.WriteLine();
            var tenCheck = Convert.ToInt32(Console.ReadLine());

            if (tenCheck > -11 && tenCheck < 11)
            {
                Console.WriteLine("The number is in the range!");              
            }                   
            else
            {
                Console.WriteLine("The number is not in the range of -10 to 10");                
            }
        }

        public static void DisplayMultiplicationTable()
        {
            Console.WriteLine("Please enter a number then press enter to see the multiplication table from 1:12 for your number");

          var givenInt = Convert.ToInt32(Console.ReadLine());

            var multiList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach (var integer in multiList)
            {
                Console.WriteLine($"{integer}x{givenInt}={integer * givenInt}");               
            }
            #region
            //for (int i = 1; i < 12; i++)
            //{
            //    givenInt * 1;
            //    Console.WriteLine();
            //}





            //while (multiInput <13 && multiInput >0)
            //{
            //    ((multiInput++) * 1);
            //    Console.WriteLine();
            //}




            //var x = multiInput;
            //do
            //{
            //    x *=1-12;
            //} while (x<12);

            //Console.WriteLine(x);



            //for (int multiInput = 1; multiInput <= 12; multiInput*=)
            //{
            //    Console.WriteLine(multiInput);
            //}







            //for (int = 1; i < 13; i++)
            //{
            //    listOfNumbers.Add(i);
            //}

            #endregion
        }
    }

}


        


