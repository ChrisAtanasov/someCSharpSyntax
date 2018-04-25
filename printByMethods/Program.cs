using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndDebbuging
{
    class Program
    {
        static void Main(string[] args)
        {
            Blank();

            // print all methods together in blank



        }



        public static void Blank()
        {
            PrintHeader();
            PrintMidle();
            PrintBottom();
        }


        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------");
        }

        public static void PrintMidle()
        {
            Console.WriteLine("Charget To ____________");
            Console.WriteLine("Received by____________");
        }

        public static void PrintBottom()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(" © ");
        }

    }
}

    
