using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumMinMaxAverageOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = new List<int>();

                
           for (int i = 1; i <=n; i++)
           {
                var nums = int.Parse(Console.ReadLine());
                result.Add(nums);
           }
           

         
            Console.WriteLine("Sum =  " + result.Sum());

            // print the sum of all parsed numbers in the List(result).


            Console.WriteLine("Min =  " + result.Min());

            // print the smallest number in the List.


            Console.WriteLine("Max =  " + result.Max());

            // print the biggest number in the List.



            Console.WriteLine("Average =  " + result.Average());

            // print the average number from the all numbers in the List.



        }
    }
}
