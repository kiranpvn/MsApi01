using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    class Program2
    {
        static void Main(string[] args)
        {
            Func<int, int> Square = x => x * x;
            Console.WriteLine(Square(5));

            Func<int, int> Cube = x => x * x*x;
            Console.WriteLine(Cube(5));

            Func<int, int, int> Add = (a, b) => a + b;
            Console.WriteLine(Add(5,6));

            Func<int, int, int> Big = (a, b) => a > b?a:b;
            Console.WriteLine(Big(5, 6));

            Func<string, string> Capital = x => x.ToUpper();
            Console.WriteLine(Capital("Kiran Kumar"));

            Func<string, int> Length = x => x.Length;
            Console.WriteLine(Length("Kiran Kumar"));
        }
    }
}
