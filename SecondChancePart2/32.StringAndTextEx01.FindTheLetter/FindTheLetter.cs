using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.StringAndTextEx01.FindTheLetter
{
    class FindTheLetter
    {
        static void Main(string[] args)
        {
            char[] inputString = Console.ReadLine().ToCharArray();
            var searchInfo = Console.ReadLine().Split(' ').ToArray();
            char charToFind = char.Parse(searchInfo[0]);
            int occurance = int.Parse(searchInfo[1]);
            int counter = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == charToFind)
                {
                    counter++;
                    if (counter == occurance)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            if (counter < occurance)
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
