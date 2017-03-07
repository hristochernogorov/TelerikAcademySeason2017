namespace PointInCircleAndRectangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PointMain
    {
        public static void Main()
        {
            var x = float.Parse(Console.ReadLine());
            var y = float.Parse(Console.ReadLine());
            var center_x = 1.0f;
            var center_y = 1.0f;
            var radius = 1.5;
            var k = ((x - center_x) * (x - center_x) + (y - center_y) * (y - center_y));
            if (k <= radius * radius)
            {
                Console.WriteLine("inside circle");
            }
            else
            {
                Console.WriteLine("outside circle");
            }
        }
    }
}
