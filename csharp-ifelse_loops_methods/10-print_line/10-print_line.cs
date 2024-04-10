using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
        }
        else
        {
            for (int numberToPrinted = 0; numberToPrinted < length; numberToPrinted++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
}
