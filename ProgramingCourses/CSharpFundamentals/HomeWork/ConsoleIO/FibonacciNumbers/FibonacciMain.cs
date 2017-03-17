namespace FibonacciNumbers
{
    using System;
    using System.Text;

    public class FibonacciMain
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            long previous = 0;
            long current = 1;
            long next = 1;
            StringBuilder fibonacci = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                current = previous;
                previous = next;
                next = current + next;
                if (i == count - 1)
                {
                    fibonacci.Append(current);
                }
                else
                {
                    fibonacci.Append(current).Append(", ");
                }
            }

            Console.WriteLine(fibonacci);
        }
    }
}
