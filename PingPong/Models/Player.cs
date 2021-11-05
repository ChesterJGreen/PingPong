using PingPong.Enums;

namespace PingPong
{
    class Player
    {
        public string Name { get; set; }
        public Handed PaddleHand{ get; set; }
        public Wins WinSide { get; set; }
        public Wins Win { get; set; }
        public Losses LossSide { get; set; }
        public Losses Loss { get; set; }
        
    }
}
