namespace VariableInHexDemFormat
{
    using System;

    public class HexDemFormatMain
    {
        public static void Main()
        {
            var intValue = 254;
            string hexValue = intValue.ToString("X");
            int intAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(intValue);
            Console.WriteLine(hexValue);
            Console.WriteLine(intAgain);
        }
    }
}
