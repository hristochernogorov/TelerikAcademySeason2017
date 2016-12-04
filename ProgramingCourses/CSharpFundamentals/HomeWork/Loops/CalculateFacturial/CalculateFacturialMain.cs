namespace CalculateFacturial
{
    using System;
    public class CalculateFacturialMain
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var facturialN = 1.0;
            var numXpowerN = 1.0;
            var sumOfSenquence = 1.0;
            //S = 1 + 1!/x + 2!/x2 + … + N!/xN

            for (int i = 1; i <= N; i++)
            {
                facturialN *= i;
                numXpowerN *= x;
                sumOfSenquence += (facturialN / numXpowerN);
            }

            Console.WriteLine("{0:F5}",sumOfSenquence);
        }
    }
}
