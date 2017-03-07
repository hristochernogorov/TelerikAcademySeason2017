namespace NthBit
{
    using System;

    public class NthBitMain
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var nBitPosition = int.Parse(Console.ReadLine());
            int mask = 1 << nBitPosition;
            long nAndMask = number & mask;
            long bit = nAndMask >> nBitPosition;
            Console.WriteLine(bit);
        }
    }
}
