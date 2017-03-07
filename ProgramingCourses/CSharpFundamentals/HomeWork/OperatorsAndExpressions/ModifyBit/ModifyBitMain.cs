namespace ModifyBit
{
    using System;
    public class ModifyBitMain
    {
        public static void Main()
        {
            var number = ulong.Parse(Console.ReadLine());
            var bitPosition = int.Parse(Console.ReadLine());
            var bitValue = int.Parse(Console.ReadLine());
            if (bitValue == 1)
            {
                ulong mask = (ulong)1 << bitPosition;
                ulong result = number | mask;
                Console.WriteLine(result);
            }
            else
            {
                ulong mask =(ulong)~(1 << bitPosition);
                ulong result = number & mask;
                Console.WriteLine(result);
            }
        }
    }
}
