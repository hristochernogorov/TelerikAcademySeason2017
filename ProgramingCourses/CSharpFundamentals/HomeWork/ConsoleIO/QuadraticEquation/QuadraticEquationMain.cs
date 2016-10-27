
namespace QuadraticEquation
{
    using System;
    public class QuadraticEquationMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var sqrtPart = ((b * b) - 4 * a * c);
            double x, x1, x2;
            if (sqrtPart > 0)
            {
                x1 = -b - Math.Sqrt(sqrtPart / (2 * a));
                x2 = -b + Math.Sqrt(sqrtPart / (2 * a));
                if (x1 <= x2)
                {
                    Console.WriteLine("{0:F2}\n{1:F2}", x1, x2);
                }
                else
                {
                    Console.WriteLine("{0:F2}{1:F2}", x2, x1);
                }
            }
            else if (sqrtPart == 0)
            {
                x = (-b + Math.Sqrt(sqrtPart) / (2 * a));
                Console.WriteLine("{0:F2}",x);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
