using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest
{
    internal partial class Kata
    {
        public static long QueueTime(int[] customers, int number)
        {
            // 最佳解法
            var regs = Enumerable.Repeat(0, number).ToList();
            foreach (var cust in customers)
            {
                regs[regs.IndexOf(regs.Min())] += cust;
            }
            return regs.Max();

            // 原本寫法
            //var itor = customers.GetEnumerator();
            //var clerks = new int[number];
            
            //    var totalTime = 0;
            //var addTime = 0;

            //do
            //{
            //    for (int i = 0; i < number; i++)
            //    {
            //        if (clerks[i] == 0 && itor.MoveNext())
            //            clerks[i] = (int) itor.Current;
            //    }

            //    addTime = clerks.Where(cc => cc > 0).Count() > 0 ? clerks.Where(cc => cc > 0).Min() : 0;
            //    totalTime += addTime;
            //    clerks = clerks.Select(c => c - addTime).ToArray();
            //} while (addTime > 0);

            //return totalTime;
        }
    }
}
