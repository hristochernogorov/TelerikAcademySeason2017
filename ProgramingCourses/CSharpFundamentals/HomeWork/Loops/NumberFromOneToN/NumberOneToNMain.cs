namespace NumberFromOneToN
{
    using System;
    public class NumberOneToNMain
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
