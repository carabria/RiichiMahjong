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

        public bool isDealer { get; set; }
        public string Name { get; private set; }
        public List<Tile> Hand { get; set; } = new List<Tile>();
        public int Score { get; private set; } = 25000;

        public override string ToString()
        {
            return $"Name: {Name} - Score: {Score} - Hand Size: {Hand.Count}";
        }
        public void NamePlayer()
        {
            Console.WriteLine($"Please enter in a name.");
            string name = Console.ReadLine();
            Name = name;
        }
    }
}
