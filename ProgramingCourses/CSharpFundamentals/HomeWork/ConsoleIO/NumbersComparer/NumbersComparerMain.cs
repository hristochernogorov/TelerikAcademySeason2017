namespace NumbersComparer
{
    using System;

    public class NumbersComparerMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (b > a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
