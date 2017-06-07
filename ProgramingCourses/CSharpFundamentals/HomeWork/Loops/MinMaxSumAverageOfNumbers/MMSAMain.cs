namespace MinMaxSumAverageOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MMSAMain
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            double[] myArr = new double[number];
            var sum = 0.0;
            for (int i = 0; i < number; i++)
            {
                myArr[i]= double.Parse(Console.ReadLine());   
            }
            sum = myArr.Sum();
            var min = myArr.Min();
            var max = myArr.Max();
            var average = myArr.Average();
            Console.WriteLine(" min={0:F2}\n max={1:F2}\n sum={2:F2}\n avg={3:F2}", min, max, sum, average);
        }
    }
}