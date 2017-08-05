using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.StringAndTextEx02Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string sentence = inputTokens[0].Trim();
                string[] wordsToFill = inputTokens[1].Trim().Split(new[]{ ' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < wordsToFill.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";
                    sentence = sentence.Replace(currentPlaceholder, wordsToFill[i]);
                }

                 Console.WriteLine(sentence);
                input = Console.ReadLine();
            }
        }
    }
}
