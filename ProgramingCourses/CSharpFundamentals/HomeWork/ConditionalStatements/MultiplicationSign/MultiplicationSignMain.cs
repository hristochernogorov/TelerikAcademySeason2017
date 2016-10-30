namespace MultiplicationSign
{
    using System;
    using System.Collections.Generic;
    public class MultiplicationSignMain
    {
        public static void Main()
        {
            var number = 0;
            var lenght = 3;
            var numbers = new List<int>();
            for (int i = 0; i < lenght; i++)
            {
                number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

        }
    }
}
