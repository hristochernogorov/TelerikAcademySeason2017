
namespace ExchangeVariableValues
{
    using System;
    public class ExchangeValuesMain
    {
        public static void Main()
        {
            var a = 5;
            var b = 10;
            Console.WriteLine("Before exchange");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
            var c = a;
            a = b;
            b = c;
            Console.WriteLine("After exchange:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
        }
    }
}
