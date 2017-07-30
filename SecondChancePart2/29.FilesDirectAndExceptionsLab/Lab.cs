using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _29.FilesDirectAndExceptionsLab
{
    class Lab
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var palidromes = new SortedSet<string>();

            for (int i = 0; i < inputText.Count; i++)
            {
                if (inputText[i].SequenceEqual(inputText[i].Reverse()))
                {
                    palidromes.Add(inputText[i]);
                }
            }

            Console.WriteLine(string.Join(", ", palidromes));
        }
    }
}
