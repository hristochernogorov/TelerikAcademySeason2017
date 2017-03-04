using System;

namespace PrintSequence
{
    public class PrintSequenceMain
    {
        public static void Main()
        {
            var count = 10;
            var number = 2;
            for (int i = 0; i < count; i++)
            {
                if (number % 2 == 0 && count <= 10)
                {
                    Console.WriteLine("{0}", number);
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

