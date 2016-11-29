namespace PrintDeck
{
    using System;
    using System.Collections.Generic;
    public class PrintDeckMain
    {
        public static void Main()
        {
            var card = Console.ReadLine();
            var cardFace = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var cardColor = new List<string> { "of spades,", "of clubs,", "of hearts,", "of diamonds" };
            foreach (var cards in cardFace)
            {
                foreach (var color in cardColor)
                {
                    Console.Write("{0} {1} ", cards, color);
                }
                Console.WriteLine();
                if (card == cards)
                {
                    break;
                }

            }
            Console.ReadLine();

        }
    }
}
