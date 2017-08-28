using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.DecodeTheMorseCodeForReal
{
    public class Preloaded
    {
        public readonly static Dictionary<string, string> MORSE_CODE = new Dictionary<string, string>();

        static Preloaded()
        {
            MORSE_CODE.Add(".-", "A");
            MORSE_CODE.Add("-...", "B");
            MORSE_CODE.Add("-.-.", "C");
            MORSE_CODE.Add("-..", "D");
            MORSE_CODE.Add(".", "E");
            MORSE_CODE.Add("..-.", "F");
            MORSE_CODE.Add("--.", "G");
            MORSE_CODE.Add("....", "H");
            MORSE_CODE.Add("..", "I");
            MORSE_CODE.Add(".---", "J");
            MORSE_CODE.Add("-.-", "K");
            MORSE_CODE.Add(".-..", "L");
            MORSE_CODE.Add("--", "M");
            MORSE_CODE.Add("-.", "N");
            MORSE_CODE.Add("---", "O");
            MORSE_CODE.Add(".--.", "P");
            MORSE_CODE.Add("--.-", "Q");
            MORSE_CODE.Add(".-.", "R");
            MORSE_CODE.Add("...", "S");
            MORSE_CODE.Add("-", "T");
            MORSE_CODE.Add("..-", "U");
            MORSE_CODE.Add("...-", "V");
            MORSE_CODE.Add(".--", "W");
            MORSE_CODE.Add("-..-", "X");
            MORSE_CODE.Add("-.--", "Y");
            MORSE_CODE.Add("--..", "Z");
            //-----------------------
            MORSE_CODE.Add(".----", "1");
            MORSE_CODE.Add("..---", "2");
            MORSE_CODE.Add("...--", "3");
            MORSE_CODE.Add("....-", "4");
            MORSE_CODE.Add(".....", "5");
            MORSE_CODE.Add("-....", "6");
            MORSE_CODE.Add("--...", "7");
            MORSE_CODE.Add("---..", "8");
            MORSE_CODE.Add("----.", "9");
            MORSE_CODE.Add("-----", "0");
            //-----------------------
            MORSE_CODE.Add(".-.-.-", ".");
            MORSE_CODE.Add("--..--", ",");
        }

    }

    // python 解法
    //https://github.com/joshpeng/Python-Morse-Code/blob/6f999a39b488483f91a77031618fd3460064c7ee/morse/morse.py

    // java 解法
    //https://github.com/mgruben/morse-code/blob/master/src/MorseCodeDecoder.java


    public class MorseCodeDecoder
    {
        /**
         * Given a string in Morse Code, returns the English translation.
         *
         * Accept dots, dashes and spaces, returns human-readable message.
         */
        public static string decodeBitsAdvanced(string bits)
        {
            Console.WriteLine($"Raw Data : {bits}");

            var result = bits.StartEndWith(ch => ch == '1')
                .DecodeBits()
                .Replace("111", "-")
                .Replace("1", ".")
                .Replace("0000000", "   ")
                .Replace("000", " ")
                .Replace("0", "");
            return result;
        }

        /**
         * Given a string of bits, which may or may not begin or end with '0's,
         * and which may have some variation in the length of the time unit used,
         * returns the Morse Code translation of this message.
         *
         * Accepts 0s and 1s, return dots, dashes and spaces
         *
         */
        public static string decodeMorse(string morseCode)
        {
            // Map morse code using map Preloaded.MORSE_CODE
            Console.WriteLine($"Input Morse : {morseCode}");

            var words = morseCode.Split(new string[] { "   " }, StringSplitOptions.None)
                .Select(word => word.Split(new char[] { ' ' }, StringSplitOptions.None))
                .Select(word => word.Select(morse => Preloaded.MORSE_CODE.ContainsKey(morse) ? Preloaded.MORSE_CODE[morse] : "").ToArray())
                .Select(word => string.Join("", word))
                .Where(word => word != string.Empty)
                .ToArray();

            var result = string.Join(" ", words);
            Console.WriteLine($"Result : {result}");
            return result;
        }
    }


    static class Helper
    {

        public static string StartEndWith(this string source, Predicate<char> select)
        {
            return source.FirstStartWith(select).LastEndtWith(select).CoverterToString();
        }

        public static string DecodeBits(this string source)
        {
            var rate = source.GetTranslateRate();

            return source.Replace(Enumerable.Repeat("1", rate).CoverterToString(), "1")
                .Replace(Enumerable.Repeat("0", rate).CoverterToString(), "0");
        }

        private static string CoverterToString(this IEnumerable<string> source)
        {

            return string.Join("", source.ToArray());
        }

        private static string CoverterToString(this IEnumerable<char> source)
        {
            return new string(source.ToArray());
        }

        private static IEnumerable<char> FirstStartWith(this IEnumerable<char> source, Predicate<char> select)
        {
            bool isStart = false;
            foreach (var ch in source)
            {
                if (!isStart)
                    isStart = select(ch);

                if (isStart)
                    yield return ch;
            }
        }

        private static IEnumerable<char> LastEndtWith(this IEnumerable<char> source, Predicate<char> select)
        {
            return source.Reverse()
                .FirstStartWith(select)
                .Reverse();
        }

        private static int GetTranslateRate(this string rawData)
        {
            var hCollect = rawData.Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);
            var Hight = hCollect.Length > 0 ? hCollect.Min(single => single.Length) : 999;

            var lCollect = rawData.Split(new char[] { '1' }, StringSplitOptions.RemoveEmptyEntries);
            var Low = lCollect.Length > 0 ? lCollect.Min(single => single.Length) : 999;

            var rate = Math.Min(Hight, Low);
            Console.WriteLine($"速率 : {rate}");
            return rate;
        }
    }
}
