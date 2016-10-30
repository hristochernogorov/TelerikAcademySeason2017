namespace BonusScore
{
    using System;
    public class BonusScoreMain
    {
        public static void Main()
        {
            var score = int.Parse(Console.ReadLine());

            switch (score)
            {
                case 1:
                    Console.WriteLine(10);
                    break;
                case 2:
                    Console.WriteLine(20);
                    break;
                case 3:
                    Console.WriteLine(30);
                    break;
                case 4:
                    Console.WriteLine(400);
                    break;
                case 5:
                    Console.WriteLine(500);
                    break;
                case 6:
                    Console.WriteLine(600);
                    break;
                case 7:
                    Console.WriteLine(7000);
                    break;
                case 8:
                    Console.WriteLine(8000);
                    break;
                case 9:
                    Console.WriteLine(9000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }

        }
    }
}
