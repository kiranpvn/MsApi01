using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqDemo
{
    class Program8
    {
        static void Main(string[] args)
        {
            int[] payments = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine(payments.First());
            Console.WriteLine(payments.ElementAt(2));
            Console.WriteLine(payments.Last());

            Console.WriteLine(payments.Sum());
            Console.WriteLine(payments.Count());
            Console.WriteLine(payments.Average());
            Console.WriteLine(payments.Max());
            Console.WriteLine(payments.Min());

            Console.WriteLine();
            
        }
    }
}