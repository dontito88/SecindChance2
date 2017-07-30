using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.LambdaLinqEx03.ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            var productDict = new Dictionary<string, decimal>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(' ');
                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                if (!productDict.ContainsKey(product))
                {
                    productDict.Add(product, price);
                }
                if (productDict[product] > price)
                {
                    productDict[product] = price;
                }

                inputLine = Console.ReadLine();
            }

            decimal sum = 0;
            foreach (var item in productDict)
            {
                decimal price = item.Value;
                sum += price;
            }

            if (sum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                var sortedDict = productDict
                    .OrderByDescending(pair => pair.Value)
                    .ThenBy(pair => pair.Key.Length)
                    .ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var item in sortedDict)
                {
                    var nameOfProduct = item.Key;
                    var priceOfProduct = item.Value;

                    Console.WriteLine($"{nameOfProduct} costs {priceOfProduct}");
                }
            }
        }
    }
}
