namespace FibonacciNumbers
{
    using System;
    using System.Text;

    public class FibonacciMain
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var previous = 0;
            var next = 1;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                var current = previous;
                previous = next;
                next = current + next;
                if (i == count - 1)
                {
                    builder.Append(current);
                }
                else
                {
                    builder.Append(current).Append(", ");
                }
            }

            Console.WriteLine(builder);
        }
    }
}
