using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class FibonacciSeries
    {
        public void Fibonacci(int n)
        {
            int val1 = 0, val2 = 1, val3;
            Console.Write(+ val1+ " "+ val2+ " ");
            for(int i = 2; i < n; i++)
            {
                val3 = val1 + val2;
                Console.Write(val3+" ");
                val1 = val2;
                val2 = val3;
            }
        }
    }
}
