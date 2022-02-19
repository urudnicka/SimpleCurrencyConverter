using System;
using System.Collections.Generic;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            new Calculator();

            Console.WriteLine("Docelowa waluta: ");
            string currency = Console.ReadLine().ToUpper();

            if (!Calculator.IsItACurrency(currency))
            {
                Console.WriteLine("This is not a valid currency.");
                Console.WriteLine("The list of currencies includes:");
                Calculator.ListCurrencies();
                return;
            }

            Console.WriteLine("Wartosc w EUR: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double result = Calculator.ConvertEUR(value, currency);

            Console.WriteLine($"{value} EUR = {result} {currency}");
            Console.WriteLine("Kurs z dnia " + Calculator.Date); 

        }
    }
}
