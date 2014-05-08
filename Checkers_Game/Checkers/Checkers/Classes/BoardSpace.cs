using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    class BoardSpace
    {
        public BoardSpace(int x, int y)
        {
            mXPosition = x;
            mYPosition = y;
            ChipInContainer = null;
        }

        private int mXPosition;
        private int mYPosition;

        public int XPosition { get { return mXPosition; } set { mXPosition = value; } }
        public int YPosition { get { return mYPosition; } set { mYPosition = value; } }

        public Chip ChipInContainer { get; set; }

    }
}
