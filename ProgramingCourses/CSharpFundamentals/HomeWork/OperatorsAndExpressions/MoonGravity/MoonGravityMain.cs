
namespace MoonGravity
{
    using System;
    public class MoonGravityMain
    {
        public static void Main()
        {
            var weight = float.Parse(Console.ReadLine());
            var moonGravity = 17.0f;
            var weightOnMoon = 1.0f;
            weightOnMoon = (weight / 100) * moonGravity;
            Console.WriteLine("{0:F3}", weightOnMoon);
        }
    }
}
