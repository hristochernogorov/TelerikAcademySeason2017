namespace BitExchange
{
    using System;
    public class BitExchangeMain
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            for (int i = 3; i <= 5; i++)
            {
                int bitOne = (int)(number >> i) & 1;
                int bitTwo = (int)(number >> (21 + i)) & 1;
                number = (uint)(number & (~(1 << (21 + i))) | (bitOne << (21 + i)));
                number = (uint)(number & (~(1 << i)) | (bitTwo << i));
            }
            Console.WriteLine(number);
            


        }
    }
}
