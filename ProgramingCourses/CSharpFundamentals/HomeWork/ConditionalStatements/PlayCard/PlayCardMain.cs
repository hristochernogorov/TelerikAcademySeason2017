namespace PlayCard
{
    using System;
    using System.Collections.Generic;
    public class PlayCardMain
    {
        public static void Main()
        {
            var playCard = Console.ReadLine();
            switch (playCard)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("yes {0}",playCard);
                    break;
                default:
                    Console.WriteLine("no {0}",playCard);
                    break;
            }

        }
    }
}
