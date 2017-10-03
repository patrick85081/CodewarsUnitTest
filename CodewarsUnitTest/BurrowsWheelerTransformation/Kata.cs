using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsUnitTest.BurrowsWheelerTransformation
{
    public static class Kata
    {
        public static Tuple<string, int> Encode(string s)
        {
            if (string.IsNullOrEmpty(s))
                return Tuple.Create(s, 0);

            // 產生所有組合
            var output = Enumerable.Range(0, s.Length)
                .Select(index => $"{s.Substring(index, s.Length - index)}{s.Substring(0, index)}")
                .OrderAll(s.Length)
                .ToArray();

            // 取得最後一排文字
            var encode = output.Select(word => word.Last())
                .JoinToString();

            // 取得Index
            var number = output.Select((word, i) => new { Index = i, Word = word })
                .Where(item => item.Word == s)
                .First().Index;

            return Tuple.Create(encode, number);
        }

        public static string Decode(string s, int i)
        {
            if (string.IsNullOrEmpty(s) || i < 0)
                return "";

            // 每次新增的文字
            var addWord = s.Select(c => new string(new char[] { c })).ToArray();

            // 新增與排序 取得結果
            var output = addWord.OrderBy(word => word.First())
                .AddItemAndOrder(addWord, s.Length)
                .ElementAt(i);

            return output;
        }


        
    }

    internal static class Ex
    {
        internal static IEnumerable<string> OrderAll(this IEnumerable<string> source, int count)
        {
            var tmp = source.OrderBy(word => word.First());

            foreach (var i in Enumerable.Range(0, count).Skip(1))
                tmp = tmp.ThenBy(word => word.Skip(i).First());

            return tmp;
        }

        internal static IEnumerable<string> AddItemAndOrder(this IEnumerable<string> source, string[] addWord, int count)
        {
            var orderList = source.OrderBy(word => word.First());

            for (var index = 1; index < count; index++)
                orderList = orderList.Select((word, _index) => addWord[_index] + word)
                    .OrderBy(word => word.First());

            return orderList;
        }

        public static string JoinToString(this IEnumerable<char> source)
        {
            return new string(source.ToArray());
        }
    }
}