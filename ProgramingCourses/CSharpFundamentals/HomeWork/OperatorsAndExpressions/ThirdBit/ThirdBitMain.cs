namespace ThirdBit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ThirdBitMain
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            int p = 3;             
            int mask = 1 << p;        
            int nAndMask = number & mask; 
            int bit = nAndMask >> p;  
            Console.WriteLine(bit);
        }
    }
}
