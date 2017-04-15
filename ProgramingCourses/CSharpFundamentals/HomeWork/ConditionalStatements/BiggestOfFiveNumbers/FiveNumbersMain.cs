namespace BiggestOfFiveNumbers
{
    using System;
    public class FiveNumbersMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            var e = double.Parse(Console.ReadLine());
            var firstBigNumber = Math.Max(a, b);
            var secondBigNumber = Math.Max(c, d);
            var biggest = Math.Max(Math.Max(firstBigNumber, secondBigNumber), e);
            Console.WriteLine(biggest);

        }
    }
}
