using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.LambdaLinqMEx01.ArrayData
{
    class ArrayData
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double average = inputNumbers.Average();
            inputNumbers.RemoveAll(x => x < average);

            string command = Console.ReadLine();

            switch (command)
            {
                case "Min": Console.WriteLine(inputNumbers.Min());
                    break;
                case "Max": Console.WriteLine(inputNumbers.Max());
                    break;
                case "All": var orderedNums = inputNumbers.OrderBy(x => x).ToList();
                    Console.WriteLine(string.Join(" ", orderedNums));
                    break;
                default:
                    break;
            }
        }
    }
}
