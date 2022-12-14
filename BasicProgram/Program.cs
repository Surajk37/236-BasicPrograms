namespace BasicProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //FactorialNo.Fact();

            //PrimeNumber primenumber = new PrimeNumber();
            //primenumber.ToCheckPrime();
            //Console.WriteLine("\tPlease enter number");
            //int sk = Convert.ToInt32(Console.ReadLine());
            //Reverse.ReverseNumber(sk);
            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine("\n\tPlease enter any word to make reverse");
            //Reverse.ReverseWord(Console.ReadLine());
            Console.WriteLine("\t\tFebonacci Series Problem\n");
            Console.WriteLine("Enter a Range ");
            int num = int.Parse(Console.ReadLine());
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.Fibonacci(num);


        }
    }
}