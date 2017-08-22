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
            return customers.Sum() / number;
        }
    }
}
