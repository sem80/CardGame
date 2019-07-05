using System;

namespace CardGame
{
    class Card
    {
        private string suit, face;

        public Card(string suit, string face)
        {
            this.face = face;
            this.suit = suit;
        }

        public String CardName()
        {
            return face + " of " + suit;
        }
    }
} 
