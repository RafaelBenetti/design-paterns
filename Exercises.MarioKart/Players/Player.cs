using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises.MarioKart.Players
{
    public class Player
    {
        public Player(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidNameException("The player's name is required.");

            this.Name = name;
        }

        public Player(string name, PlayerLevelEnum level)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidNameException("The player's name is required.");

            this.Name = name;
            this.Level = level;
        }

        public string Name { get; private set; }

        public PlayerLevelEnum Level { get; set; }
    }
}
