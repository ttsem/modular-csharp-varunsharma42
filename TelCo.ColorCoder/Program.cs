using TelCo.ColorCoder.Tests;
using TelCo.ColorCoder.Services;

namespace TelCo.ColorCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            TelCoTests.RunTests();
            ColorGenerator.PrintManual();
        }
    }
}
