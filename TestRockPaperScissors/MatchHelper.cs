using System;

namespace TestRockPaperScissors
{
    public class MatchHelper
    {
        public string EnumToString(MatchAct act)
        {
            switch (act)
            {
                case MatchAct.Rock:
                    return "R";
                case MatchAct.Paper:
                    return "P";
                case MatchAct.Scissors:
                    return "S";
                default:
                    throw new NoSuchStrategyError("Act is not valid.");
            }
        }
    }
}