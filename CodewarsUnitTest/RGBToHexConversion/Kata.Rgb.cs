using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.RGBToHexConversion
{
    internal partial class Kata
    {
        public static string Rgb(int r, int g, int b)
        {
            r = r < 0 ? 0 : r > 255 ? 255 : r;
            g = g < 0 ? 0 : g > 255 ? 255 : g;
            b = b < 0 ? 0 : b > 255 ? 255 : b;
            return $"{r.ToString("X2")}{g.ToString("X2")}{b.ToString("X2")}";
        }
    }
}
