using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            int int1;
            Console.Write("\n\n");
            Console.Write("Check whether first number bigger than 0:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Modification 1");

            if (int1 > 0)
                Console.WriteLine("The number " + int1 + " is bigger than 0");
            else
                Console.WriteLine("The number " + int1 + " is less than 0");

        }
    }
}
