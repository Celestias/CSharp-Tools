using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    class Game
    {
        int mNumberOfChipsToStartWith = 8;
        

        public Game()
        {
            TotalChipsInGame = new List<Chip>();
        }

        private List<Chip> mTotalChipsInGame;

        public List<Chip> TotalChipsInGame { get { return mTotalChipsInGame; } set { mTotalChipsInGame = value; } }
        public List<Player> Players { get; set; }
        public List<BoardSpace> BoardSpaces { get; set; }

        public Chip GetChipByID(string id)
        {
            foreach(Chip chip in mTotalChipsInGame)
            {
                if(chip.ID == id)
                    return chip;
            }
            return null;
        }

        public bool giveStartingChips(Player p)
        {
            try
            {
                //Uncomment line below to create an error just to test error handling
                //p.Chips.Add(new Chip(""));

                for (int i = 0; i < mNumberOfChipsToStartWith; i++)
                {
                    p.Chips = p.Chips == null ? new List<Chip>() : p.Chips;

                    Chip newChip = new Chip(Guid.NewGuid().ToString());
                    newChip.Color = p.ChipColor;
                    p.Chips.Add(newChip);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error giving starting chips to player!  Details: {0}", ex.Message));
            }
        }

        public BoardSpace getSpaceByCoordinates(int x, int y)
        {
            foreach (BoardSpace space in BoardSpaces)
            {
                if (space.XPosition == x && space.YPosition == y)
                    return space;
            }
            return null;
        }
    }
}
