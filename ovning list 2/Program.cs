using System;
using System.Collections.Generic;

namespace övning_list._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 5, 20, 8, 15 };

            int maxNumber = Max(numbers);

            Console.WriteLine("Det största talet är: " + maxNumber);
        }

        static int Max(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Listan är antingen tom eller null.");
            }

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }
    }
}
