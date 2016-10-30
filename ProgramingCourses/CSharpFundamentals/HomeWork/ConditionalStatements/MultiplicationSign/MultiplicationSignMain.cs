namespace MultiplicationSign
{
    using System;
    using System.Collections.Generic;
    public class MultiplicationSignMain
    {
        public static void Main()
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var thirdNumber = double.Parse(Console.ReadLine());
            var result = firstNumber * secondNumber * thirdNumber;
            if (result < 0)
            {
                Console.WriteLine("-");
            }
            else if (result > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
