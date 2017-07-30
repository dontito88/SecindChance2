using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.LambdaLinqMEx03.Camping
{
    class Camping
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var campersDataBase = new Dictionary<string, Dictionary<string, int>>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(' ').ToArray();
                string name = tokens[0];
                string camper = tokens[1];
                int days = int.Parse(tokens[2]);

                if (!campersDataBase.ContainsKey(name))
                {
                    campersDataBase.Add(name, new Dictionary<string, int>());
                    if (!campersDataBase[name].ContainsKey(camper))
                    {
                        campersDataBase[name].Add(camper, days);
                    }
                }
                campersDataBase[name][camper] = days;

                inputLine = Console.ReadLine();
            }

            var sortedDict = campersDataBase.OrderByDescending(pair => pair.Value.Count).ThenBy(pair => pair.Key.Length);

            foreach (var item in sortedDict)
            {
                string name = item.Key;
                var vehicleData = item.Value;
                Console.WriteLine($"{name}: {vehicleData.Count}");

                int sum = 0;

                foreach (var cars in vehicleData)
                {
                    string truck = cars.Key;
                    int days = cars.Value;
                    sum += days;
                    Console.WriteLine($"***{truck}");
                }

                Console.WriteLine($"Total stay: {sum} nights");
            }
        }
    }
}
