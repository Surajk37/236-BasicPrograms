using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class SumOfDigit
    {
        public int Sum()
        {
            Console.WriteLine("\n\tWelcome To Sum Of Digits Program");
            int n, m,add=0;
            Console.WriteLine("Enter a Number To Display addition of Digit");
            n = Convert.ToInt32(Console.ReadLine());

            while(n > 0)
            {
                
                m = n % 10; 
                add += m;
                n /= 10;
            }
            Console.WriteLine("Sum of Digits Are : {0}", add);
            return 0;
        }
    }
}
