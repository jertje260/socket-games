using System;
using System.Collections.Generic;
using System.Linq;

namespace Games.CardGames
{
    public class Deck : Stack<Card>
    {
        public void Push(Deck deck)
        {
            foreach (var card in deck)
            {
                Push(card);
            }
        }

        public void Shuffle()
        {
            var rnd = new Random();
            var values = ToArray();
            Clear();
            foreach (var value in values.OrderBy(x => rnd.Next()))
            {
                Push(value);
            }
        }
    }
}
