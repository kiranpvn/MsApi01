using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqDemo
{
    class Program7
    {
        static void Main(string[] args)
        {           
            List<string>items = new List<string> { "Om","Ashok","Mahesh","Chandu","Suresh","David","Bhagavan","Ganesh","Sri","Rama" };

            Console.WriteLine(items.First());
            Console.WriteLine(items.Last());
            Console.WriteLine(items.ElementAt(2)) ;
            Console.WriteLine(items.Count());

            // foreach ( var item in items.Take(4))
            //foreach (var item in items.Skip(4))
            foreach (var item in items.Skip(2).Take(3))
                Console.WriteLine(item);
            Console.WriteLine();
            
        }
    }
}
//Linq like queries used in built extension methods for fetching data