using TestRockPaperScissors;
using Xunit;

namespace TestRockPaperScissorsTests
{
    public class TournamentTest
    {
        [Fact]
        public void TournamentTestMethod()
        {
            string[] Winner = { "Richard", "R" };
            string[] tournament = { "Armando", "P", "Dave", "S", "Richard", "R", "Michael", "S", "Allen", "S", "Omer", "P", "David E.", "R", "Richard X.", "P" };

            var winner = new Tournament(tournament).rps_tournament_winner();

            Assert.Equal(Winner, winner);
        }
    }
}

