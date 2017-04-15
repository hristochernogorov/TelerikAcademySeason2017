namespace PlayCard
{
    using System;
    using System.Collections.Generic;
    public class PlayCardMain
    {
        public static void Main()
        {
            var card = Console.ReadLine();
            List<string> playCards = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            if (playCards.Contains(card))
            {
                Console.WriteLine("yes {0}", card);
            }
            else
            {
                Console.WriteLine("no {0}", card);
            }

        }
    }
}
