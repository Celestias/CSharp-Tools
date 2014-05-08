using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    public enum ChipColor
    {
        Red = 1,
        Black = 2
    }

    //Not used yet, not sure if we'll need.
    public enum MovementDirection
    {
        DownLeft = 0,
        DownRight = 1,
        UpLeft = 2,
        UpRight = 3
    }

    class Chip
    {        
        private string mID;

        public string ID { get { return mID; } set { mID = value; } }        
        public ChipColor Color { get; set; }

        public Chip(string id)
        {
            mID = id;            
        }

        public bool Move(BoardSpace sourceSpace, BoardSpace destinationSpace)
        {
            try
            {
                //Make sure this is moving a distance of 1 only.
                if (Math.Abs(sourceSpace.XPosition - destinationSpace.XPosition) > 1 || Math.Abs(sourceSpace.YPosition - destinationSpace.YPosition) > 1)
                    throw new Exception("Invalid move!  The chip may only move one space.");

                // Disallow bottom player from moving down
                if (sourceSpace.ChipInContainer.Color == ChipColor.Black)
                    if (Math.Abs(sourceSpace.YPosition) < (destinationSpace.YPosition))
                    throw new Exception("Invalid move!  You cant move that chip backwards.");
                
                // Disallow top player from moving up
                if (sourceSpace.ChipInContainer.Color == ChipColor.Red)
                    if (Math.Abs(sourceSpace.YPosition) > (destinationSpace.YPosition))
                        throw new Exception("Invalid move! You can't move that chip backwards.");

                //We are clear to move here
                if (destinationSpace.ChipInContainer == null)
                {
                    //Add the new chip in the new space
                    destinationSpace.ChipInContainer = sourceSpace.ChipInContainer;

                    //Get the old chip out of it's space                    
                    sourceSpace.ChipInContainer = null;
                }
                else
                {
                    throw new Exception("Invalid move!  There is already a chip on this position!");
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
