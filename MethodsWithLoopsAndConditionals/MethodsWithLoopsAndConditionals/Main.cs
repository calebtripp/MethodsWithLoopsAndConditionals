using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Main
    {
        public static void PrintNumberRange()
        {      
            for (var range = -999; range>= -1000 || range<1000; range--)
            {
                Console.WriteLine(range);
            }    
                                
        }
    }
}


//  int n = Convert.ToInt32(Console.ReadLine());
//  if (n > -999 || n < 1001) ? Console.WriteLine(n);
//write all numbers between 1000 - -1000
