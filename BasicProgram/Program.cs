namespace BasicProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tChoose the program from the below option");
            Console.WriteLine("\n1) Factorial Numbers. \n2) Prime Number.\n3) Reverse Number and String.\n4) Fibonacci Series.");
            Console.WriteLine("5) Armstrong Number. \n6) Sum Of Digits");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FactorialNo.Fact();
                    break;

                case 2:
                    PrimeNumber primenumber = new PrimeNumber();
                    primenumber.ToCheckPrime();
                    break;

                case 3:
                    Console.WriteLine("\tPlease enter number");
                    int sk = Convert.ToInt32(Console.ReadLine());
                    Reverse.ReverseNumber(sk);
                    Console.WriteLine("-------------------------------------");

                    Console.WriteLine("\n\tPlease enter any word to make reverse");
                    Reverse.ReverseWord(Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("\t\tFebonacci Series Problem\n");
                    Console.WriteLine("Enter a Range ");
                    int num = int.Parse(Console.ReadLine());
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci(num);
                    break;

                case 5:
                    Console.WriteLine("\t\tWelcome To Armstrong Number Problem\n");
                    Console.WriteLine("Enter a three Digit Number");
                    int number = int.Parse(Console.ReadLine());
                    ArmstrongNumber arm = new ArmstrongNumber();
                     arm.Armstrong(number);
                    break;
                case 6:
                    SumOfDigit obj = new SumOfDigit();
                    obj.Sum();
                    break;

                default:
                    Console.WriteLine("Please Select a Valid Option");
                    break;

            }
             Console.ReadLine();

        }
    }
}