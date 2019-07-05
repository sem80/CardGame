using System;
using System.Collections.Generic;

namespace CardGame
{
    class Deck
    {
        private List<Card> deck = new List<Card>();
    
        public Deck()
        {

            List<string> suits = new List<string> { "Clubs", "Spades", "Hearts", "Diamonds" };
            List<string> face = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (string x in suits)
            {
                foreach (string y in face)
                {
                    deck.Add(new Card(x, y));
                }
            }

            Console.WriteLine("New Deck Created!");

        

        }

        public void ShuffleDeck()
        {
            if (deck.Count == 0)
            {
                Console.WriteLine("No cards in deck. Please create new deck to shuffle cards.");
            }
            else
            {
                Random rand = new Random();
                for (int x = deck.Count - 1; x > 0; x--)
                {
                    int y = rand.Next(x + 1);
                    Card value = deck[y];
                    deck[y] = deck[x];
                    deck[x] = value;
                }

                Console.WriteLine("Current deck was shuffled");
            }



        }

        public void DrawCard()
        {
            if (deck.Count == 0)
            {
                Console.WriteLine("No cards in deck. Please create new deck to draw card.");
            }
            else
            {
                Console.WriteLine(deck[deck.Count - 1].CardName());
                deck.RemoveAt(deck.Count - 1);
            }
        }


        public void DisplayRemainingCards()
        {
            if (deck.Count == 0)
            {
                Console.WriteLine("No cards in deck. Please create new deck to display cards.");
            }
            else
            {
                foreach (Card c in deck)
                {
                    Console.WriteLine(c.CardName());
                }
            }
        }

    }


}
