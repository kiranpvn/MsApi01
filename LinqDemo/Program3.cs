using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    class Program3
    {
        static void Main(string[] args)
        {
            Predicate<int> IsZero = x => x == 0;
            Predicate<int> IsEven= x => x %2== 0;
            Predicate<int> IsOdd = x => x %2== 1;


            int n = 2;
            if ( IsZero(n))
                Console.WriteLine("Input is zero");
            else if ( IsEven(n))
                Console.WriteLine($"{n} is even");
            else if (IsOdd(n))
                Console.WriteLine($"{n} is Odd");
        }
    }
}
/*
 Task:  IsEven()
 * IsPositiveNumber()
 */
