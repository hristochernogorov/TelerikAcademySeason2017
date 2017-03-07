namespace ThirdDigit
{
    using System;

    public class ThirdDigitMain
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var thirdDigit = (input / 100);
            if ( thirdDigit % 10 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                var lastDigit = thirdDigit % 10;
                Console.WriteLine("false {0}",lastDigit);
            }
        }
    }
}
