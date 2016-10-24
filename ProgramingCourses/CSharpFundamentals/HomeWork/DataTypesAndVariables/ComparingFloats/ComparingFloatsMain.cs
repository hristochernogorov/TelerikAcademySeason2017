
namespace ComparingFloats
{
    using System;

    public class ComparingFloatsMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            if (Math.Abs(a-b)< 0.000001)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
