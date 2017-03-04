namespace UnicodeCharacter
{
    using System;

    public class UnicodeMain
    {
        public static void Main()
        {
            int valueOfSymbol = 42;
            var hexValueOfSymbol = valueOfSymbol.ToString("X");
            Console.WriteLine(hexValueOfSymbol);
            var symbol = '\x002A';
            Console.WriteLine(symbol);
        }
    }
}
