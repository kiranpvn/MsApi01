using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    class Program4
    {
        static void Main(string[] args)
        {
            Func<int, int> Square = x => x * x;
            Func<int, int> Next= x => x + 1;

            Func<int, Func<int, int>, int > Calculate = (x, cb) => cb(x);

            Console.WriteLine( Calculate(5,Square) );
            Console.WriteLine(Calculate(3, Next));

            Console.WriteLine(Calculate(5, x=>x*x*x));


            Action<int , Func<int,int>> display = (x,cb) => Console.WriteLine(cb(x));
        }
    }
}