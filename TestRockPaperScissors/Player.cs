namespace TestRockPaperScissors
{
    public class Player
    {
        public Player()
        {
            
        }

        public Player(string name, string act)
        {
            _act = ValidadeEnumAct(act);
            _name = SetName(name);
        }

        private string _name;
        private MatchAct _act;

        public string Name { get => _name; set => SetName(value); }
        public MatchAct Act { get => _act; set => SetAct(value); }

        private string SetName(string newName)
        {
            return newName;
        }
        
        private void SetAct(MatchAct value)
        {
            _act = value;
        }

        private MatchAct ValidadeEnumAct(string newAct)
        {
            switch (newAct)
            {
                case "R":
                    return MatchAct.Rock;
                case "P":
                    return MatchAct.Paper;
                case "S":
                    return MatchAct.Scissors;
                default:
                    throw new NoSuchStrategyError("Act is not valid.");
            }
        }
    }
}