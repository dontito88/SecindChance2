using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.NestedDictEx04.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var resultDict = new Dictionary<string, HashSet<int>>();

            while (inputLine != "Aggregate")
            {
                var inputTokens = inputLine.Split(' ');
                string region = inputTokens[0];
                int shellSize = int.Parse(inputTokens[1]);

                if (!resultDict.ContainsKey(region))
                {
                    resultDict[region] = new HashSet<int>();
                    resultDict[region].Add(shellSize);
                }
                resultDict[region].Add(shellSize);

                inputLine = Console.ReadLine();
            }

            foreach (var item in resultDict)
            {
                var regionForPrint = item.Key;
                var shellSizesForPring = item.Value;
                var sumOfShells = shellSizesForPring.Sum();
                var giantShell = sumOfShells - sumOfShells / shellSizesForPring.Count;

                Console.WriteLine($"{regionForPrint} -> {string.Join(", ", shellSizesForPring)} ({giantShell})");
            }
        }
    }
}
