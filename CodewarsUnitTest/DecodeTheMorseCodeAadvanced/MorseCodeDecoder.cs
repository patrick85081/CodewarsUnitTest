using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.DecodeTheMorseCodeAadvanced
{
    internal partial class MorseCodeDecoder
    {
        // JAVA 解法
        //https://github.com/dkrybachuk/quark-attack/blob/master/codewars/java/4kyu/decode-the-morse-code-advanced/src/main/java/com/dkrybachuk/codewars/decode/the/morse/code/advanced/MorseCodeDecoder.java


        // JS 解法
        //https://github.com/jgardella/Decode-the-morse-code-advanced/blob/master/morseDecode.js

        private static Dictionary<string, string> MorseCode = new Dictionary<string, string>();
        static MorseCodeDecoder()
        {
            MorseCode.Add(".-", "A");
            MorseCode.Add("-...", "B");
            MorseCode.Add("-.-.", "C");
            MorseCode.Add("-..", "D");
            MorseCode.Add(".", "E");
            MorseCode.Add("..-.", "F");
            MorseCode.Add("--.", "G");
            MorseCode.Add("....", "H");
            MorseCode.Add("..", "I");
            MorseCode.Add(".---", "J");
            MorseCode.Add("-.-", "K");
            MorseCode.Add(".-..", "L");
            MorseCode.Add("--", "M");
            MorseCode.Add("-.", "N");
            MorseCode.Add("---", "O");
            MorseCode.Add(".--.", "P");
            MorseCode.Add("--.-", "Q");
            MorseCode.Add(".-.", "R");
            MorseCode.Add("...", "S");
            MorseCode.Add("-", "T");
            MorseCode.Add("..-", "U");
            MorseCode.Add("...-", "V");
            MorseCode.Add(".--", "W");
            MorseCode.Add("-..-", "X");
            MorseCode.Add("-.--", "Y");
            MorseCode.Add("--..", "Z");
            //-----------------------
            MorseCode.Add(".----", "1");
            MorseCode.Add("..---", "2");
            MorseCode.Add("...--", "3");
            MorseCode.Add("....-", "4");
            MorseCode.Add(".....", "5");
            MorseCode.Add("-....", "6");
            MorseCode.Add("--...", "7");
            MorseCode.Add("---..", "8");
            MorseCode.Add("----.", "9");
            MorseCode.Add("-----", "0");
            //-----------------------
            MorseCode.Add(".-.-.-", ".");
            MorseCode.Add("--..--", ",");
        }

        public static String DecodeBits(String bits)
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

        public static String DecodeMorse(String morseCode)
        {
            Console.WriteLine($"Input Morse : {morseCode}");

            var words = morseCode.Split(new string[] { "   " }, StringSplitOptions.None)
                .Select(word => word.Split(new char[] { ' ' }, StringSplitOptions.None))
                .Select(word => word.Select(morse => MorseCode.ContainsKey(morse)? MorseCode[morse]:"").ToArray())
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

        public static string StartEndWith(this string source,Predicate<char> select)
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

            return string.Join("",source.ToArray());
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
