using System;
using System.Collections.Generic;
using System.Text;

namespace Mahjong
{
    public class Tile
    {
        public string Suit { get; private set; }
        public string Value { get; private set; }

        public Tile(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} {Suit}";
        }
    }
}
