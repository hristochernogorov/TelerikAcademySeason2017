namespace SortTreeNumbers
{
    using System;
    public class SortNumbersMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                if (a > b && a > c && b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);    
                }
                else if (a < b && a < c && b > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else if (a < b && b > c && a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else if (c > a && c > b && a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else if (c > a && c > b && b > a)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }

        }
    }
}
