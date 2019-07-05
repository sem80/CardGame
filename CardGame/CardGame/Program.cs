using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
             
            Console.WriteLine("Q – quit the application");
            Console.WriteLine("N – get a new deck");
            Console.WriteLine("S – shuffle the current deck");
            Console.WriteLine("D – draw next card from current deck");
            Console.WriteLine("R – display on the console all of the cards remaining in the deck");
             
            string line;
            while (true)
            {
                line = Console.ReadLine();

                switch (line)
                {
                    case "Q":
                        ;
                        return;
                    case "N":
                        deck = new Deck();
                        break;
                    case "S":
                        deck.ShuffleDeck();
                        break;
                    case "D":
                        deck.DrawCard();
                        break;
                    case "R":
                        deck.DisplayRemainingCards();
                        break;
                    default:
                        Console.WriteLine("Please use one of the following when pressing Enter: ");
                        Console.WriteLine("Q – quit the application");
                        Console.WriteLine("N – get a new deck");
                        Console.WriteLine("S – shuffle the current deck");
                        Console.WriteLine("D – draw next card from current deck");
                        Console.WriteLine("R – display on the console all of the cards remaining in the deck");
                        break;

                }
            }
        }
    }
}
