using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.LargestFiveDigitNumberInASeries
{
    public static partial class Kata
    {
        public static int GetNumber(string str)
        {
            return Enumerable.Range(0, (str.Length - 4))
                .Select(index => str.Substring(index, 5))
                .Select(num => Int32.Parse(num))
                .Max();
        }
    }
}
