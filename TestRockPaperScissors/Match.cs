using System;

namespace TestRockPaperScissors
{
    public class Match
    {
        MatchHelper _matchHelper = new MatchHelper();

        public Match()
        {

        }

        public Match(string[] playerOne, string[] playerTwo)
        {
            this.playerOne = new Player(playerOne[0], playerOne[1]);
            this.playerTwo = new Player(playerTwo[0], playerTwo[1]);
        }
        private Player playerOne;
        private Player playerTwo;

        public string[] VerifyWinner()
        {
            if(playerOne.Act == MatchAct.Paper && playerTwo.Act == MatchAct.Rock || playerOne.Act == MatchAct.Paper && playerTwo.Act == MatchAct.Paper)
            {
                string[] winnerPaper = { $"{playerOne.Name}", "P" };                
                return winnerPaper;
            }

            if (playerOne.Act == MatchAct.Rock && playerTwo.Act == MatchAct.Scissors || playerOne.Act == MatchAct.Rock && playerTwo.Act == MatchAct.Rock)
            {
                string[] winnerRock = { $"{playerOne.Name}", "R" };
                return winnerRock;
            }

            if (playerOne.Act == MatchAct.Scissors && playerTwo.Act == MatchAct.Paper || playerOne.Act == MatchAct.Scissors && playerTwo.Act == MatchAct.Scissors)
            {
                string[] winnerScissors = { $"{playerOne.Name}", "S" };
                return winnerScissors;
            }

            var act = _matchHelper.EnumToString(playerTwo.Act);

            string[] winner = { $"{playerTwo.Name}", act };

            return winner;
        }
    }
}