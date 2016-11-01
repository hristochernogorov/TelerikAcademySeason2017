namespace SortTreeNumbers
{
    using System;
    public class SortNumbersMain
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber && firstNumber > thirdNumber ||
                secondNumber > firstNumber && secondNumber > thirdNumber ||
                thirdNumber > firstNumber && thirdNumber > secondNumber)
            {

            }
        }
    }
}
