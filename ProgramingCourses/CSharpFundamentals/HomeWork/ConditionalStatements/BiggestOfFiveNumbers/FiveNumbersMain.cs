namespace BiggestOfFiveNumbers
{
    using System;
    public class FiveNumbersMain
    {
        public static void Main()
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var trirdNumber = double.Parse(Console.ReadLine());
            var fourthNumber = double.Parse(Console.ReadLine());
            var fifthNumber = double.Parse(Console.ReadLine());
            var max = 0.0;

            if (firstNumber >= secondNumber &&
                firstNumber >= trirdNumber &&
                firstNumber >= fourthNumber &&
                firstNumber >= fifthNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber >= firstNumber &&
                     secondNumber >= trirdNumber &&
                     secondNumber >= fourthNumber &&
                     secondNumber >= fifthNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (trirdNumber >= firstNumber &&
                     trirdNumber >= secondNumber &&
                     trirdNumber >= fourthNumber &&
                     trirdNumber >= fifthNumber)
            {
                Console.WriteLine(trirdNumber);
            }
            else if (fourthNumber >= firstNumber &&
                    fourthNumber >= secondNumber &&
                    fourthNumber >= trirdNumber &&
                    fourthNumber >= fifthNumber)
            {
                Console.WriteLine(fourthNumber);
            }
            else
            {
                Console.WriteLine(fifthNumber);
            }
        }
    }
}
