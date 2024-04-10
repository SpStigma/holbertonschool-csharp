using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 99; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (number % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (number % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine("Buzz");
        }
    }
}
