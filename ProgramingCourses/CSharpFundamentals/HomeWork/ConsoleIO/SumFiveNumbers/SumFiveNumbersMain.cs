
namespace SumFiveNumbers
{
    using System;
    public class SumFiveNumbersMain
    {
        public static void Main()
        {
            var sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);

        }
    }
}
