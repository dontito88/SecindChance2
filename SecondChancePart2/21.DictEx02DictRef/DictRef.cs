using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.DictEx02DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var resultDict = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();
                string name = tokens[0];
                string cash = tokens[tokens.Length - 1];



                input = Console.ReadLine();
            }
        }
    }
}
