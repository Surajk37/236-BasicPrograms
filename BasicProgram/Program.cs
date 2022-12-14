namespace BasicProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //FactorialNo.Fact();

            //PrimeNumber primenumber = new PrimeNumber();
            //primenumber.ToCheckPrime();
            Console.WriteLine("\tPlease enter number");
            int sk = Convert.ToInt32(Console.ReadLine());
            Reverse.ReverseNumber(sk);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\n\tPlease enter any word to make reverse");
            Reverse.ReverseWord(Console.ReadLine());

        }
    }
}