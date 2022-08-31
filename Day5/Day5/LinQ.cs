using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class LinQ
    {
        public static void IntroLinQ()
        {
            int[] number = new int[] {98, 99, 200, 80, 200, 95, 97, 94, 80, 2019};

            // sum from 98 to 2019
            var sum = number.Sum(x => x++);
            Console.WriteLine($"Total : {sum}");

            var min = number.Min();
            Console.WriteLine($"Min : {min}");

            var max = number.Max();
            Console.WriteLine($"Max : {max}");

            var duplicate = number.Distinct();
            Console.WriteLine("After Distinct : ");
            foreach (var item in duplicate)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
