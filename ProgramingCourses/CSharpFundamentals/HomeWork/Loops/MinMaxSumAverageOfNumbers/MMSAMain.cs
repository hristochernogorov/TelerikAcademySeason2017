namespace MinMaxSumAverageOfNumbers
{
    using System;
    using System.Collections.Generic;
    public class MMSAMain
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new List<double>(n);
            var sum = 0.0;
            var average = 0.0;
            for (int i = 0; i < n; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
                sum += numbers[i];
            }
            numbers.Sort();
            average = sum / n;
            Console.WriteLine("min={0:F2}",numbers[0]);
            Console.WriteLine("max={0:F2}",numbers[n-1]);
            Console.WriteLine("sum={0:F2}",sum);
            Console.WriteLine("avg={0:F2}",average);
        }
    }
}
