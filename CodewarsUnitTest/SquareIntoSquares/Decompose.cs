using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.SquareIntoSquares
{
    public partial class Decompose
    {

        public string decompose(long n)
        {
            var list = new List<long>();
            DecomposeHelper(n * n, n - 1,ref list);
            list.Reverse();
            return list.Any() ? string.Join(" ", list) : null;
        }

        private bool DecomposeHelper(long n, long value, ref List<long> list)
        {
            if (n == 0)
                return true;

            for (var i = value; i > 0; i--)
            {
                if (n < 0)
                    return false;
                else if (n - (i * i) >= 0)
                {
                    var tmp = new List<long>(list);

                    list.Add(i);
                    var nextN = n - (i * i);


                    var result = DecomposeHelper(nextN, i - 1, ref list);
                    if (result)
                        return true;
                    list = tmp;
                }
            }
            return false;
        }
    }
}
