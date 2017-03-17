
namespace PrintNumberFromOneToN
{
    using System;
    public class PrintNumber
    { 
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
