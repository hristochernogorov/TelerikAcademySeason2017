
namespace SumThreeRealNumbers
{
    using System;
    public class SumNumbersMain
    {
        public static void Main()
        {
            var firstNum = decimal.Parse(Console.ReadLine());
            var secondNum = decimal.Parse(Console.ReadLine());
            var thirdNum = decimal.Parse(Console.ReadLine());
            var sum = firstNum + secondNum + thirdNum;
            Console.WriteLine(sum);
        }
    }
}
