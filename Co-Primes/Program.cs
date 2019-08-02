using System;


namespace Co_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end;

            Console.WriteLine("Enter start of range");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end of range");
            end = Convert.ToInt32(Console.ReadLine());


            for (int i = start; i < end; i++)
            {
                for (int j = i + 1; j <= end; j++)
                {
                    if (GCDCalculator.FindGCD(i, j) == 1)
                    {
                        Console.WriteLine($"{i} and {j} are co-primes");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
