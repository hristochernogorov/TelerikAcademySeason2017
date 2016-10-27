
namespace MoonGravity
{
    using System;
    public class MoonGravityMain
    {
        public static void Main()
        {
            double weighOnEarth = double.Parse(Console.ReadLine());
            double weighOnMoon = (weighOnEarth * 17) / 100;
            Console.WriteLine("{0:F3}", weighOnMoon);
        }
    }
}
