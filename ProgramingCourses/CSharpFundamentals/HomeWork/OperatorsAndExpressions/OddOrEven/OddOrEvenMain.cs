
namespace OddOrEven
{
    using System;

    public class OddOrEvenMain
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 ==0)
            {
                Console.WriteLine("even {0}",number);
            }
            else
            {
                Console.WriteLine("odd {0}",number);
            }
        }
    }
}
