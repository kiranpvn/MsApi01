using System;

namespace LinqDemo
{
    class Program1
    {
        static void Main(string[] args)
        {
            Action display = () =>
            {
                Console.WriteLine("Hello, welcome!");
            };

            display();

            Action <string> wishes = x => Console.WriteLine($"Hello {x}");
            wishes("Kiran");
        }
    }
}