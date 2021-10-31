using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqDemo
{
    class Program6
    {
        {

           // int[] items = new int[] { 5,4,2,1,3 };
            //List<int> items = new List<int> { 100, 200, 300, 400, 500 };

            //string[] items = { "Pencil", "Erase", "Scale", "Sharpner", "Paper" };
             List<string>items = new List<string> { "Om","Ashok","Mahesh","Chandu","Suresh","David","Bhagavan","Ganesh","Sri","Rama" };

            // var query = from item in items orderby item.Length select item;
            //var query = from item in items orderby item descending select item;
            var query = from item in items where item.Substring(item.Length-2)=="sh" select item;
            foreach ( var x in query)
                Console.Write($"{x} ");

            Console.WriteLine();
            
        }
    }
}