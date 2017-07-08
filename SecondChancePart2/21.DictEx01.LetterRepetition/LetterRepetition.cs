namespace ex01.LetterRepetition
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LetterRepetition
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var lettersCount = new Dictionary<char, int>();

            foreach (var letter in inputString)
            {
                if (!lettersCount.ContainsKey(letter))
                {
                    lettersCount[letter] = 0;
                }
                lettersCount[letter]++;
            }

            foreach (var letterCountPairs in lettersCount)
            {
                var letter = letterCountPairs.Key;
                var count = letterCountPairs.Value;
                Console.WriteLine($"{letter} -> {count}");
            }
        }
    }
}
