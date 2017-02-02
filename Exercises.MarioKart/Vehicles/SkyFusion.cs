using Exercises.MarioKart.Equipments;
using Exercises.MarioKart.Players;
using System.Collections.Generic;

namespace Exercises.MarioKart.Vehicles
{
    public class SkyFusion : Kart, IEquip
    {
        public SkyFusion(Player player) 
            : base(player) { }

        public SkyFusion(Player player, List<IEquip> equips)
            : base(player, equips) { }

        public int GetBonusValue()
        {            
            return Equipments.Count + GetPlayerBonus();
        }

        private int GetPlayerBonus()
        {
            int levelBonus = 0;

            if (Player.Level == PlayerLevelEnum.Beginner)
                levelBonus = 1;
            if (Player.Level == PlayerLevelEnum.Intermediate)
                levelBonus = 2;
            if (Player.Level == PlayerLevelEnum.Advanced)
                levelBonus = 3;

            return levelBonus;
        }

        protected override int CalculateVelocityPerType()
        {
            int bonus = 0;
            if (Velocity > 12)
                bonus = 5;
            return bonus;
        }
    }
}
