using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.LambdaLinqEx02.DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputDictionary = new Dictionary<string, string>();

            while (input != "end")
            {
                var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string first = tokens[0];
                string second = tokens[1];
                if (!inputDictionary.ContainsKey(first))
                {
                    inputDictionary.Add(first, second);
                }
                inputDictionary[first] = second;

                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            foreach (var item in inputDictionary)
            {
                var first = item.Key;
                var second = item.Value;

                if (second == "null")
                {
                    inputDictionary = inputDictionary.ToDictionary(kvp => kvp.Key, kvp => kvp.Value = defaultValue);
                }
            }

            foreach (var couples in inputDictionary)
            {
                var first = couples.Key;
                var second = couples.Value;
                Console.WriteLine($"{first} <-> {second}");
            }
        }
    }
}
