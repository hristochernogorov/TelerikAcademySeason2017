namespace PrintLongSequence
{
    using System;

    public class LongSequenceMain
    {
        public static void Main()
        {
            int i;
            int j = 1;
            for (i = 0; i < 1000; i += 2, j += 2, Console.WriteLine("{0}\n{1}", i, -j));
        }
    }
}
