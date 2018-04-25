using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGreaterNumber(3, 5);

        }


        public static void PrintGreaterNumber(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a < b)
            {
                Console.WriteLine(b);
            }
            else
            {
                return;
            }
        }
    }
}
