using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PrimeNumber
    {
        public void ToCheckPrime()
        {
            int num, m, flag = 0;
            Console.WriteLine("Enter the number To check Number is Prime or Not");
            num = int.Parse(Console.ReadLine());
            m = num / 2;
            for (int i = 2; i < m; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number is Not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
        }

    }
}
