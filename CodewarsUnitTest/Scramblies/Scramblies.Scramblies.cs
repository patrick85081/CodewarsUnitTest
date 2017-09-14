using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.Scramblies
{
    public static partial class Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            var m = str2.Intersect(str1);
            return m.SequenceEqual(str2);

            // your code
            return str2.All(s => str1.Contains(s));
            
        }
    }
}
