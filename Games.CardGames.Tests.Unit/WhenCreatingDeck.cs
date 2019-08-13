using FluentAssertions;
using Xunit;

namespace Games.CardGames.Tests.Unit
{
    public class WhenCreatingDeck
    {
        private readonly CardFactory _factory;

        public WhenCreatingDeck()
        {
            _factory = new CardFactory();
        }

        [Fact]
        public void GivenOneDeckNoJokers_ShouldCreate52Cards()
        {
            _factory
                .CreateDeck(1, false)
                .Should()
                .HaveCount(52);
        }

        [Fact]
        public void GivenOneDeckWithJokers_ShouldCreate54Cards()
        {
            _factory
                .CreateDeck(1, true)
                .Should()
                .HaveCount(54);
        }

        [Fact]
        public void GivenTwoDecksNoJokers_ShouldCreate52Cards()
        {
            _factory
                .CreateDeck(2, false)
                .Should()
                .HaveCount(104);
        }

        [Fact]
        public void GivenTwoDecksWithJokers_ShouldCreate54Cards()
        {
            _factory
                .CreateDeck(2, true)
                .Should()
                .HaveCount(108);
        }
    }
}
