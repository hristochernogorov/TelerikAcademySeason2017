namespace SumFiveNumbers
{
    using System;

    public class SumFiveNumbersMain
    {
        public static void Main()
        {
            int number = 0;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
