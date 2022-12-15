using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class ArmstrongNumber
    {
        public static int a, rem, res = 0;
        public void Armstrong(int num)
        {
            a = num;
            while (a != 0)
            {
                rem = a % 10;             //remainder contains the last digit 
                res += rem * rem * rem;
                a = a / 10;               //removing last digit from the original number
            }
            if (res == num)
                Console.WriteLine("Is an Armstrong number ");
            else
                Console.WriteLine("Is not an Armstrong number");
            //return 0;

        }
    }
}
