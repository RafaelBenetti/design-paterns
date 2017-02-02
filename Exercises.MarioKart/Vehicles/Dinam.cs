using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercises.MarioKart.Players;
using Exercises.MarioKart.Equipments;

namespace Exercises.MarioKart.Vehicles
{
    public class Dinam : Kart
    {
        public Dinam(Player player)
            : base(player) {  }

        public Dinam(Player player, List<IEquip> equips)
            : base(player, equips) { }

        protected override int CalculateVelocityPerType()
        {
            return (int)Player.Level;
        }
    }
}
