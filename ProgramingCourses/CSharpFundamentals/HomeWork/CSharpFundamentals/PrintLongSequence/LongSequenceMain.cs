namespace PrintLongSequence
{
    using System;

    public class LongSequenceMain
    {
        public static void Main()
        {
            var number = 2;
            var count = 1000;

            for (int i = 0; i < count; i++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("-{0}", number);
                }
                number++;

            }
        }
    }
}
