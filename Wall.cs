using System;
using System.Collections.Generic;
using System.Text;

namespace Mahjong
{
    public class Wall
    {
        public List<Tile> Tiles = new List<Tile>();

        private string[] suits = new string[] { "Pin", "Man", "Sou" };
        private string[] numberedValues = new string[] {"1", "2", "3", "4", "5",
                                                        "6", "7", "8", "9"};
        private string[] windValues = new string[] { "East", "South", "West", "North" };
        private string[] dragonValues = new string[] { "Red", "White", "Green" };

        public List<Tile> BuildWall()
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (string suit in suits)
                {
                    foreach (string value in numberedValues)
                    {
                        Tile tile = new Tile(suit, value);
                        Tiles.Add(tile);
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                foreach (string wind in windValues)
                {
                    Tile tile = new Tile("Wind", wind);
                    Tiles.Add(tile);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                foreach (string dragon in dragonValues)
                {
                    Tile tile = new Tile("Dragon", dragon);
                    Tiles.Add(tile);
                }
            }

            return Tiles;
        }

        public void ShuffleWall()
        {
            Random random = new Random();
            for (int i = 0; i < Tiles.Count; i++)
            {
                int j = random.Next(Tiles.Count);
                Tile temp = Tiles[i];
                Tiles[i] = Tiles[j];
                Tiles[j] = temp;
            }
        }

        public void DisplayWall()
        {
            foreach (Tile tile in Tiles)
            {
                Console.WriteLine(tile);
            }
        }
    }
}
