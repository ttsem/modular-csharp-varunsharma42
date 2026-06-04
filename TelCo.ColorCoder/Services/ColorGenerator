using System;
using TelCo.ColorCoder.Services;

namespace TelCo.ColorCoder.Services
{
    public static class ColorGenerator
    {
        public static void PrintManual()
        {
            Console.WriteLine("--- 25-Pair Color Code Reference Manual ---");
            for (int i = 1; i <= 25; i++)
            {
                var pair = ColorHelper.GetColorFromPairNumber(i);
                Console.WriteLine("Pair {0}: {1}", i, pair);
            }
        }
    }
}
