using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateTriangleAreaByMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CalculateArea(5, 5));

        }


        public static int CalculateArea(int a, int b)
        {
            return a * b;
        }
    }
}
