using System;

namespace Games.CardGames
{
    public class Card
    {
        public Guid Id { get; }
        public Color Color { get; }
        public Number Number { get; }

        public Card(Color color, Number number)
        {
            Color = color;
            Number = number;
            Id = Guid.NewGuid();
        }

        public Card(Guid id, Color color, Number number)
        {
            Id = id;
            Color = color;
            Number = number;
        }
    }
}
