using System;
using System.Linq;

namespace Games.CardGames
{
    public class CardFactory
    {
        public Deck CreateDeck(int cardSets, bool createJokers)
        {
            var deck = new Deck();
            for (int i = 0; i < cardSets; i++)
            {
                deck.Push(CreateDeck(createJokers));
            }

            return deck;
        }

        private Deck CreateDeck(bool createJokers)
        {
            var deck = new Deck();
            foreach (var color in Enum.GetValues(typeof(Color)).Cast<Color>())
            {
                AddCardsForColor(deck, color, createJokers);
            }

            return deck;
        }

        private void AddCardsForColor(Deck deck, Color color, bool createJokers)
        {
            if (color != Color.None)
            {
                foreach (var number in Enum.GetValues(typeof(Number)).Cast<Number>())
                {
                    if (number == Number.Joker)
                    {
                        continue;
                    }
                    deck.Push(new Card(color, number));
                }

                return;
            }

            if (createJokers)
            {
                deck.Push(new Card(color, Number.Joker));
                deck.Push(new Card(color, Number.Joker));
            }
        }
    }
}
