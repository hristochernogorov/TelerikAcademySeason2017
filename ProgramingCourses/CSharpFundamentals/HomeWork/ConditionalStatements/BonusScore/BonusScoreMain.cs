namespace BonusScore
{
    using System;
    public class BonusScoreMain
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(input*10);
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine(input*100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(input*1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}
