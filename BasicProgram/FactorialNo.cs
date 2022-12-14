using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class FactorialNo
    {
        public static void Fact()
        {
            int no, fact;
            Console.WriteLine("Enter A Number");
            no = Convert.ToInt32(Console.ReadLine());

            fact = no;

            for (int i = no - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial Number is : {0}", fact);
            Console.ReadLine();
        }
    }
}

 
