using System;
using System.Collections.Generic;
using System.Text;

namespace Mahjong
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public List<Tile> Hand { get; set; } = new List<Tile>();
        public int Score { get; private set; } = 25000;
        public override string ToString()
        {
            return $"{Name} - {Score} - {Hand.Count}";
        }
        public string ShowHand()
        {
            foreach (Tile tile in Hand)
            {
                return base.ToString();
            }
            return "complete";
        }
    }
}
