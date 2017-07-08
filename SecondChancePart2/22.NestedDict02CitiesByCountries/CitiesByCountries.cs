using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.NestedDict02CitiesByCountries
{
    class CitiesByCountries
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var resultDict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!resultDict.ContainsKey(continent))
                {
                    resultDict[continent] = new Dictionary<string, List<string>>();
                }
                if (!resultDict[continent].ContainsKey(country))
                {
                    resultDict[continent][country] = new List<string>();
                }
                resultDict[continent][country].Add(city);
            }

            foreach (var content in resultDict)
            {
                var continentName = content.Key;
                var countryName = content.Value;
                Console.WriteLine($"{continentName}: ");

                foreach (var item in countryName)
                {
                    var country = item.Key;
                    var city = item.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
