using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.LambdaLinqMEx04MostValuedCustomers
{
    class MostValuedCustomers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var productDict = new Dictionary<string, double>();

            while (input != "Shop is open")
            {
                var tokens = input.Split(' ');
                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);

                productDict.Add(productName, productPrice);

                input = Console.ReadLine();
            }

            string nextInput = Console.ReadLine();

            while (nextInput != "Print")
            {
                if (nextInput == "Discount")
                {
                    var discountedDict = productDict.OrderByDescending(x => x.Value).Take(3);
                    foreach (var item in discountedDict)
                    {
                        var itemPrice = item.Value;
                        itemPrice = itemPrice - ((10 / 100) * itemPrice);
                    }
                }

                else
                {
                    var tokens = nextInput
                    .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    string nameOfCustomer = tokens[0];
                    List<string> boughtProductsList = tokens[1]
                        .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                }

                nextInput = Console.ReadLine();
            }
        }
    }
}
