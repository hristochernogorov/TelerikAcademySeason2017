namespace Circle
{
    using System;

    public class CircleMain
    {
        public static void Main()
        {
            var r = double.Parse(Console.ReadLine());
            var area = 0.0;
            var perimeter = 0.0;
            area = Math.PI * (r * r);
            perimeter = 2 * (Math.PI * r);
            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        }
    }
}
