namespace PingPong
{
    class Opponent
    {
        public string Name { get; set; }
        public enum Handed { get; set; }
        public Wins WinSide { get; set; }
        public Wins Win { get; set; }
        public Losses LossSide { get; set; }
        public Losses Loss { get; set; }
        
    }
}
