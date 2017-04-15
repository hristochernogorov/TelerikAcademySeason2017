namespace BiggestOfTreeNumbers
{
    using System;
    public class TreeNumbersMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var biggest = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(biggest);
        }
    }

}
