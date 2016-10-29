namespace Interval
{
    using System;
    public class IntervalMain
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = firstNumber; i < secondNumber; i++)
            {

                if (firstNumber < i && secondNumber > i && i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
