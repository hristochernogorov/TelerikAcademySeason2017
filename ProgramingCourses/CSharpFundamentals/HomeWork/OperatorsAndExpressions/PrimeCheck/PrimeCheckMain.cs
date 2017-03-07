namespace PrimeCheck
{
    using System;

    public class PrimeCheckMain
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (number <= 0 || number == 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }
        }
    }
}
