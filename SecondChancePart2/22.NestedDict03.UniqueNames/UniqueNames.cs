using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.NestedDict03.UniqueNames
{
    class UniqueNames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                result.Add(input);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
