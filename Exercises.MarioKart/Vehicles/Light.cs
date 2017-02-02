using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercises.MarioKart.Players;
using Exercises.MarioKart.Equipments;

namespace Exercises.MarioKart.Vehicles
{
    public class Light : Kart
    {
        public Light(Player player) 
            : base(player) {  }

        public Light(Player player, List<IEquip> equips)
            : base(player, equips) { }

        protected override int CalculateVelocityPerType()
        {
            var bonus = 0;
            if (base.Player.Level == PlayerLevelEnum.Beginner)
                bonus = 3;
            if (base.Player.Level == PlayerLevelEnum.Advanced)
                bonus = -1;
            return bonus;
        }
    }
}
