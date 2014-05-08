using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    public enum Seat
    {
        Top = 1,
        Bottom = 2
    }

    class Player
    {
        public List<Chip> Chips { get; set; }
        public ChipColor ChipColor { get; set; }
        public string Name { get; set; }
        public Seat Seat;

        public Player(string name, ChipColor color, Seat seat)
        {
            ChipColor = color;
            Name = name;
            Seat = seat;
        }
    }
}
