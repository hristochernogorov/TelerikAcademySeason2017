namespace ExchangeNumbers
{
    using System;
    public class ExchangeNumbersMain
    {
        public static void Main()
        {
            var numberA = double.Parse(Console.ReadLine());
            var numberB = double.Parse(Console.ReadLine());
            if (numberA < numberB)
            {
                Console.WriteLine("{0} {1}", numberA, numberB);
            }
            else if (numberB < numberA)
            {
                Console.WriteLine("{0} {1}", numberB, numberA);
            }
            else
            {
                Console.WriteLine("{0} {1}", numberA, numberB);
            }
        }
    }
}
