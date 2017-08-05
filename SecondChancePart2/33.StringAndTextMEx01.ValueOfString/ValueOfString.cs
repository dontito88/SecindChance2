using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.StringAndTextMEx01.ValueOfString
{
    class ValueOfString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string letterCase = Console.ReadLine();
            string upperResultString = string.Empty;
            string lowerResultString = string.Empty;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    lowerResultString += input[i];
                }
                else if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    upperResultString += input[i];
                }
            }

            if (letterCase == "LOWERCASE")
            {
                foreach (var letter in lowerResultString)
                {
                    sum += (int)letter;
                }
                Console.WriteLine($"The total sum is: {sum}");
            }
            else if (letterCase == "UPPERCASE")
            {
                foreach (var letter in upperResultString)
                {
                    sum += (int)letter;
                }
                Console.WriteLine($"The total sum is: {sum}");
            }
        }
    }
}
