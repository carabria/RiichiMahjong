using System;
using System.Collections.Generic;

namespace Mahjong
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Wall walls = new Wall();
            Hand hand = new Hand();
            List<Player> players = new List<Player>()
            {
                new Player("PlayerOne"),
                new Player("PlayerTwo"),
                new Player("PlayerThree"),
                new Player("PlayerFour")
            };
            walls.BuildWall();
            walls.ShuffleWall();
            Console.WriteLine(walls.Tiles.Count);

            walls.Tiles = hand.DealHand(walls.Tiles, players);
            // need to work on getting ShowHand to work
            players[0].ShowHand();
            Console.WriteLine(walls.Tiles.Count);
            //hand.DisplayHand();
        }
    }
}
