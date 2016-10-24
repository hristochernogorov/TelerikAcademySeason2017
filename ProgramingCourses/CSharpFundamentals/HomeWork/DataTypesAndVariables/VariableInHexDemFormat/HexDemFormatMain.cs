namespace VariableInHexDemFormat
{
    using System;

    public class HexDemFormatMain
    {
        public static void Main()
        {
            var intValue = 254;
            var hexValue = intValue.ToString("X");
            Console.WriteLine(hexValue);
            var intAgain = int.Parse(hexValue,System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(intAgain);
        }
    }
}
