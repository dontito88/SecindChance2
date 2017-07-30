using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.NestedDictEx03.TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            var travelDict = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "ready")
            {
                var inputTokens = input.Split(':');
                string town = inputTokens[0];
                var vehicleTypeCapacity = inputTokens[1].Split(',');

                input = Console.ReadLine();
            }
        }
    }
}
