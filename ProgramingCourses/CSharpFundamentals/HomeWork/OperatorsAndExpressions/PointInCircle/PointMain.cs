namespace PointInCircle
{
    using System;


    public class PointMain
    {
        public static void Main()
        {
            var x = float.Parse(Console.ReadLine());
            var y = float.Parse(Console.ReadLine());
            var center_x = 0.0f;
            var center_y = 0.0f;
            var radius = 2;
            var k = Math.Sqrt((x - center_x) * (x - center_x) + (y - center_y) * (y - center_y));
            if (k <= radius * radius)
            {
                Console.WriteLine("yes {0:F2}", k);
            }
            else
            {
                Console.WriteLine("no {0:F2}", k);
            }

        }
    }
}
