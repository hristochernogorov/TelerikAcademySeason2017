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

            var sqrtPart = (b * b) - (4 * a * c);
            var x = ((-1 * b) + Math.Sqrt(sqrtPart)) / (2 * a);
            var y = ((-1 * b) - Math.Sqrt(sqrtPart)) / (2 * a);
            if (sqrtPart > 0)
            {
                if (x > y)
                {
                    Console.WriteLine("{0:F2}\n{1:F2}", y, x);
                }
                else if (x < y)
                {
                    Console.WriteLine("{0:F2}\n{1:F2}", x, y);
                }
            }
            else if (sqrtPart == 0)
            {
                Console.WriteLine("{0:F2}", x);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
