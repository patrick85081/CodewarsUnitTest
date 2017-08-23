using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest
{
    internal partial class Kata
    {
        public static int[] SortArray(int[] array)
        {
            // 最佳解法
            Queue<int> odds = new Queue<int>(array.Where(num => num % 2 == 1).OrderBy(num => num));

            return array.Select(num => num % 2 == 1 ? odds.Dequeue() : num).ToArray();

            // 原本的寫法
            //var result = new int[array.Length];
            //array.CopyTo(result, 0);

            //var items = array.Select((Value, Index) => new {Value, Index})
            //    .Where(item => item.Value % 2 == 1);

            //var values = items.OrderBy(item => item.Value).Select(item => item.Value);
            //var indexs = items.OrderBy(item => item.Index).Select(item => item.Index);

            //values.Merge(indexs, (v, i) => new {Value = v, Index = i})
            //    .ToList()
            //    .ForEach(item => result[item.Index] = item.Value);


            //return result;
        }
    }

    //internal static class EX
    //{
    //    public static IEnumerable<TResult> Merge<TInput1, TInput2, TResult>(this IEnumerable<TInput1> source,
    //        IEnumerable<TInput2> second, Func<TInput1, TInput2, TResult> selector)
    //    {
    //        var a = source.GetEnumerator();
    //        var b = second.GetEnumerator();

    //        while (a.MoveNext() && b.MoveNext())
    //        {
    //            yield return selector.Invoke(a.Current, b.Current);
    //        }
    //    }
    //}
}
