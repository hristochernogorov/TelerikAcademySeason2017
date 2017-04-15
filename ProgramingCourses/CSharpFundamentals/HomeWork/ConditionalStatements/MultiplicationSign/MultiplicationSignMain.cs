namespace MultiplicationSign
{
    using System;
    using System.Collections.Generic;
    public class MultiplicationSignMain
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (a < 0 && b > 0 && c > 0)  //- + + = -
                {
                    Console.WriteLine("-");
                }
                else if (a > 0 && b < 0 && c > 0) //+ - + = -
                {
                    Console.WriteLine("-");
                }
                else if (a > 0 && b > 0 && c < 0) // + + - = -
                {
                    Console.WriteLine("-");
                }
                else if (a < 0 && b < 0 && c < 0) // - - - = +
                {
                    Console.WriteLine("-");
                }
                else if (a < 0 && b < 0 && c > 0) // - - + = +
                {
                    Console.WriteLine("+");
                }
                else if (a < 0 && b > 0 && c < 0)// - + - = +
                {
                    Console.WriteLine("+");
                }
                else if (a > 0 && b < 0 && c < 0) // + - - = +
                {
                    Console.WriteLine("+");
                }
                else if (a > 0 && b > 0 && c > 0) // + + + = +
                {
                    Console.WriteLine("+");
                }

            }

        }
    }
}
