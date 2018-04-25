using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                .OrderByDescending(x => x)
                .Take(3);

            // receive input of numbers, reverse them by descending, and take the first 3.


            Console.WriteLine(string.Join(", ",nums));

            // print the collection of numbers separated by ", ".
                




        }
    }
}
