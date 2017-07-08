using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.NestedDict01.AverageStudentsGrades
{
    class AverageStudentsGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var resultDict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var tokens = input.Split(' ');
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!resultDict.ContainsKey(name))
                {
                    resultDict[name] = new List<double>();
                }

                resultDict[name].Add(grade);
            }

            foreach (var item in resultDict)
            {
                var name = item.Key;
                var grades = item.Value;
                var gradeString = grades.Select(p => string.Format("{0:f2}", p));
                double average = grades.Average();
                
                Console.WriteLine($"{name} -> {string.Join(" ", gradeString)} (avg: {average:F2})");
            }
        }
    }
}
