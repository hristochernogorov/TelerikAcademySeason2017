﻿namespace ExchangeNumbers
{
    using System;
    public class ExchangeNumbersMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("{0} {1}",b,a);
            }
            else if (a<b)
            {
                Console.WriteLine("{0} {1}",a,b);
            }
            else
            {
                Console.WriteLine("{0} {1}",a,b);
            }
        }
    }
}
