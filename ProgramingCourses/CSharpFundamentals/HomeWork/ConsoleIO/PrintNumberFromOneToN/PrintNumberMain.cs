
namespace PrintNumberFromOneToN
{
    using System;
    public class PrintNumberMain
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
