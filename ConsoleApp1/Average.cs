using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MathUtils
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty.");
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }


        public static int FindMaxValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty.");
            }

            int maxValue = numbers[0];
            foreach (int num in numbers)
            {
                if (num > maxValue)
                {
                    maxValue = num;
                }
            }

            return maxValue;
        }
    }
}