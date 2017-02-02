using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercises.MarioKart.Players;

namespace Exercises.MarioKart.Vehicles
{
    public class Dinam : Kart
    {
        public Dinam(Player player)
            : base(player) {  }

        protected override int CalculateVelocityPerType()
        {
            return (int)Player.Level;
        }
    }
}
