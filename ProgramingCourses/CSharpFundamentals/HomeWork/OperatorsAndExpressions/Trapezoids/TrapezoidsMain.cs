namespace Trapezoids
{
    using System;

    public class TrapezoidsMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = 0.0;
            area = ((a + b) * h) / 2;
            Console.WriteLine("{0:F7}", area);
        }
    }
}
