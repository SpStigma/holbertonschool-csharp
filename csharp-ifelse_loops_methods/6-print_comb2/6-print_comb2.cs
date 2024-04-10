using System;

class Program
{
    static void Main(string[] args)
    {
        bool needComma = false;

        for (int number = 0; number <= 9; number++)
        {
            for (int secondNumber = number + 1; secondNumber <= 9; secondNumber++)
            {
                if (needComma)
                {
                    Console.Write(", ");
                }
                Console.Write($"{number}{secondNumber}");

                needComma = true;
            }
        }
        Console.WriteLine();
    }
}
