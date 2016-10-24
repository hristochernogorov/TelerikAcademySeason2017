
namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    public class TriangleMain
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var symbol = "©";
            Console.WriteLine("   " + symbol + "   ");
            Console.WriteLine("  " + symbol + " " + symbol + "  ");
            Console.WriteLine(" " + symbol + "   " + symbol + " ");
            Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
        }
    }
}
