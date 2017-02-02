using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercises.MarioKart.Players;

namespace Exercises.MarioKart.Vehicles
{
    public class Sonnar : Kart
    {
        public Sonnar(Player player)
            : base(player) { }

        protected override int CalculateVelocityPerType()
        {
            var bonus = 0;
            if (base.Equipments.Count > 0)
                bonus = 2;
            return bonus;
        }
    }
}
