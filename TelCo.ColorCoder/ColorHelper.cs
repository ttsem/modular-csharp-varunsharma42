using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class ColorHelper
    {
        private static readonly Color[] colorMapMajor = { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
        private static readonly Color[] colorMapMinor = { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > 25)
                throw new ArgumentOutOfRangeException(nameof(pairNumber), "Outside allowed range");

            int zeroBased = pairNumber - 1;
            return new ColorPair { 
                majorColor = colorMapMajor[zeroBased / colorMapMinor.Length], 
                minorColor = colorMapMinor[zeroBased % colorMapMinor.Length] 
            };
        }
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = Array.IndexOf(colorMapMajor, pair.majorColor);
            int minorIndex = Array.IndexOf(colorMapMinor, pair.minorColor);

            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException("Unknown Colors");

            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
