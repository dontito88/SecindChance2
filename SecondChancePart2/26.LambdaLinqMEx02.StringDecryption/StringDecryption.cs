using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.LambdaLinqMEx02.StringDecryption
{
    class StringDecryption
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numsToSkip = numbers[0];
            int numsToTake = numbers[1];
            List<int> cryptedNumbers = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x > 64 && x < 91).ToList();
            List<int> numbersToDecrypt = cryptedNumbers.Skip(numsToSkip).Take(numsToTake).ToList();

            foreach (var item in numbersToDecrypt)
            {
                char symbol = (char)item;
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
