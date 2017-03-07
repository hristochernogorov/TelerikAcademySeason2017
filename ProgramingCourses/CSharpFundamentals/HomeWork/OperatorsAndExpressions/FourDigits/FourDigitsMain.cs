namespace FourDigits
{
    using System;
    public class FourDigitsMain
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var number = int.Parse(input);
            var sum = 0;
            int d = number % 10;
            int c = (number / 10) % 10;
            int b = (number / 100) % 10;
            int a = (number / 1000) % 10;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
            Console.WriteLine("{0}{1}{2}{3}",d,a,b,c);
            Console.WriteLine("{0}{1}{2}{3}",a,c,b,d);
        }
    }
}
