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
            return customers.Count() > number
                ? customers.Sum() / number
                : (customers.Count() > 0 ? customers.Max() : 0);
        }
    }
}
