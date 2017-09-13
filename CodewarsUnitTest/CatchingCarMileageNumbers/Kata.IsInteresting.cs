using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.CatchingCarMileageNumbers
{
    public static partial class Kata
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            var result = Enumerable.Range(number, 3)
                .Where(n => IsInterestingImpl(n, awesomePhrases))
                .Select(n => (number - n + 4) / 2)
                .FirstOrDefault();

            Console.WriteLine($"{number}, {string.Join(", ", awesomePhrases.Select(n => n.ToString()).ToArray())} => {result}");

            return result;
        }

        private static bool IsInterestingImpl(int number, IEnumerable<int> awesomePhrases)
        {
            var word = number.ToString();
            if (word.Length <= 2)
                return false;

            return awesomePhrases.Contains(number) ||
                   word.Skip(1).All(c => c == '0') ||
                   word.Skip(1).All(c => c == word[0]) ||
                   "01234567890".Contains(word) ||
                   "09876543210".Contains(word) ||
                   word.SequenceEqual(word.Reverse());

        }
    }
}
