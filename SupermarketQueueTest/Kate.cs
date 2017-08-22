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
            var itor = customers.GetEnumerator();//as IEnumerator<int>;
            var clerks = new int[number];
            
            var totalTime = 0;
            var addTime = 0;

            do
            {
                for (int i = 0; i < number; i++)
                {
                    if (clerks[i] == 0 && itor.MoveNext())
                        clerks[i] = (int)itor.Current;
                }

                addTime = clerks.Where(cc => cc > 0).Count() > 0 ? clerks.Where(cc => cc > 0).Min() : 0;
                totalTime += addTime;
                clerks = clerks.Select(c => c - addTime).ToArray();
            } while (addTime > 0);

            return totalTime;
        }
    }
}
