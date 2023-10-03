﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Mahjong
{
    public class Hand
    {
        public List<Tile> DealHand(List<Tile> tiles, List<Player> players)
        {
            int j = 4;
            for (int i = 0; i < 13; i += 4)
            {
                if (i == 12)
                {
                    j = 13;
                }
                tiles = DealTiles(tiles, players, i, j);
                j += 4;
            }
            return tiles;
        }
        public List<Tile> DealTiles(List<Tile> tiles, List<Player> players, int startingIndex, int endingIndex)
        {
            bool isDealer = false;
            List<Tile> tempTiles = new List<Tile>(tiles);
            foreach (Player player in players)
            {
                //an initial hand in mahjong is drawn in sets of 4 per player
                //then you draw 2 if dealer, and 1 if not a dealer.
                int playerTileIndex = startingIndex;
                while (playerTileIndex < endingIndex)
                {
                    player.Hand.Add(tiles[playerTileIndex]);
                    tempTiles.Remove(tiles[playerTileIndex]);
                    playerTileIndex++;
                }
                if (playerTileIndex == 13 && isDealer)
                {

                    player.Hand.Add(tiles[playerTileIndex]);
                    tempTiles.Remove(tiles[playerTileIndex]);
                }
                tiles = tempTiles;
            }
            return tiles;
        }
        public string ShowHand(Player player)
        {
            foreach (Tile tile in player.Hand)
            {
                Console.WriteLine(tile.ToString());
            }
            return "complete";
        }

        public List<Tile> DrawTile(List<Tile> tiles, Player player)
        {
            player.Hand.Add(tiles[0]);
            tiles.Remove(tiles[0]);
            return tiles;
        }

        public void DiscardTile(Player player, int tile)
        {
            player.Hand.Remove(player.Hand[tile]);
        }
    }
}