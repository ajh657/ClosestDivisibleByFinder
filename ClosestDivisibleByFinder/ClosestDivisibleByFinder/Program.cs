using System;

namespace ClosestDivisibleByFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int dividingNumber = int.Parse(args[0]);
                int divisibleByNumber = int.Parse(args[1]);

                for (int i = dividingNumber; i > 0; i--)
                {
                    if (i % divisibleByNumber == 0)
                    {
                        Console.WriteLine($"{i} is divisible by {divisibleByNumber}");
                    }
                }
            }
        }
    }
}
