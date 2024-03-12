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
            int[] numbers = { 1, 2, 3, 4, 5 };
            double average = MathUtils.CalculateAverage(numbers);
            Console.WriteLine($"The average is: {average}");

        }
    }
}
