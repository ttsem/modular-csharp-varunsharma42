using System;
using System.Drawing;
using TelCo.ColorCoder.Models;

namespace TelCo.ColorCoder.Services
{
    public static class ColorHelper
    {
        private static readonly Color[] _majorColors =
        {
            Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet
        };

        private static readonly Color[] _minorColors =
        {
            Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray
        };

        /// <summary>
        /// Given a pair number, returns the major and minor colors in that order.
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns>ColorPair</returns>
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > 25)
                throw new ArgumentOutOfRangeException(nameof(pairNumber), "Outside allowed range");

            int zeroBased = pairNumber - 1;

            return new ColorPair
            {
                MajorColor = _majorColors[zeroBased / _minorColors.Length],
                MinorColor = _minorColors[zeroBased % _minorColors.Length]
            };
        }

        /// <summary>
        /// Given the two colors, returns the pair number corresponding to them.
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns>Pair number</returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            if (pair == null)
                throw new ArgumentNullException(nameof(pair));

            int majorIndex = Array.IndexOf(_majorColors, pair.MajorColor);
            int minorIndex = Array.IndexOf(_minorColors, pair.MinorColor);

            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException("Unknown colors");

            return (majorIndex * _minorColors.Length) + (minorIndex + 1);
        }
    }
}
