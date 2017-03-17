namespace SumNumbers
{
    using System;

    public class SumNumbersMain
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (int i = 0; i < count; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
