using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.StringAndTextEx05.PointsCounter
{
    class PointsCounter
    {
        static void Main(string[] args)
        {
            
        }

        private static string RemoveBannedSymbols(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                var checkedSymbol = input[i];
                string finalWord = string.Empty;
                if (checkedSymbol == '@' || checkedSymbol == '%' || checkedSymbol == '$' || checkedSymbol == '*')
                {
                    input.Replace(checkedSymbol, ' ');
                    finalWord = input.Split(' ').ToString();
                }
                return finalWord;
            }
        }
    }
}
