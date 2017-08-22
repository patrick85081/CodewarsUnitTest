using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketQueueTest
{
    internal class Kata
    {
        public static long QueueTime(int[] customers, int number)
        {
            var regs = Enumerable.Repeat(0, number).ToList();
            foreach (var cust in customers)
            {
                regs[regs.IndexOf(regs.Min())] += cust;
            }
            return regs.Max();
        }
    }
}
