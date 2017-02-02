using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercises.MarioKart.Players;
using Exercises.MarioKart.Equipments;

namespace Exercises.MarioKart.Vehicles
{
    public class Sonnar : Kart
    {
        public Sonnar(Player player)
            : base(player) { }

        public Sonnar(Player player, List<IEquip> equips)
            : base(player, equips) { }

        protected override int CalculateVelocityPerType()
        {
            var bonus = 0;
            if (base.Equipments.Count > 0)
                bonus = 2;
            return bonus;
        }
    }
}
