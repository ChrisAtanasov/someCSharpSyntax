using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();


            var sortedNums = new SortedDictionary<int, int>();

            foreach (var num in nums)
            {
                if (!sortedNums.ContainsKey(num)){
                    sortedNums[num] = 0;
                }
                sortedNums[num]++;
            }

            var result = new List<int>();

            foreach (var item in sortedNums)
            {
                result.Add(item.Key);
            }

            Console.WriteLine(string.Join(", ",result));
             
        }
    }
}
