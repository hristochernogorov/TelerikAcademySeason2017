namespace UnicodeCharacter
{
    using System;

    public class UnicodeMain
    {
        public static void Main()
        {
            string symbol = null;
            int number = 42;
            symbol = ((char)number).ToString();
            Console.WriteLine(symbol);
        }
    }
}
