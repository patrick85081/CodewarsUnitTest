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
            var nearNumber = Enumerable.Range(number + 1, 2)
                .Where(n => n != number);
            

            var result = IsInterestingImpl(number, awesomePhrases) ? 2 : 
                (nearNumber.Any(n => IsInterestingImpl(n, awesomePhrases)) ? 1 : 0);

            Console.WriteLine($"{number}, {string.Join(", ", awesomePhrases.Select(n => n.ToString()).ToArray())} => {result}");

            return result;
        }

        private static bool IsInterestingImpl(int number, IEnumerable<int> awesomePhrases)
        {
            return awesomePhrases.Contains(number) || IsSpecialNumber(number);
        }

        private static bool IsSpecialNumber(int number)
        {
            var word = number.ToString();

            if (word.Length <= 2)
                return false;

            return IsAllZero(word) || IsNumberSame(word) || IsPalindrome(word) || IsSequential(word);
        }

        private static bool IsSequential(string word)
        {
            var sequentail = "01234567890";
            var sequentailReverse = "09876543210";

            return sequentail.Contains(word) || sequentailReverse.Contains(word);
        }

        private static bool IsPalindrome(string word)
        {
            var v1 = word.Take(word.Length / 2);
            var v2 = word.Reverse().Take(word.Length / 2);
            var isPalindrome = v1.EnumerableIsSame(v2);
            return isPalindrome;
        }

        private static bool IsNumberSame(string word)
        {
            return word.GroupBy(w => w).Count() == 1;
        }

        private static bool IsAllZero(string word)
        {
            return word.Skip(1).All(w => w == '0');
        }


        private static bool EnumerableIsSame<T>(this IEnumerable<T> source, IEnumerable<T> compare)
        {
            return (source.Count() == compare.Count()) &&
                   source.Zip(compare, (s1, s2) => s1.Equals(s2)).All(result => result);
        }
    }
}
