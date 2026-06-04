using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorPair
    {
        public Color majorColor;
        public Color minorColor;

        public override string ToString() => 
            string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
    }
}
