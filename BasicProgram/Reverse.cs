using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Reverse
    {
        public static void ReverseNumber(int number)//5367
        {
            int remainder = 0, reverse = 0;
            while (number != 0)
            {
                remainder = number % 10; //7  
                reverse = (reverse * 10) + remainder; // 7
                number = number / 10; //536
                Console.WriteLine("Remainder:{0} number:{1} reverse:{2}", remainder, number, reverse);
            }

            Console.WriteLine("Reverse number is : " + reverse);
        }
       
        public static void ReverseWord(string word)
        {
            string reverse = "";
            char[] setOfCharacters = word.ToCharArray();
            Console.WriteLine("\nDisplaying each character");
            for (int i = 0; i < setOfCharacters.Length; i++)
            {
                Console.Write(setOfCharacters[i] + " ");
            }
            for (int i = 0; i < setOfCharacters.Length; i++)
            {
                reverse = setOfCharacters[i] + reverse;
            }
            Console.WriteLine("\n" + reverse);

        }
    }
}

