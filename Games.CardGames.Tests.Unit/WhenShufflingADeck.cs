using FluentAssertions;
using Xunit;

namespace Games.CardGames.Tests.Unit
{
    public class WhenShufflingADeck
    {
        private readonly Deck _deck;
        public WhenShufflingADeck()
        {
            _deck = new CardFactory().CreateDeck(1, true);
        }

        [Fact]
        public void GivenADeck_ShouldHaveSameCardCountAtTheEnd()
        {
            var cardCount = _deck.Count;

            _deck.Shuffle();

            _deck
                .Should()
                .HaveCount(cardCount);
        }

        [Fact]
        public void GivenADeck_ShouldNotHaveSameOrder()
        {
            var currentOrder = _deck.ToArray();

            _deck.Shuffle();

            var newOrder = _deck.ToArray();
            var different = false;

            for (int i = 0; i < currentOrder.Length; i++)
            {
                if (currentOrder[i].Id != newOrder[i].Id)
                {
                    different = true;
                    break;
                }
            }

            different
                .Should()
                .BeTrue("deck order should be different.");
        }
    }
}
