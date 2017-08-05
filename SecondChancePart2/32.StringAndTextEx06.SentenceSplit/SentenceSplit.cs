using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.StringAndTextEx06.SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char delimiter = char.Parse(Console.ReadLine());
            var result = input.Split(new char[] { delimiter, ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }
}
