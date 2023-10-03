using System;
using System.Collections.Generic;
using System.Text;

namespace Mahjong
{
    public class UserInterface
    {
        private Wall Wall;
        private List<Player> players = new List<Player>()
            {
                new Player(""),
                new Player(""),
                new Player(""),
                new Player("")
            };
        private Hand hand = new Hand();

        public void Run()
        {
            Console.WriteLine("Welcome to the Mahjong Program.");
            bool isFinished = false;
            while (!isFinished)
            {
                Console.WriteLine("1: Build Wall");
                Console.WriteLine("2: Name Players");
                Console.WriteLine("3: Deal Hands");
                Console.WriteLine("E: Exit");
                Console.Write("Please enter in a value: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                switch (userInput)
                {
                    case "1":
                        MakeWall();
                        break;
                    case "2":
                        SetPlayerNames();
                        break;
                    case "3":
                        DealPlayerHands();
                        break;
                    case "E":
                    case "e":
                        isFinished = true;
                        Console.WriteLine("Thank you for playing.");
                        continue;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;
                }
            }
        }
        private void MakeWall()
        {
            Wall walls = new Wall();
            walls.BuildWall();
            walls.ShuffleWall();
            Wall = walls;
            Console.WriteLine("Wall made and shuffled.");
            Console.WriteLine();
        }
        private void SetPlayerNames()
        {
            foreach (Player player in players)
            {
                player.NamePlayer();
                string playerName = player.ToString();
                Console.WriteLine(playerName);
                Console.WriteLine();
            }
        }
        private void DealPlayerHands()
        {
            Wall.Tiles = hand.DealHand(Wall.Tiles, players);
            foreach (Player player in players)
            {
                hand.ShowHand(player);
                Console.WriteLine();
            }
        }
    }
}
