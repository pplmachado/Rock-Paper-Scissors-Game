using System;
using TestRockPaperScissors;
using Xunit;

namespace TestRockPaperScissorsTests
{
    public class GameTest
    {
        [Fact]
        public void GameTestPaperWinner()
        {
            string[] playerOne = { "playerPaper", "P" };
            string[] playerTwo = { "playerRock", "R" };

            var winner = new Match(playerOne, playerTwo).VerifyWinner();

            Assert.Equal(playerOne, winner);
        }

        [Fact]
        public void GameTestScissorsWinner()
        {
            string[] playerOne = { "playerPaper", "P" };
            string[] playerTwo = { "playerScissors", "S" };

            var winner = new Match(playerOne, playerTwo).VerifyWinner();

            Assert.Equal(playerTwo, winner);
        }

        [Fact]
        public void GameTestRockWinner()
        {
            string[] playerOne = { "playerRock", "R" };
            string[] playerTwo = { "playerScissors", "S" };

            var winner = new Match(playerOne, playerTwo).VerifyWinner();

            Assert.Equal(playerOne, winner);
        }
    }
}
