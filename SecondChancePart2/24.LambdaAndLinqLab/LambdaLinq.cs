using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.LambdaAndLinqLab
{
    class LambdaLinq
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = inputArr.Length / 4;

            int[] leftPart = inputArr.Take(k).Reverse().ToArray();
            int[] rightPart = inputArr.Reverse().Take(3).ToArray();

            int[] middlePart = inputArr.Skip(k).Take(2 * k).ToArray();
            int[] upperPart = leftPart.Concat(rightPart).ToArray();

            for (int i = 0; i < middlePart.Length; i++)
            {
                middlePart[i] += upperPart[i];
            }
                
            Console.WriteLine(string.Join(" ", middlePart));
        }
    }
}
