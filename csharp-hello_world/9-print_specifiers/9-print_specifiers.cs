﻿using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        Console.WriteLine($"Percent: {percent:P2}\nCurrency: {currency.ToString("C2", CultureInfo.GetCultureInfo("en-US"))}");
    }
}
