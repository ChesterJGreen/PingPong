using PingPong.Enums;
using System;

namespace PingPong
{
    class MySelf : Player
    {
        public MySelf()
        {
            Name = "CJ";
            Handed = Handed.Right;
        }

        public Handed Handed { get; private set; }
    }
}
