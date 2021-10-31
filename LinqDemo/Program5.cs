using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    class Program5
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (a, b) => a + b;

            Func<int, int, Func<int, int, int>, int> Calculate = (a, b, cb) => cb(a, b);

            Console.WriteLine(Calculate(10, 9, Add));

            Console.WriteLine(Calculate(25, 5, (a, b) => a > b ? a : b));
            Console.WriteLine(Calculate(25, 5, (a, b) => a < b ? a : b));


            
        }
    }
}