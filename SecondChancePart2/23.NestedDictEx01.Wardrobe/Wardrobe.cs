using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.NestedDictEx01.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 0; i < n; i++)
            {
                var inputClothes = Console.ReadLine().Split(new string[] { " -> "}, StringSplitOptions.RemoveEmptyEntries);
                var color = inputClothes[0];
                var clothesList = inputClothes[1].Split(',').ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clothesList)
                {
                    var clothDb = wardrobe[color];
                    if (!clothDb.ContainsKey(item))
                    {
                        clothDb.Add(item, 0);
                    }
                    clothDb[item]++;
                }
            }

            var itemToFind = Console.ReadLine().Split(' ').ToArray();
            var colorToFind = itemToFind[0];
            var clotheToFind = itemToFind[1];



            foreach (var item in wardrobe)
            {
                var color = item.Key;
                var clothesInWardrobe = item.Value;

                Console.WriteLine($"{color} clothes:");

                foreach (var colors in clothesInWardrobe)
                {
                    var clothe = colors.Key;
                    var counter = colors.Value;

                    Console.Write($"* {clothe} - {counter}");

                    if (color == colorToFind && clothe == clotheToFind)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
