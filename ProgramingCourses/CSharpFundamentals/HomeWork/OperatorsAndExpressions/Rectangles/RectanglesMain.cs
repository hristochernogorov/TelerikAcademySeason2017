namespace Rectangles
{
    using System;

    public class RectanglesMain
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;
            var perimeter = 2 * (width + height);
            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        }
    }
}
