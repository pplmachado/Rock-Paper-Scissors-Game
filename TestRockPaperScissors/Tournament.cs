using System;
using System.Collections.Generic;

namespace TestRockPaperScissors
{
    public class Tournament : Match
    {
        public string[] tournament;

        public Tournament(string[] tournament)
        {
            this.tournament = tournament;
        }

        public string[] rps_tournament_winner()
        {
            var totalPlayers = tournament.Length / 2;

            var listTournament = new List<string>(tournament);

            while(totalPlayers > 1)
            {
                for(int i = 0; i < totalPlayers; i += 2)
                {
                    string[] playerOne = { listTournament[i], listTournament[i + 1] };
                    string[] playerTwo = { listTournament[i + 2], listTournament[i + 3] };

                    var MatchWinner = new Match(playerOne, playerTwo).rps_game_winner();

                    if (MatchWinner[0] == listTournament[i])
                    {
                        listTournament.RemoveAt(i + 2);
                        listTournament.RemoveAt(i + 2);
                        continue;
                    }

                    listTournament.RemoveAt(i);
                    listTournament.RemoveAt(i);

                }

                totalPlayers = listTournament.Count / 2;

            }
            string[] winner =
            {
                listTournament[0], listTournament[1]
            };

            return winner;
        }
    }
}

