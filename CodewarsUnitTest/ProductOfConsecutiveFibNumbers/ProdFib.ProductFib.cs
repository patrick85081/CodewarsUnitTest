using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest
{
    internal static partial class ProdFib
    {
        public static ulong[] ProductFib(ulong prod)
        {
            var i = 0;

            ulong FnM1 = 0ul;
            ulong Fn = 0ul;
            ulong currentProd = 0ul;
            do
            {
                FnM1 = GetFibonacciNumber(i - 1 > 0 ? i - 1 : 0);
                Fn = GetFibonacciNumber(i);

                currentProd = FnM1 * Fn;

                i++;
            } while (currentProd < prod);

            return new ulong[] {FnM1, Fn, (currentProd == prod ? 1ul : 0ul)};
        }

        static ulong GetFibonacciNumber(int number)
        {
            var phi = (1 + Math.Sqrt(5)) / 2;

            var result = Math.Pow(phi, number) / Math.Sqrt(5);

            return Convert.ToUInt64(result);
        }
    }
}
