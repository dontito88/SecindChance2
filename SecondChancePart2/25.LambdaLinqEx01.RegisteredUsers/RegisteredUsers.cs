using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.LambdaLinqEx01.RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var userDict = new Dictionary<string, DateTime>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = tokens[0];
                var dateOfReg = DateTime.ParseExact(tokens[1], string.Format("dd/MM/yyyy"), CultureInfo.InvariantCulture);

                if (!userDict.ContainsKey(user))
                {
                    userDict.Add(user, dateOfReg);
                }

                inputLine = Console.ReadLine();
            }

            var sortedDict = userDict
                     .OrderByDescending(pair => pair.Value)
                     .ToDictionary(pair => pair.Key, pair => pair.Value);

            var finalDict = sortedDict.Take(5);

            foreach (var item in finalDict)
            {
                var name = item.Key;
                Console.WriteLine(name);
            }
        }
    }
}
