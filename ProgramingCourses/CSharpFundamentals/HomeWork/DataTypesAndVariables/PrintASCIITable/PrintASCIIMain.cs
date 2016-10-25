
namespace PrintASCIITable
{
    using System;
    public class PrintASCIIMain
    {
        public static void Main()
        {
            var startSymbol = 33;
           var endSymbol = 126;
            for (int i = startSymbol; i <= endSymbol; i++)
            {
                Console.Write(((char)i).ToString());
            }
        }
    }
}
