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
            this.Name = name;
        }

        public string Name { get; private set; }

        public PlayerLevelEnum Level { get; set; }
    }
}
