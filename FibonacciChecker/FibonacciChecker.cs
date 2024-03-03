using System;

namespace FibonacciChecker
{
    class FibonacciNumberChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check whether number is fibonaccie or not");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n))
            {
                if (IsFibonacci(n))
                    Console.WriteLine($"{n} is a Fibonacci number.");
                else
                    Console.WriteLine($"{n} is not a Fibonacci number.");
            }
            else
                Console.WriteLine("Invalid enter a valid integer.");
        }
        static bool IsPerfectSquare(int n)
        {
            int s = (int)Math.Sqrt(n);
            return s * s == n;
        }
        static bool IsFibonacci(int n)
        {
            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }
    }
}
