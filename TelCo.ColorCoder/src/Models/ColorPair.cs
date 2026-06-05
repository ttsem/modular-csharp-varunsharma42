namespace TelCo.ColorCoder.Models
{
    public class ColorPair 
    {
        public System.Drawing.Color MajorColor { get; set; }
        public System.Drawing.Color MinorColor { get; set; }

        public override string ToString() => 
            $"MajorColor:{MajorColor.Name}, MinorColor:{MinorColor.Name}";
    }
}
