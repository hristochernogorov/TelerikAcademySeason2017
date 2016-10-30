namespace BiggestOfTreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TreeNumbersMain
    {
        public static void Main()
        {
            var numbers = new List<double>();
            var length = 3;
            for (int i = 0; i < length; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }
            var biggest = numbers.Max();
            Console.WriteLine(biggest);
        }
    }
}
